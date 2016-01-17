using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqTest
{
    class Program
    {
        static void Main( string[] args )
        {
            List<Client> listClient = new List<Client> {
                new Client(1, "Jean", "Kim", 25),
                new Client(2, "Yin-Wu", "Kim", 25),
                new Client(6, "Alley", "Kinning", 16),
                new Client(3, "Kelly", "Longley", 18),
                new Client(4, "Julie", "Hoffney", 23),
                new Client(7, "Kony", "Rogers", 15),
                new Client(8, "Rob", "Flown", 17),
                new Client(5, "Charles", "Hebs", 33)
                };

            List<Consommation> listConso = new List<Consommation>
                                               {
                                                   new Consommation(1, 2, "Banana Punch"),
                                                   new Consommation(2, 4, "Strawberry Juice"),
                                                   new Consommation(3, 4, "Explosive Vodka"),
                                                   new Consommation(4, 3, "Tiny Whisky"), 
                                                   new Consommation(5, 1, "Frozen Kitty"),
                                                   new Consommation(6, 5, "Fresch Rock"),
                                                   new Consommation(7, 4, "Quiet Waterfall")
                                               };

            List<int> liste = new List<int> {2, 5, 8, 51, 100, 34, 28, 1};
            liste.Add(12);

            var lstRq = from i in listClient
                        join c in listConso on i.Id equals c.IdClient
                        where i.Age > 18
                        group c by new {c.IdClient, i.Nom, i.Prenom, i.Age};

            foreach (var i in lstRq)
            {
                Console.WriteLine(i.Key.Nom + ' ' + i.Key.Prenom + "  Age : " + i.Key.Age);
                foreach (var p in i)
                {
                    Console.WriteLine("\tCette personne a consommé : " + p.NomConso);
                }
            }
        

    
        }
    }

    class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        public Client()
        {
            
        }

        public Client(int id, string prenom, string nom, int age )
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }
    }

    class Consommation
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string NomConso { get; set; }

        public Consommation()
        {
            
        }

        public Consommation(int id, int IdClient, string conso)
        {
            this.Id = id;
            this.IdClient = IdClient;
            this.NomConso = conso;
        }
    }
}
