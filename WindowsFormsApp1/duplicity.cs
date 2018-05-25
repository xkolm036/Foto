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
    public partial class duplicity : Form
    {
        public duplicity(Dictionary<string, int> dic)
        {
            InitializeComponent();
          
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 15, FontStyle.Bold);


            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Název";
            dataGridView1.Columns[1].Name = "Počet";
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dataGridView1.Font = new Font("Verdana", 15, FontStyle.Bold);
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 500;
            DataGridViewColumn column1 = dataGridView1.Columns[1];
            column1.Width = 150;
            column1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            foreach (KeyValuePair<string, int> d in dic)
            {
                string[] row = new string[] {  d.Key, d.Value.ToString() };
                dataGridView1.Rows.Add(row);
            }

        }
    }
}
