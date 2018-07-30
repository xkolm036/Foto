using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CG.Web.MegaApiClient;
using System.Net;
using System.IO;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private string zdroj = null;
        private string cil = null;
        private string kamKopirovat = null;
        private List<string> cilList = null;

        private List<string> SlozkyZdroj;
        private List<string> SlozkyCil;
        private List<string> SouboryZdroj;
        private List<string> SouboryCil;
        private List<string> ListFiles = new List<string>();
        private List<string> ListDirs = new List<string>();


        public Form1()
        {
            InitializeComponent();
            XML.Nacti(ref zdroj, ref cil, ref kamKopirovat);
            textBox_Cil.Text = cil;
            textBox_Zdroj.Text = zdroj;
            textBox_Kopirovat.Text = kamKopirovat;
        }

        private void OveritCesty(bool nocil = false)
        {
            button_Duplicity.Enabled = true;
            button_kopirovat.Enabled = true;
            button_mega.Enabled = true;
            button_Zrcadlit.Enabled = true;
            button_zobrazNove.Enabled = true;
            label_Cil.ForeColor = Color.Black;
            label_zdroj.ForeColor = Color.Black;
            label_Kopirovat.ForeColor = Color.Black;

            if (nocil == false)
            {
                if (!Directory.Exists(textBox_Cil.Text))
                {
                    label_Cil.ForeColor = Color.Red;
                    button_kopirovat.Enabled = false;
                    button_Zrcadlit.Enabled = false;
                    button_zobrazNove.Enabled = false;
                }
            }

            if (!Directory.Exists(textBox_Zdroj.Text))
            {
                label_zdroj.ForeColor = Color.Red;
                button_Duplicity.Enabled = false;
                button_kopirovat.Enabled = false;
                button_mega.Enabled = false;
                button_Zrcadlit.Enabled = false;
                button_zobrazNove.Enabled = false;
            }

            if (!Directory.Exists(textBox_Kopirovat.Text))
            {
                label_Kopirovat.ForeColor = Color.Red;
                button_kopirovat.Enabled = false;
            }


        }
        //dialogové okno pro vyber souboru
        private string filebrowsware()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")

                return fbd.SelectedPath;
            else
            {
                return null;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OveritCesty(true);
        }

        private void button_mega_Click(object sender, EventArgs e)
        {
            button_mega.Text = "Loading";
            button_mega.Enabled = false;

            List<string> diffSlozky = new List<string>();
            List<string> diffSoubory = new List<string>();
            List<string> zdrojlist;
            List<string> cillist = new List<string>();

            Task t = Task.Run(() =>
            {
                FileManager.DirSearch(zdroj);
                zdrojlist = new List<string>(FileManager.Slozky);

                foreach (string s in FileManager.Soubory)
                {
                    zdrojlist.Add(s);
                }

                FileManager.clear();


                Mega.pripoj();
                if (checkBox_list.Checked == false)
                    cillist = Mega.VratStruktura();

                //Pridat z nacteneho listu
                foreach (string s in ListFiles)
                {
                    if (!cillist.Contains(s))
                        cillist.Add(s);
                }

                foreach (string s in ListDirs)
                {
                    if (!cillist.Contains(s))
                        cillist.Add(s);
                }


                FileManager.difflist(zdrojlist, cillist, ref diffSlozky, ref diffSoubory);

            }
            );
            var awaiter = t.GetAwaiter();
            awaiter.OnCompleted(() =>
                {
                    Form mega = new Mega_status(diffSlozky, diffSoubory, cillist);
                    mega.Show();
                }
            );




        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //XML.Uloz(zdroj, cil, kamKopirovat);
            checkBox_list.Checked = false;
            XML.Uloz(textBox_Zdroj.Text, textBox_Cil.Text, textBox_Kopirovat.Text);
        }

        private void button_Zrcadlit_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //  startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;                                         //skryti okna !!!!!
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/k robocopy " + zdroj + " " + cil + " /e" + "&& pause>null";
            process.StartInfo = startInfo;
            process.Start();
            // Console.Clear();



        }
        private void button_Duplicity_Click(object sender, EventArgs e)
        {
            FileManager.DirSearch(zdroj);
            SouboryZdroj = FileManager.Soubory;
            SouboryZdroj = FileManager.ZkratNazvy(SouboryZdroj);
            // FileManager.clear();

            var query = SouboryZdroj.GroupBy(x => x)
                 .Where(g => g.Count() > 1)
                 .ToDictionary(x => x.Key, y => y.Count());

            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> d in query)
            {
                dic.Add(d.Key, d.Value);
            }
            FileManager.clear();

            duplicity f = new duplicity(dic);
            f.Show();

        }

        private void button_kopirovat_Click(object sender, EventArgs e)
        {
            List<string> zdrojList = new List<string>();
            List<string> CilFiles = new List<string>();
            List<string> diffSoubory = new List<string>();
            List<string> diffSlozky = new List<string>();


            foreach (string s in Directory.GetFiles(zdroj))
            {
                zdrojList.Add(s);
            }

            FileManager.clear();

            if (checkBox_list.Checked != true) //pouze list
            {
                if (cilList == null)    //soubory a slozky z cile
                {
                    FileManager.DirSearch(cil);
                }
                else
                {
                    foreach (string s in cilList)
                    {
                        FileManager.DirSearch(s);
                    }
                }

                foreach (string s in FileManager.Soubory)
                {
                    CilFiles.Add(s);
                }
            }
            //Pridat z nacteneho listu
            foreach (string s in ListFiles)
            {
                if (!CilFiles.Contains(s))
                    CilFiles.Add(s);
            }

            FileManager.difflist(zdrojList, CilFiles, ref diffSlozky, ref diffSoubory, true);
            diffSlozky.Clear();

            foreach (string s in diffSoubory)
            {
                if (s.Substring(s.LastIndexOf("\\") + 1) != "Thumbs.db")
                {
                    if (checkBox_move.Checked == true && !File.Exists(kamKopirovat + "/" + s.Substring(s.LastIndexOf("\\") + 1)))
                        File.Move(s, kamKopirovat + "/" + s.Substring(s.LastIndexOf("\\") + 1));
                    else
                        File.Copy(s, kamKopirovat + "/" + s.Substring(s.LastIndexOf("\\") + 1), true);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<string> pomSlozky = new List<string>();
            List<string> pomSoubory = new List<string>();
            SlozkyCil = new List<string>();
            SlozkyZdroj = new List<string>();
            SouboryCil = new List<string>();
            SouboryZdroj = new List<string>();


            //zdroj
            FileManager.DirSearch(zdroj);
            SlozkyZdroj = FileManager.Slozky;
            SlozkyZdroj = FileManager.ZkratNazvy(SlozkyZdroj);
            SouboryZdroj = FileManager.Soubory;
            SouboryZdroj = FileManager.ZkratNazvy(SouboryZdroj);
            FileManager.clear();
            //-------------------------------------------------

            //cil
            if (checkBox_list.Checked == false)
            {
                FileManager.DirSearch(cil);
                SlozkyCil = FileManager.Slozky;
                SlozkyCil = FileManager.ZkratNazvy(SlozkyCil);
                SouboryCil = FileManager.Soubory;
                SouboryCil = FileManager.ZkratNazvy(SouboryCil);
                FileManager.clear();
            }
            //-------------------------------------------------
            //Pridat z nacteneho listu
            foreach (string s in ListFiles)
            {
                if (!SouboryCil.Contains(s))
                    SouboryCil.Add(s);
            }

            foreach (string s in ListDirs)
            {
                if (!SlozkyCil.Contains(s))
                    SlozkyCil.Add(s);
            }
            //------------------------------

            pomSlozky = SlozkyZdroj.Except(SlozkyCil).ToList();
            pomSoubory = SouboryZdroj.Except(SouboryCil).ToList();

            Form zobraz = new FormZobrazit(pomSoubory, pomSlozky);
            zobraz.ShowDialog();
        }

        private void textBox_Zdroj_TextChanged(object sender, EventArgs e)
        {
            zdroj = textBox_Zdroj.Text;
            if (cilList == null)
                OveritCesty();
            else
                OveritCesty(true);
        }

        private void textBox_Cil_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Cil.Text != "List")
            {
                cil = textBox_Cil.Text;
                if (cil.Contains(";"))
                {
                    OveritCesty(true);
                    cilList = new List<string>();
                    foreach (string s in cil.Split(';'))
                    {
                        if (Directory.Exists(s))
                            cilList.Add(s.Trim());
                        else
                            OveritCesty();
                    }
                }
                else
                    OveritCesty();
            }
        }

        private void textBox_Kopirovat_TextChanged(object sender, EventArgs e)
        {
            kamKopirovat = textBox_Kopirovat.Text;
            if (cilList == null)
                OveritCesty();
            else
                OveritCesty(true);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mega.nz");
        }

        private void button_prehod_Click(object sender, EventArgs e)
        {
            string pom;
            pom = zdroj;
            zdroj = cil;
            cil = pom;
            textBox_Zdroj.Text = zdroj;
            textBox_Cil.Text = cil;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string cesta = filebrowsware();
            if (cesta != null)
                textBox_Zdroj.Text = cesta;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cesta = filebrowsware();
            if (cesta != null)
                textBox_Cil.Text = cesta;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cesta = filebrowsware();
            if (cesta != null)
                textBox_Kopirovat.Text = cesta;
        }


        //Vzhled polozek menu
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;

        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.ControlLight;
            button.ForeColor = Color.Black;
        }


        private void button_MouseLeavew(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = SystemColors.Control;
            button.ForeColor = Color.Black;
        }
        //Vzhled polozek menu />
        private void button_nacistlist_Click(object sender, EventArgs e)
        {

            string listPath = "";

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), ".\\Lists");
            fdlg.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);

            fdlg.Filter = "Txt files (*.txt)|*.txt";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                listPath = fdlg.FileName;
                if (listPath != "")
                {
                    button_odebratList.Visible = true;
                    checkBox_list.Visible = true;
                    ListFiles.Clear();
                    // ListFiles = null;
                    FileManager.fileToList(listPath);
                    foreach (string s in FileManager.Slozky)
                    {
                        ListDirs.Add(s);
                    }

                    foreach (string s in FileManager.Soubory)
                    {
                        ListFiles.Add(s);
                    }

                }
            }



        }

        private void button_ulozitList_Click(object sender, EventArgs e)
        {
            SaveList save = new SaveList(textBox_Cil.Text);
            save.ShowDialog();
        }

        private void button_odebratList_Click(object sender, EventArgs e)
        {
            ListFiles.Clear();
            ListDirs.Clear();
            button_odebratList.Visible = false;
            checkBox_list.Visible = false;
            checkBox_list.Checked = false;
        }

        private void checkBox_list_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_list.Checked == true)
            {
                textBox_Cil.Text = "List";
                textBox_Cil.ReadOnly = true;
                button_prehod.Enabled = false;
                button_zobrazNove.Enabled = true;
                button_Zrcadlit.Enabled = false;
                button_kopirovat.Enabled = true;
            }
            else
            {
                textBox_Cil.Text = cil;
                textBox_Cil.ReadOnly = false;
                button_prehod.Enabled = true;
            }
        }
    }
}
