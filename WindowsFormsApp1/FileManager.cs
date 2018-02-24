using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CG.Web.MegaApiClient;

namespace WindowsFormsApp1
{
    public class FileManager
    {
        public static List<string> Slozky { get; set; } = new List<string>();
        public static List<string> Soubory { get; set; } = new List<string>();

        public static void DirSearch(string dir)
        {

            try
            {
                foreach (string f in Directory.GetFiles(dir))
                    Soubory.Add(f);
                foreach (string d in Directory.GetDirectories(dir))
                {
                    Slozky.Add(d);
                    DirSearch(d);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void clear()
        {
            Slozky.Clear();
            Soubory.Clear();
        }

        public static List<string> ZkratNazvy(List<string> target)
        {
            List<string> zkracene = new List<string>();
            foreach (string s in target)
            {
                zkracene.Add(s.Substring(s.LastIndexOf('\\') + 1));

            }

            return zkracene;
        }

        public static string ZkratNazvy(string target)
        {
            string s;
            try
            {
                return target.Substring(target.LastIndexOf('\\') + 1);
            }
            catch
            {
                return target;
            }

         

           
        }


        public static void megaRozdel(List<INode> nodes)
        {
            foreach (INode n in nodes)
            {
                if (n.Name.Contains("."))
                    Soubory.Add(n.Name);
                else
                    Slozky.Add(n.Name);
            }

        }

        public static void difflist(List<string> prvni, List<string> druhy, ref List<string> diffslozky, ref List<string> diffsoubory, bool zkrcil = false)
        {
            if (zkrcil)
                druhy = FileManager.ZkratNazvy(druhy);
            foreach (string s in prvni)
            {
                string text = s.Substring(s.LastIndexOf("\\") + 1);

                if (!druhy.Contains(s.Substring(s.LastIndexOf("\\") + 1)))
                {
                    if (s.Substring(s.LastIndexOf("\\")).Contains("."))
                        diffsoubory.Add(s);
                    else
                        diffslozky.Add(s);

                }

            }

        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        public static void fileToList(string path )
        {
            FileManager.clear();
            List<string> Files = new List<string>();
            //Files = null;
            string line;
            using (StreamReader sr= new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("."))
                        Soubory.Add(line);
                    else
                        Slozky.Add(line);
                }

            }
        }





    }
}
