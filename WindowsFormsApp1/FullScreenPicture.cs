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
    public partial class FullScreenPicture : Form
    {
     public string cesta { get; set; }
        public FullScreenPicture(string cesta)
        {
            InitializeComponent();
            this.cesta = cesta;
            Image i = Image.FromFile(cesta);
            i = new Bitmap(i, new Size(this.Width, this.Height));

            pictureBox1.Image = i;
            

        }



        private void FullScreenPicture_ResizeEnd(object sender, EventArgs e)
        {
            Image i = Image.FromFile(cesta);
            i = new Bitmap(i, new Size(this.Width, this.Height));

            pictureBox1.Height = this.Height;
            pictureBox1.Width = this.Width;

            pictureBox1.Image = i;
        }
    }
}
