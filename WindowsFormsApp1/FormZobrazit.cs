using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormZobrazit : Form
    {
        public FormZobrazit(List<string> soubory ,List<string> slozky)
        {

            int sirkacloupce = 1120;

            InitializeComponent();
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 15, FontStyle.Bold);


            dataGridView1.ColumnCount = 1;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Složky ["+slozky.Count.ToString()+"]";
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.Font = new Font("Verdana", 15, FontStyle.Bold);
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = sirkacloupce;



            dataGridView2.ColumnCount = 1;
            dataGridView2.ColumnHeadersVisible = true;
            dataGridView2.Columns[0].Name = "Soubory [" + soubory.Count.ToString() + "]"; ;
            dataGridView2.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView2.Font = new Font("Verdana", 15, FontStyle.Bold);
            DataGridViewColumn column1 = dataGridView2.Columns[0];
            column1.Width = sirkacloupce;

            foreach (string s in slozky)
            {
                int i=0;
                dataGridView1.Rows.Add(s);
          
                i++;
            }



            foreach (string s in soubory)
            {
                int i = 0;
                dataGridView2.Rows.Add(s);
         
                i++;
            }




        }

    
    }
}
