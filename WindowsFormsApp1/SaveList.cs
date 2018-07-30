using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class SaveList : Form
    {
        string nazev;
        string struktura_cesta;
        public SaveList(string cesta)
        {
            InitializeComponent();
            textBox_cesta.Text = cesta;
            struktura_cesta = cesta;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Nazev_TextChanged(object sender, EventArgs e)
        {
            nazev = textBox_Nazev.Text ;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (struktura_cesta != "mega") { 
            FileManager.clear();
            FileManager.DirSearch(struktura_cesta);
            }
     
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), ".\\Lists");
            if (!Directory.Exists(CombinedPath))
            {
                Directory.CreateDirectory(CombinedPath);
            }
            CombinedPath += "\\" + nazev+".txt";
            

            using (StreamWriter sw = new StreamWriter(CombinedPath))
            {
                foreach (string s in FileManager.ZkratNazvy( FileManager.Soubory))
                {
                    sw.WriteLine(s);
                }
                sw.Flush();

                foreach (string s in FileManager.ZkratNazvy(FileManager.Slozky))
                {
                    sw.WriteLine(s);
                }
                sw.Flush();

            }
  
            this.Close();
        }
    }
}
