using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.passwordtb.AutoSize = false;
            this.passwordtb.Size = new Size(this.passwordtb.Size.Width, 22);

        }



        private void closebutten_MouseEnter(object sender, EventArgs e)
        {
            closebutten.ForeColor = Color.Red;
        }

        private void closebutten_MouseLeave(object sender, EventArgs e)
        {
            closebutten.ForeColor = Color.Black;
        }

        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void closebutten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
