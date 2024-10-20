using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public partial class menugame : Form
    {
        public menugame()
        {
            InitializeComponent();
        }

        private void menugame_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form1 = new Form1();

            
            form1.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
