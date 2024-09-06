using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP_levrai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int x = pictureBox1.Location.X;
            const int y = 350;

            if (e.KeyCode == Keys.D)
            {
                x += 3;
            }

            if (e.KeyCode == Keys.A)
            {
                x -= 3;
            }
            if (e.KeyCode == Keys.Space)
            {
            }
            pictureBox1.Location = new Point(x, y);

        }
        
    }
}
