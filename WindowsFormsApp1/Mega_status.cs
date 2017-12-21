using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Mega_status : Form
    {
        List<string> diffSlozky;
        List<string> diffSoubory;
        List<string> cillist;
        int pocslozek;
        int pocsouboru;

        public Mega_status(List<string> diffSlozky, List<string> diffSoubory, List<string> cillist)
        {
            InitializeComponent();
            this.diffSlozky = diffSlozky;
            this.diffSoubory = diffSoubory;
            this.cillist = cillist;
            pocslozek = diffSlozky.Count;
            pocsouboru = diffSoubory.Count;
            int sirkacloupce = 1120;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 15, FontStyle.Bold);


            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Složky [" + pocslozek.ToString() + "]";
            dataGridView1.Columns[1].Name = "Up status";
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.Font = new Font("Verdana", 15, FontStyle.Bold);
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = sirkacloupce;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 150;
            column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dataGridView2.ColumnCount = 2;
            dataGridView2.ColumnHeadersVisible = true;
            dataGridView2.Columns[0].Name = "Soubory [" + pocsouboru.ToString() + "]"; ;
            dataGridView2.Columns[1].Name = "Up status";
            dataGridView2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView2.Font = new Font("Verdana", 15, FontStyle.Bold);
            DataGridViewColumn column3 = dataGridView2.Columns[0];
            column3.Width = sirkacloupce;
            DataGridViewColumn column4 = dataGridView2.Columns[1];
            column4.Width = 150;
            column4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


     
            foreach (string s in diffSlozky)
            {
                string[] row = new string[] { s, "x" };
                dataGridView1.Rows.Add(row);
            }



            foreach (string s in diffSoubory)
            {
                string[] row = new string[] { s, "x" };
                dataGridView2.Rows.Add(row);
            }
    
         


        }

        private void buttonZalohovat_Click(object sender, EventArgs e)
        {
            buttonZalohovat.Enabled = false;
            int i = 0;
            foreach (string s in diffSlozky)
            {

                Mega.VytvorSlozky(s, cillist);
                dataGridView1.Rows[i].Cells[1].Value = "OK";
                i++;
                pocslozek--;
                dataGridView1.Columns[0].Name = "Složky [" + pocslozek.ToString() + "]";
            }
            i = 0;
            foreach (string s in diffSoubory)
            {
                Mega.VytvorSoubory(s, cillist);
                dataGridView2.Rows[i].Cells[1].Value = "OK";
                i++;
                pocsouboru--;
                dataGridView2.Columns[0].Name = "Soubory [" + pocsouboru.ToString() + "]"; ;
                if (i == 12)
                {
                    for (int j = 1; j <= 11; j++)
                        dataGridView2.Rows.RemoveAt(0);
                    i = 1;
                    dataGridView2.Refresh();
                    this.Refresh();
                }

            }
            Mega.odpoj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileManager.Soubory = cillist;
            SaveList sl = new SaveList("mega");
            sl.Show();
        }
    }
}
