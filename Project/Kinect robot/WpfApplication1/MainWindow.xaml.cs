using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using Kinect.Toolbox;
using System.Diagnostics;

using Coding4Fun.Kinect.Wpf;
using Microsoft.Research.Kinect.Audio;
using Microsoft.Research.Kinect.Nui;
using NKH.MindSqualls.MotorControl;
using NKH.MindSqualls;

using MessageBox = System.Windows.MessageBox;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        private Runtime _nui;
        private NotifyIcon _notifyIcon = new NotifyIcon();
        McNxtBrick brick = new McNxtBrick(NxtCommLinkType.Bluetooth, 4);
       
        bool flag_gauche = false;
        bool flag_droite = false;
        Nxt2ColorSensor couleur = new Nxt2ColorSensor();
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
            _nui = Runtime.Kinects[0]; // initialisation du runtime
            _nui.VideoFrameReady += nui_VideoFrameReady;
            _nui.SkeletonFrameReady += nui_SkeletonFrameReady; // ajout du skeleton
            _notifyIcon.Visible = true; // icon de l'executable

            brick.MotorA = new McNxtMotor();
            brick.MotorB = new McNxtMotor();
            brick.MotorC = new McNxtMotor();
            brick.Sensor3 = couleur;
            brick.Connect();
            brick.StartMotorControl();        
        }

        //****************************//
        void nui_VideoFrameReady(object sender, ImageFrameReadyEventArgs evt)
        {
            PlanarImage imgKinect = evt.ImageFrame.Image;

            imageRGB.Source = BitmapSource.Create(imgKinect.Width, imgKinect.Height, 96, 96, PixelFormats.Bgr32,
                                                    null, imgKinect.Bits, imgKinect.Width * imgKinect.BytesPerPixel);
        }
        /**********************************la fonction du skeletons*************************************************************/

        private Point getDisplayPosition(Joint joint)
        {
            float depthX, depthY;
            _nui.SkeletonEngine.SkeletonToDepthImage(joint.Position, out depthX, out depthY);
            depthX = Math.Max(0, Math.Min(depthX * 320, 320));
            depthY = Math.Max(0, Math.Min(depthY * 240, 240));
            int colorX, colorY;
            ImageViewArea iv = new ImageViewArea();
            _nui.NuiCamera.GetColorPixelCoordinatesFromDepthPixel(ImageResolution.Resolution640x480, iv, (int)depthX, (int)depthY, (short)0, out colorX, out colorY);
            return new Point((int)(skeleton.Width * colorX / 640.0), (int)(skeleton.Height * colorY / 480));
        }

        Polyline getBodySegment(JointsCollection joints, params JointID[] ids)
        {
            PointCollection points = new PointCollection(ids.Length);
            for (int i = 0; i < ids.Length; ++i)
            {
                points.Add(getDisplayPosition(joints[ids[i]]));
            }

            Polyline polyline = new Polyline();
            polyline.Points = points;
            polyline.Stroke = new SolidColorBrush(Color.FromRgb(51, 255, 51));
            polyline.StrokeThickness = 10;
            return polyline;
        }

        public void nui_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            SkeletonFrame frame = e.SkeletonFrame;
          
            _nui.SkeletonEngine.TransformSmooth = true;
            _nui.SkeletonEngine.SmoothParameters = new TransformSmoothParameters
            {
                Smoothing = 0.75f,
                Correction = 0.1f,
                Prediction = 0.05f,
                JitterRadius = 0.5f,
                MaxDeviationRadius = 0.04f
            };

            skeleton.Children.Clear();
            foreach (SkeletonData data in frame.Skeletons)
            {
                if (SkeletonTrackingState.Tracked == data.TrackingState) // si on detecte un skeletons
                {
                    // fontion pour dessiner les os du skeletons

                    skeleton.Children.Add(getBodySegment(data.Joints, JointID.HipCenter, JointID.Spine, JointID.ShoulderCenter, JointID.Head));
                    skeleton.Children.Add(getBodySegment(data.Joints, JointID.ShoulderCenter, JointID.ShoulderLeft, JointID.ElbowLeft, JointID.WristLeft, JointID.HandLeft));
                    skeleton.Children.Add(getBodySegment(data.Joints, JointID.ShoulderCenter, JointID.ShoulderRight, JointID.ElbowRight, JointID.WristRight, JointID.HandRight));
                    skeleton.Children.Add(getBodySegment(data.Joints, JointID.HipCenter, JointID.HipLeft, JointID.KneeLeft, JointID.AnkleLeft, JointID.FootLeft));
                    skeleton.Children.Add(getBodySegment(data.Joints, JointID.HipCenter, JointID.HipRight, JointID.KneeRight, JointID.AnkleRight, JointID.FootRight));

                    // fonction pour dessiner les joints ( les 20 points du skeletons)
                    foreach (Joint joint in data.Joints) // pour chaque point du skelete
                    {
                        var scaledJoint = getDisplayPosition(joint);
                        Ellipse ellipse = new Ellipse
                        {
                            Fill = new SolidColorBrush(Color.FromRgb(0, 0, 0)),
                            Width = 15,
                            Height = 15,
                            Margin = new Thickness(scaledJoint.X - 8, scaledJoint.Y, 0, 0)
                        };
                        skeleton.Children.Add(ellipse);
                    }
                    if (data.Joints[JointID.HandRight].TrackingState == JointTrackingState.Tracked
                        && data.Joints[JointID.HandLeft].TrackingState == JointTrackingState.Tracked) // on regarde si on a bien la main gauche et la main droite
                    {
                        Joint main_droite = data.Joints[JointID.HandRight];
                        Joint main_gauche = data.Joints[JointID.HandLeft];
                        Joint nombril = data.Joints[JointID.HipCenter];
                        Joint genou_droit = data.Joints[JointID.KneeRight];
                        Joint genou_gauche = data.Joints[JointID.KneeLeft];
                        if (main_droite.Position.Z < nombril.Position.Z - 0.3 && main_gauche.Position.Z < nombril.Position.Z - 0.3)
                        {
                            couleur.SetLightSensorMode(Nxt2Color.Blue);
                            brick.MotorB.Run(-100, 0);
                            brick.MotorC.Run(-100, 0);
                            
                            if (main_droite.Position.Y > main_gauche.Position.Y + 0.2 && main_droite.Position.Y > nombril.Position.Y && main_gauche.Position.Y > nombril.Position.Y)
                            {
                                couleur.SetLightSensorMode(Nxt2Color.Green);
                                if (flag_gauche == false)
                                    brick.MotorA.Run(-50, 85);
                                flag_droite = false;
                                flag_gauche = true;
                            }
                            else if (main_gauche.Position.Y > main_droite.Position.Y + 0.2 && main_droite.Position.Y > nombril.Position.Y && main_gauche.Position.Y > nombril.Position.Y)
                            {
                                couleur.SetLightSensorMode(Nxt2Color.Green);
                                if (flag_droite == false)
                                    brick.MotorA.Run(50, 85);
                                flag_gauche = false;
                                flag_droite = true;
                            }
                            else
                            {
                                flag_droite = false;
                                flag_gauche = false;
                            }
                        }
                        if (main_droite.Position.Z < nombril.Position.Z && main_droite.Position.Z > nombril.Position.Z - 0.3 && main_gauche.Position.Z < nombril.Position.Z && main_gauche.Position.Z > nombril.Position.Z - 0.3)
                        {
                            couleur.SetLightSensorMode(Nxt2Color.Red);
                            brick.MotorB.Run(50, 0);
                            brick.MotorC.Run(50, 0);
                            if (main_droite.Position.Y > main_gauche.Position.Y + 0.2 && main_droite.Position.Y > nombril.Position.Y && main_gauche.Position.Y > nombril.Position.Y)
                            {
                                couleur.SetLightSensorMode(Nxt2Color.Green);
                                if (flag_gauche == false)
                                    brick.MotorA.Run(-50, 80);
                                flag_droite = false;
                                flag_gauche = true;
                            }
                            else if (main_gauche.Position.Y > main_droite.Position.Y + 0.2 && main_droite.Position.Y > nombril.Position.Y && main_gauche.Position.Y > nombril.Position.Y)
                            {
                                couleur.SetLightSensorMode(Nxt2Color.Green);
                                if (flag_droite == false)
                                    brick.MotorA.Run(50, 80);
                                flag_gauche = false;
                                flag_droite = true;
                            }
                            else
                            {
                                flag_droite = false;
                                flag_gauche = false;
                            }
                        }
                        if (main_gauche.Position.Y < nombril.Position.Y && main_droite.Position.Y < nombril.Position.Y)
                        {
                            brick.MotorB.Brake();
                            brick.MotorC.Brake();
                        }
                    }
                    else
                    {
                        brick.MotorA.Brake();
                        brick.MotorB.Brake();
                        brick.MotorC.Brake();
                    }
                }
            }
        }

        /*******************************************initialisation du kinect************************************************************************/
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                _nui.Initialize(RuntimeOptions.UseColor | RuntimeOptions.UseDepthAndPlayerIndex | RuntimeOptions.UseSkeletalTracking);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur : Vérifiez le branchement de la Kinect."); //Erreur
                return;
            }
            try
            {
                _nui.VideoStream.Open(ImageStreamType.Video, 2, ImageResolution.Resolution1280x1024, ImageType.Color);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur : Impossible de récupérer le flux vidéo");
                return;
            }
        }
    }
}