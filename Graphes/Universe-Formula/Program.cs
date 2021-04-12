using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/tmp/documents/";
            string fName = "universe-formula";
            string target = Find(path, fName,"");

            if (target != null) target = target.Replace("\\", "/");

            Console.Write(target);

            Console.ReadKey();
        }

        private static string Find(string path, string fName,string chemin)
        {

            if(chemin == "")
            {
                foreach (string sDirectoryName in Directory.GetDirectories(path))
                {

                    foreach (string sFileName in Directory.GetFiles(sDirectoryName))
                    {
                        if (sFileName.Contains(fName))
                        {
                            chemin = sFileName;
                            return chemin;
                        }

                    }

                    if (sDirectoryName.Contains("\\"))
                    {
                        string tempo = sDirectoryName.Replace("\\", "/");
                      
                       tempo = Find(tempo, fName, chemin);

                        if (tempo != "") return tempo;

                    }

                    else
                    {
                      
                        string tempo = Find(sDirectoryName, fName, chemin);
                        if (tempo != "") return tempo;
                    }

                }
                

            }

            return chemin;
            
        }
    }
}
