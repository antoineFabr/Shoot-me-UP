using SHOOTMEUP123.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public partial class Form1 : Form
    {
        


        
        
        List<Bullet> bullets = new List<Bullet>();
        List<Enemi> enemis = new List<Enemi>();
        
        
        public Form1()
        {

            
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            Enemi newenemi= new Enemi(0, 50,pictureBox2,this,1);
            enemis.Add(newenemi);
            Enemi newenemi2 = new Enemi(100, 19, pictureBox2,this,2);
            enemis.Add(newenemi2);
            Enemi newenemi3 = new Enemi(200, 39, pictureBox2, this,3);
            enemis.Add(newenemi3);
            Enemi newenemi4 = new Enemi(300, 9, pictureBox2, this,4);
            enemis.Add(newenemi4);
            Enemi newenemi5 = new Enemi(400, 49, pictureBox2,this,5);


            enemis.Add(newenemi5);
            timer1.Enabled = true;
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
            int nbrbullet = 0;
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
                nbrbullet++;

                Bullet newbullet = new Bullet(x, Y, Bullet123,this); 
                newbullet.BulletShoot(x, Y);
                bullets.Add(newbullet);
                
                bullettimer.Enabled = true;
                

            }


            // Update ship location
            pictureBox1.Location = new Point(x, Y);
         
        }
        class Bullet
        {

            public PictureBox uiElement { get; private set; }
            public int _Y;
            public int _X;
            public Bullet(int Y, int x,PictureBox pb,Form1 form)
            {
                this._Y = Y;
                this._X = x; 
                this.uiElement = new PictureBox();
                uiElement.BackgroundImage= pb.BackgroundImage;
                uiElement.SizeMode=pb.SizeMode;
                uiElement.Location = new System.Drawing.Point(_X, _Y);
                uiElement.Size = new System.Drawing.Size(91, 251);
                uiElement.Show();
                form.Controls.Add(uiElement);
                
            }


            public void BulletShoot(int x, int y)
            {

                uiElement.Visible = true;
                uiElement.Location = new Point(x, y);  
                
            }
            public bool MoveBullet()
            {

                int x = uiElement.Location.X;
                int y = uiElement.Location.Y;
                _Y = y;
                _Y -= 6;
                y = _Y;
                uiElement.Location = new Point(x, y);

                //indique si  encore dans le niveau
                return y > 0-uiElement.Height;
            }
        }
        private void bullettimer_Tick(object sender, EventArgs e)
        {
            
            foreach(Bullet bullet in bullets.ToList())
            {
                //si le missile sort su niveau, on le supprime
                if(!bullet.MoveBullet())
                {
                    bullets.Remove(bullet);
                }


                foreach (Bullet bullet1 in bullets.ToList())
                {
                    if (bullets.bounds.intersectWith(enemis))
                    {

                    }
                }
            }
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Enemi newenemi in enemis.ToList())
            {
                if (!newenemi.Move())
                {
                    enemis.Remove(newenemi);
                }
                
            }
            
            
        }
    }


}
