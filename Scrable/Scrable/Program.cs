using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            List<string> Lmot = new List<string>();
            List<string> Entree = new List<string>() {"arrest","rarest","raster","raters", "sartre","starer", "waster" , "waters" , "wrest","wrase" };
            //List<string> Entree = new List<string>() { "because", "first", "these", "could", "which" };

            for (int i = 0; i < N; i++)
            {
                string W = Entree[i];
                if (W.Length <= 7) Lmot.Add(W);
            }
            
            string LETTERS = "arwtsre";
            string mot = JeuxScrable(Lmot, LETTERS);

            Console.WriteLine(mot);
        }

        static string JeuxScrable(List<string> listMot, string LETTERS)
        {
           


            List<string> unPoint = new List<string>() { "e", "a", "i", "o", "n", "r", "t", "l", "s", "u" };
            List<string> deuxPoint = new List<string>() { "d", "g" };
            List<string> troisPoint = new List<string>() { "b", "c", "m", "p" };
            List<string> quatrePoint = new List<string>() { "f", "h", "v", "w", "y" };
            List<string> huitPoint = new List<string>() { "j", "x" };
            List<string> dixPoint = new List<string>() { "q", "z" };




            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            List<string> listLettre = StringToList(LETTERS);


            int score = 0;
            int scroreMax = 0;
            string motChampion = "";

            for (int i = 0; i < listMot.Count(); i++)
            {
                if (VerifieMot(listLettre, listMot[i]) && VerifieDoublon(listLettre, StringToList(listMot[i])))
                {
                    for (int j = 0; j < listMot[i].Length; j++)
                    {


                        if (unPoint.Contains(listMot[i].Substring(j, 1)))
                            score += 1;

                        if (deuxPoint.Contains(listMot[i].Substring(j, 1)))
                            score += 2;

                        if (troisPoint.Contains(listMot[i].Substring(j, 1)))
                            score += 3;

                        if (quatrePoint.Contains(listMot[i].Substring(j, 1)))
                            score += 4;

                        if (listMot[i].Substring(j, 1) == "k")
                            score += 5;

                        if (huitPoint.Contains(listMot[i].Substring(j, 1)))
                            score += 8;

                        if (dixPoint.Contains(listMot[i].Substring(j, 1)))
                            score += 10;



                    }
                    if (score > scroreMax)
                    {
                        scroreMax = score;
                        motChampion = listMot[i];
                    }
                    score = 0;
                }
            }



            return motChampion;
        }

        static bool VerifieMot(List<string> listLettre, string mot)
        {
            bool verif = false;
            for (int j = 0; j < mot.Length; j++)
            {

                verif = listLettre.Contains(mot.Substring(j, 1));
                if (verif == false) return false;

            }

            return verif;
        }


        

        static bool VerifieDoublon(List<string> listLettre, List<string> listMot)
        {
            List<string> ts_listLettre = new List<string>();
            List<string> ts_listMot = new List<string>();
         
            int cpt = 0;
            string lettre;
            
            for(int i=0;i<listLettre.Count();i++)
            {
                lettre = listLettre[i];
                foreach (string c in listLettre)
                {
                    if (c == lettre) cpt++;
                }
                ts_listLettre.Add(lettre + cpt.ToString());
                cpt = 0;
            }

           
            for(int i = 0;i < listMot.Count();i++)
            {
                lettre = listMot[i];
                foreach(string c in listMot)
                {
                    if (c == lettre) cpt++;
                }
                ts_listMot.Add(lettre + cpt.ToString());
                cpt = 0;
            }


            foreach (string l in ts_listMot)
            {

                foreach (string i in ts_listLettre)
                {
                    
                    if (l.Substring(0,1) == i.Substring(0,1) && int.Parse(l.Substring(1,1)) > int.Parse(i.Substring(1,1)))
                    {
                        return false;
                    }
                   // if (!ts_listLettre.Contains(l)) return false;
                }

            }

            return true;

        }

        static List<string> StringToList(string mot)
        {

            List<string> result = new List<string>();

            for (int i = 0; i < mot.Length; i++)
            {
                result.Add(mot.Substring(i, 1));
            }

            return result;
        }


    }
}
