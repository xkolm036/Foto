using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Web.MegaApiClient;

namespace WindowsFormsApp1
{
    public class Mega
    {

        static MegaApiClient client;

        public static void pripoj()
        {
            client = new MegaApiClient();
            client.Login("martykolarik@gmail.com", "polav1994");
        }

        public static void odpoj()
        {
            client.Logout();
        }

        public static List<string> VratStruktura()
        {

            List<string> struktura = new List<string>();
            // struktura = null;
            var nodes = client.GetNodes();


            foreach (INode n in nodes)
            {

                if (n.Name != null)
                {
                    struktura.Add(n.Name);
                }
                //    MessageBox.Show(n.Type.ToString());
            }

            return struktura;

        }

        public static void VytvorSlozky(string cesta, List<string> struktura)
        {
            cesta = cesta.Replace('/', '\\');
            string newcesta = cesta.Remove(cesta.LastIndexOf("\\"));
            string newcestazkr = newcesta.Substring(newcesta.LastIndexOf("\\") + 1);
            // newcestazkr = FileManager.FirstCharToUpper(newcestazkr);
            if (newcesta == newcestazkr)
                newcestazkr = "Fotky";
            if (struktura.Contains(newcestazkr) || newcestazkr == "Fotky" )
            {
                var nodes = client.GetNodes();
                INode newslozka = nodes.Single(n => n.Name == newcestazkr);
                INode myFolder = client.CreateFolder(cesta.Substring(cesta.LastIndexOf("\\") + 1), newslozka);
                struktura.Add(cesta.Substring(cesta.LastIndexOf("\\") + 1));
            }
            else
                VytvorSlozky(newcesta, struktura);

        }

        public static void VytvorSoubory(string cesta, List<string> struktura)
        {
            cesta = cesta.Replace('/', '\\');
            string slozka = cesta.Remove(cesta.LastIndexOf("\\"));
            slozka = slozka.Substring(slozka.LastIndexOf("\\") + 1);
            var nodes = client.GetNodes();
            INode slozka_cpy = nodes.Single(n => n.Name == slozka);
            client.UploadFile(cesta, slozka_cpy);
          
        }
    }
}
