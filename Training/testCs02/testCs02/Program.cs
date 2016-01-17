using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testCs02
{
    class Program
    {
        enum Jours
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        static void Main( string[] args )
        {
            Jours JourDeLaSemaine = Jours.Dimanche;
            string name = "Allan";
            int age = 20;
            int nombre = 50;
            int nB = AffichageBienvenue(name, age, nombre);
            int nb2 = AffichageBienvenue(name, age, nombre);
            string[] tab = new string[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine( Environment.NewLine );
            Array.Sort(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }

            Console.WriteLine(Environment.NewLine);
            List<int> ListDeChiffre = new List<int>();
            ListDeChiffre.Add(8);
            ListDeChiffre.Add(56);
            ListDeChiffre.Add(1);
            ListDeChiffre.Add(61);
            ListDeChiffre.Add(125);

            foreach (int i in ListDeChiffre)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Environment.NewLine);
            ListDeChiffre.RemoveAt(2);
            foreach (int i in ListDeChiffre)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Environment.NewLine);

            List<string> jours = new List<string>();
            jours.Add("Lundi");
            jours.Add("Mardi");
            jours.Add("Mercredi");
            jours.Add("Jeudi");
            jours.Add("Vendredi");
            jours.Add("Samedi");
            jours.Add("Dimanche");

            int indice = jours.IndexOf("Vendredi");

            Console.WriteLine("L\'indice de Vendredi est : " + indice);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(JourDeLaSemaine);
            Console.WriteLine(Environment.NewLine);
            JourDeLaSemaine = Jours.Lundi;
            Console.WriteLine(JourDeLaSemaine);
            Console.WriteLine(Environment.NewLine);

            
        }

        static int AffichageBienvenue( string nom, int age, int nombre )
        {
            Console.WriteLine("Bonjour " + nom + Environment.NewLine + "Tu as " + age + " ans !");
            Console.WriteLine("-------" + Environment.NewLine);
            Console.WriteLine("\tBienvenue dans le monde merveilleux du C#");
            nombre -= age;
            Console.WriteLine("\t\tLe nombre calculé est " + nombre);
            return nombre;
        }
    }
}
