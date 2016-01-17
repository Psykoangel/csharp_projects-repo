using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test04CsCalc
{
    class Program
    {
        static void Main( string[] args )
        {
            if (args.Length == 0)
            {
                AfficherAide();
            }
            else
            {
                string operateur = args[0];
                switch (operateur)
                {
                    case "addition":
                        Addition(args);
                        break;
                    case "multiplication":
                        Multiplication(args);
                        break;
                    case "moyenne":
                        Moyenne(args);
                        break;
                    default:
                        AfficherAide();
                        break;
                }
            }
        }

        static void AfficherAide()
        {
            Console.WriteLine("Utilisez l'application de la manière suivante :");
            Console.WriteLine("MonProgamme addition 2 5");
            Console.WriteLine("MonProgamme multiplication 2 5");
            Console.WriteLine("MonProgamme moyenne 2 5 10 11");
        }

        static void Addition( string[] args )
        {
            if (args.Length != 3)
            {
                AfficherAide();
            }
            else
            {
                double somme = 0;
                for (int i = 1; i < args.Length; i++)
                {
                    double valeur;
                    if (!double.TryParse(args[i], out valeur))
                    {
                        AfficherAide();
                        return;
                    }
                    somme += valeur;
                }
                Console.WriteLine("Résultat de l'addition : " + somme);
            }
        }

        static void Multiplication( string[] args )
        {
            if (args.Length != 3)
            {
                AfficherAide();
            }
            else
            {
                double resultat = 1;
                for (int i = 1; i < args.Length; i++)
                {
                    double valeur;
                    if (!double.TryParse(args[i], out valeur))
                    {
                        AfficherAide();
                        return;
                    }
                    resultat *= valeur;
                }
                Console.WriteLine("Résultat de la multiplication : " + resultat);
            }
        }

        static void Moyenne( string[] args )
        {
            double total = 0;
            for (int i = 1; i < args.Length; i++)
            {
                double valeur;
                if (!double.TryParse(args[i], out valeur))
                {
                    AfficherAide();
                    return;
                }
                total += valeur;
            }
            total = total / (args.Length - 1);
            Console.WriteLine("Résultat de la moyenne : " + total);
        }
    }
}
