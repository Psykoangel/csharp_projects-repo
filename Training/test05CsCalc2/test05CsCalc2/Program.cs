using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test05CsCalc2
{
    class Program
    {
        static void Main( string[] args )
        {
            bool ok = false;
            if (args.Length > 0)
            {
                string operateur = args[0];
                switch (operateur)
                {
                    case "addition":
                        ok = Addition(args);
                        break;
                    case "multiplication":
                        ok = Multiplication(args);
                        break;
                    case "moyenne":
                        ok = Moyenne(args);
                        break;
                }
            }

            if (!ok)
                AfficherAide();
        }

        static void AfficherAide()
        {
            Console.WriteLine("Utilisez l'application de la manière suivante :");
            Console.WriteLine("MonProgamme addition 2 5");
            Console.WriteLine("MonProgamme multiplication 2 5");
            Console.WriteLine("MonProgamme moyenne 2 5 10 11");
        }

        static bool Addition( string[] args )
        {
            if (args.Length != 3)
                return false;

            double somme = 0;
            for (int i = 1; i < args.Length; i++)
            {
                double valeur;
                if (!double.TryParse(args[i], out valeur))
                    return false;
                somme += valeur;
            }

            Console.WriteLine("Résultat de l'addition : " + somme);
            return true;
        }

        static bool Multiplication( string[] args )
        {
            if (args.Length != 3)
                return false;
            double resultat = 1;
            for (int i = 1; i < args.Length; i++)
            {
                double valeur;
                if (!double.TryParse(args[i], out valeur))
                    return false;
                resultat *= valeur;
            }
            Console.WriteLine("Résultat de la multiplication : " + resultat);
            return true;
        }

        static bool Moyenne( string[] args )
        {
            double total = 0;
            for (int i = 1; i < args.Length; i++)
            {
                double valeur;
                if (!double.TryParse(args[i], out valeur))
                    return false;
                total += valeur;
            }
            total = total / (args.Length - 1);
            Console.WriteLine("Résultat de la moyenne : " + total);
            return true;
        }
    }
}
