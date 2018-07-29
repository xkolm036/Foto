using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG.Web.MegaApiClient;
using System.Threading;
using System.Windows.Forms;
using Nito.AsyncEx.Synchronous;

namespace WindowsFormsApp1
{
    public class Mega
    {
        private static CancellationTokenSource uploadCancellationTokenSource = new CancellationTokenSource();
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
            //newcestazkr = FileManager.FirstCharToUpper(newcestazkr);
            if (newcestazkr == "fotky")
                newcestazkr = "Fotky";
            if (struktura.Contains(newcestazkr) || newcestazkr == "Fotky")
            {
                var nodes = client.GetNodes();
                INode newslozka = nodes.Single(n => n.Name == newcestazkr);
                INode myFolder = client.CreateFolder(cesta.Substring(cesta.LastIndexOf("\\") + 1), newslozka);
                struktura.Add(cesta.Substring(cesta.LastIndexOf("\\") + 1));
            }
            else
                VytvorSlozky(newcesta, struktura);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cesta"></param>
        /// <param name="struktura"></param>
        public async static Task VytvorSoubory(string cesta, Mega_status MS, int i)
        {
            cesta = cesta.Replace('/', '\\');
            string slozka = cesta.Remove(cesta.LastIndexOf("\\"));
            slozka = slozka.Substring(slozka.LastIndexOf("\\") + 1);
            if (slozka == "fotky")
                slozka = "Fotky";
            var nodes = client.GetNodes();
         
        
            INode slozka_cpy = nodes.FirstOrDefault(n => n.Name == slozka);
            //  client.UploadFile(cesta, slozka_cpy);


            Progress<double> progress = new Progress<double>();
            progress.ProgressChanged += (s, progressValue) =>
            {
                //Update the UI (or whatever) with the progressValue 
                MS.dataGridView2.Rows[i].Cells[1].Value = (int)progressValue;
            };
          

            INode myFile =await client.UploadFileAsync(cesta, slozka_cpy, progress, uploadCancellationTokenSource.Token);
        


        }


        private void CancelUploadButtonClick(object sender, EventArgs e)
        {
            if (!uploadCancellationTokenSource.IsCancellationRequested)
                uploadCancellationTokenSource.Cancel();
        }



    } 
    }


