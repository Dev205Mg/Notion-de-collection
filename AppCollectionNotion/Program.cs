using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCollectionNotion
{
    class Program
    {
        static int Sommetableau(int[] t)
        {
            int somme = 0;
            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }


            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] tableau)
        {
            int max = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                if(tableau[i] > max)
                {
                    max = tableau[i];
                }
            }

            Console.WriteLine("Valeur maximale est : " + max);
        }

        static void AfficherValeurMinimale(int[] tableau)
        {
            int min = tableau[0];
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] < min)
                {
                    min = tableau[i];
                }
            }

            Console.WriteLine("Valeur minimale est : " + min);
        }

        static void Tableau()
        {
            /*int[] t = new int[5];
            t[0] = 2;
            t[1] = 45;
            t[2] = 10;
            t[3] = 1;
            t[4] = 3;*/
            //int[] t = { 200, 40, 15, 8, 12 };
            /*
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine("Somme : " + Sommetableau(t)); */
            Random rand = new Random();
            const int TAILLE_TABLEAU = 20;
            int[] t = new int[TAILLE_TABLEAU];
            for(int i = 0; i < t.Length; i++)
            {
                t[i] = rand.Next(101);
            }

            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimale(t);
        }

        /***************************** LIST **********************************/

            static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if (ordreDescendant)
            {
                for (int i = liste.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            // le plus long caractere
            string nomLePlusLong = "";
            for (int i = 0; i < liste.Count; i++)
            {
                if(liste[i].Length > nomLePlusLong.Length)
                {
                    nomLePlusLong = liste[i];
                }
            }

            Console.WriteLine("Le nom le plus long est : " + nomLePlusLong);


        }

        static void AfficherElementsCommuns(List<string> liste1, List<string> liste2)
        {
            for(int i = 0; i < liste2.Count; i++)
            {
                string nom = liste2[i];
                if (liste1.Contains(nom))
                {
                    Console.WriteLine(nom);
                }
            }
        }

        static void Listes()
        {
            /*
            List<int> liste = new List<int>();
            liste.Add(5);
            liste.Add(8);
            liste.Add(2); //  ceci
            liste.Add(12);
            liste.Add(2);
            liste.Add(2);
            liste.Add(2);
            //liste.Remove(2); // suprrime la premier 2 qu'il trouve
            liste.RemoveAt(1); // supprime la valeur dans l'inde 1
            AfficherListe(liste); */
            /*
                        var noms = new List<string>() { "jean", "Maradona"};

                        while (true)
                        {
                            Console.Write("Rentrer un nom (Appuyer sur Enter pour finir) : ");
                            string nom = Console.ReadLine();

                            if (nom == "")
                            {
                                break;
                            }
                            string nomMinus = nom.ToLower();
                            if (noms.Contains(nom) || noms.Contains(nomMinus))
                            {
                                Console.Write("Erreur, ce nom est déja dans la liste");
                                Console.WriteLine();
                            }
                            else
                            {
                                noms.Add(nom);
                            }
                        }
                        for(int i = noms.Count-1; i >= 0; i--)
                        {
                            int nbrMots = noms[i].Length;
                            if(noms[i][nbrMots-1] == 'e')
                            {
                                noms.RemoveAt(i);
                            }
                        }
                        AfficherListe(noms); */

            var liste1 = new List<string>() {"paul", "jean", "pierre", "emilie", "martin" };
            var liste2 = new List<string>() {"sofie", "jean", "toto", "chriso", "martin", "paul" };

            AfficherElementsCommuns(liste1, liste2);
        }
        /********************************* ARRAY_LIST ************************************/

        static void ArrayList()
        {
            // Ne jamais utiliser sauf au cas extreme (Arraylist)
            ArrayList a = new ArrayList();
            a.Add("String");
            a.Add(49);
            a.Add(true);

            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
        /*************************** Lists de listes ***************************************/

        static void ListesDeListes()
        {
            var villes = new List<List<string>>();
            //var france = new List<string>() {"France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" }; mitovy @ ambany io
            villes.Add(new List<string>() { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });//0
            villes.Add(new List<string>() { "Etats-unis", "Washington","New-York", "Chicago", "Los Angeles", "San Francisco"});//1
            villes.Add(new List<string>() { "Espagne", "Madrid", "Barcelone", "Séville"});//2
            villes.Add(new List<string>() { "Italie", "Rome", "Venise", "Florence", "Milan", "Pise" });//3

            for(int i = 0; i < villes.Count; i++)
            {
                var pays = villes[i]; // type list
                Console.WriteLine(pays[0] + " - " + (pays.Count - 1) + " villes");
                for (int j = 1; j < pays.Count; j++)
                {
                    Console.WriteLine(" "+ pays[j]);
                }
                Console.WriteLine();
                
            }
        }
        /********************************* DICTIONNAIRE ***************************************/

        static void Dictionnaire()
        {
            string personneAChercher = "Marie";
            //Dictionary
            //clef -> valeur
            // ex : nom -> numero de telephone
            var d = new Dictionary<string, string>();
            d.Add("Jean", "264654653131654");
            d.Add("Marie", "456653131654");
            d["Martin"] = "457896522233545";
            d["Toto"] = "4578995466522233545";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("cette personne n'a pas  été trouvée");
            }
            
        }

        static void BoucleForEach()
        {/*
            var noms = new string[] { "Toto", "Jean", "Pierre" };


            foreach(var nom in noms) // pour chaque nom dans noms
            {
                Console.WriteLine(nom);
            }*/
            var d = new Dictionary<string, string>();
            d.Add("Jean", "264654653131654");
            d.Add("Marie", "456653131654");
            d["Martin"] = "457896522233545";
            d["Toto"] = "4578995466522233545";

            foreach(var e in d)
            {
                Console.WriteLine(e.Key + " -> " + e.Value);
            }
        }

        /*************************************** Boucle ForEach ********************************/

        static void TrisEtLinq()
        {/*
            var noms = new List<string>() { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Martin", "Benoit", "Vincent"};
            //noms = noms.OrderByDescending(nom => nom[nom.Length-1]).ToList();
            noms = noms.Where(nom=>nom[nom.Length-1] != 'e').ToList();

            foreach(var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var notes = new List<int> {4, 8, 1, 9, 2 };

            notes = notes.OrderBy(note => -note).ToList();
            notes = notes.Where(note => note >= 5).ToList();

            foreach(var note in notes)
            {
                Console.WriteLine(note);
            }
        }
        /********************************* Passage par valeur ou reference *******************************/

        static void Mafonction(out int p) // il y a out;
        {
            p = 10;
        }

        static void Mafonction2(List<int> p)
        {
            p[0] = 10;
        }

        static void PassageValeurOuRef()
        {
            int a = 5;
            //Mafonction(a);// Passage par valeur; seule la valeur de qui est passée en vatiable p;

            //var l = new List<int> { 5};

            //Mafonction2(l); // passage par réference ; les collection;
            int num = 0;
            //int.TryParse("4dgfd", out num); return bool;


            Mafonction(out a); // passage par reference mot clé out;
            Console.WriteLine(a);

        }

        static void Main(string[] args)
        {
            //Tableau();
            //Listes();
            //ArrayList();
            //ListesDeListes();
            //Dictionnaire();
            //BoucleForEach();
            //TrisEtLinq();
            PassageValeurOuRef();
            Console.ReadKey();
        }
    }
}
