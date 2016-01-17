using Code.Couche_IHM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///Classe de test pour gst_EquipTest, destinée à contenir tous
    ///les tests unitaires gst_EquipTest
    ///</summary>
    [TestClass()]
    public class gst_EquipTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur gst_Equip
        ///</summary>
        [TestMethod()]
        public void gst_EquipConstructorTest()
        {
            gst_Equip target = new gst_Equip();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Code.exe")]
        public void InitializeComponentTest()
        {
            gst_Equip_Accessor target = new gst_Equip_Accessor(); // TODO: initialisez à une valeur appropriée
            target.InitializeComponent();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btn_add_equip_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Code.exe")]
        public void btn_add_equip_ClickTest()
        {
            gst_Equip_Accessor target = new gst_Equip_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btn_add_equip_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour btn_del_equip_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Code.exe")]
        public void btn_del_equip_ClickTest()
        {
            gst_Equip_Accessor target = new gst_Equip_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.btn_del_equip_Click(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour changeVisibility
        ///</summary>
        [TestMethod()]
        public void changeVisibilityTest()
        {
            gst_Equip target = new gst_Equip(); // TODO: initialisez à une valeur appropriée
            bool boolean = false; // TODO: initialisez à une valeur appropriée
            target.changeVisibility(boolean);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour chkb_equip_motor_CheckedChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Code.exe")]
        public void chkb_equip_motor_CheckedChangedTest()
        {
            gst_Equip_Accessor target = new gst_Equip_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.chkb_equip_motor_CheckedChanged(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour gst_Equip_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Code.exe")]
        public void gst_Equip_LoadTest()
        {
            gst_Equip_Accessor target = new gst_Equip_Accessor(); // TODO: initialisez à une valeur appropriée
            object sender = null; // TODO: initialisez à une valeur appropriée
            EventArgs e = null; // TODO: initialisez à une valeur appropriée
            target.gst_Equip_Load(sender, e);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
