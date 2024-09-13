using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public partial class Form1 : Form
    {
        


        Enemis Enemis1;
        Bullet bullet1;

        public Form1()
        {
            
            
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            Enemis1= new Enemis(330, 29,pictureBox2);

            timer1.Enabled = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            int x = pictureBox1.Location.X;

            int Y = pictureBox1.Location.Y;
            

            // Move the ship
            if (e.KeyCode == Keys.A && e.KeyCode == Keys.S)
            {
                Y -= 3;
                x += 3;
            }
            if (e.KeyCode == Keys.D)
            {
                x += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                x -= 10;
            }
            if (e.KeyCode == Keys.W)
            {
                Y -= 10;
            }

            if (e.KeyCode == Keys.S)
            {
                Y += 10;
            }
            if (e.KeyCode == Keys.Space)
            {
                bullet1= new Bullet(x, Y, Bullet123);
                
            }
            bullet1.BulletShoot();
            
            // Update ship location
            pictureBox1.Location = new Point(x, Y);
        }
        class Bullet
        {

            public PictureBox uiElement { get; private set; }
            public int _Y;
            public int _X;
            public Bullet(int Y, int x,PictureBox pb)
            {
                this._Y = Y;
                this._X = x; 
                this.uiElement = pb;
            }


            public void BulletShoot()
            {
                uiElement.Visible = true;
                
            }
            public void TirBullet()
            {
                int x = uiElement.Location.X;
                int y = uiElement.Location.Y;
                _Y = y;
                _Y--;
                y = _Y;
                uiElement.Location = new Point(x, y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemis1.Move();
            if (bullet1 != null)
            {
                bullet1.TirBullet();
            }
        }
    }


}
