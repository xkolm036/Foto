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
            

            InitializeComponent();
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 15, FontStyle.Bold);


            foreach (string s in soubory)
            {
                    
                MyTable Table = new MyTable();
                Table.AutoSize = true;
                Table.Font = new Font(Table.Font.FontFamily, 16);
                Table.ColumnCount = 1;
                Table.RowCount = 1;
                Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                Table.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
                Table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                Table.AutoSize = false;
                Table.Width= 450;
                Table.Height = 240;
                Table.cesta = s;
                Table.Cursor = Cursors.Hand;
                Table.MouseClick += new MouseEventHandler(Table_click);
                // Table.BackColor = Color.Black;


                Image i = Image.FromFile(s);
                i = new Bitmap(i, new Size(450, 240));

                Table.BackgroundImage = i;



                Label l = new Label();
                l.Text = FileManager.ZkratNazvy(s);
                l.Anchor = AnchorStyles.Top;
                l.TextAlign = ContentAlignment.TopLeft;
                l.BackColor = Color.Transparent;
                l.ForeColor = SystemColors.Control;
                l.AutoSize = true;

                Table.Controls.Add(l,0,0);

  
                flowLayoutPanel1.Controls.Add(Table);
            }




        }

        private void Table_click(object sender, MouseEventArgs e)
        {
            MyTable T = new MyTable();
            T = (MyTable)sender;



            FullScreenPicture Foto = new FullScreenPicture(T.cesta);
            Foto.ShowDialog();
        }

        private void FormZobrazit_Resize(object sender, EventArgs e)
        {
           
                flowLayoutPanel1.Width = this.Width - 39;
                flowLayoutPanel1.Height = this.Height - 150;
                flowLayoutPanel1.AutoScroll = true;
          
      
        }
    }
}
