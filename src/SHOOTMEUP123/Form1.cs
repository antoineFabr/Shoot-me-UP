﻿using SHOOTMEUP123.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Threading;

namespace SHOOTMEUP123
{
    public partial class Form1 : Form
    {





        List<Bullet> bullets = new List<Bullet>();
        List<Enemi> enemis = new List<Enemi>();
        List<BulletEnemi> bulletEnemis = new List<BulletEnemi>();
        
        
        public Form1()
        {
            

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            Enemi newenemi = new Enemi(1, 9, pictureBox2, this, 10, 1);
            enemis.Add(newenemi);
            Enemi newenemi2 = new Enemi(50, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi2);
            Enemi newenemi3 = new Enemi(100, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi3);
            Enemi newenemi4 = new Enemi(150, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi4);
            Enemi newenemi5 = new Enemi(200, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi5);
            Enemi newenemi6 = new Enemi(250, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi6);
            Enemi newenemi7 = new Enemi(300, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi7);
            Enemi newenemi8 = new Enemi(350, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi8);
            Enemi newenemi9 = new Enemi(400, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi9);
            Enemi newenemi10 = new Enemi(450, 9, pictureBox2, this, 3, 1);
            enemis.Add(newenemi10);


            timer1.Enabled = true;
            bulletenemitimer.Enabled = true;

        }


        public int Getwidthfenetre()
        {
            int largeurFenetre = this.ClientSize.Width;
            return largeurFenetre;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            label1.Text = "Score : " + score;

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
                x += 20;
            }
            if (e.KeyCode == Keys.A)
            {
                x -= 20;
            }
            if (e.KeyCode == Keys.W)
            {
                Y -= 20;
            }

            if (e.KeyCode == Keys.S)
            {
                Y += 20;
            }

            if (e.KeyCode == Keys.Space) 
            {
                nbrbullet++;

                Bullet newbullet = new Bullet(x, Y, Bullet123, this);
                newbullet.BulletShoot(x, Y);
                bullets.Add(newbullet);

                bullettimer.Enabled = true;

                Thread.Sleep(100);
            }
           
            // Update ship location
            pictureBox1.Location = new Point(x, Y);

        }
        
        private void timerCreationBullet_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;
            BulletEnemi newbullets = new BulletEnemi(x, 1, Bullet123, this);

            newbullets.BulletShoot(x, 1);
            bulletEnemis.Add(newbullets);
        }
        private void bulletenemitimer_Tick(object sender, EventArgs e)
        {
           

            foreach (BulletEnemi bulletEnemi in bulletEnemis.ToList())
            {
                
                if (!bulletEnemi.MoveBulletEnemi())
                {
                    bulletEnemis.Remove(bulletEnemi);
                }
                
            }
        }
        private void bullettimer_Tick(object sender, EventArgs e)
        {
            
            foreach (Bullet bullet in bullets.ToList())
            {

                
                //si le missile sort su niveau, on le supprime
                if (!bullet.MoveBullet())
                {
                    bullets.Remove(bullet);
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
            CheckCollisionsBullet();
            CheckCollisionsEnemi();
            CheckColisionsbulletEnemi();
        }
        int score = 0;
        int vie = 1;
        private void CheckCollisionsBullet()
        {

            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                Bullet bullet = bullets[i];
                Rectangle bulletRect = bullet.GetPictureBox().Bounds;

                for (int j = enemis.Count - 1; j >= 0; j--)
                {
                    Enemi enemi = enemis[j];
                    Rectangle enemiRect = enemi.GetPictureBox().Bounds;

                    //check si balle touche enemi
                    if (bulletRect.IntersectsWith(enemiRect))
                    {
                        //enleve les 2
                        this.Controls.Remove(bullet.GetPictureBox());
                        this.Controls.Remove(enemi.GetPictureBox());
                        bullets.RemoveAt(i);
                        enemis.RemoveAt(j);
                        score++;
                        label1.Text = "Score : "+ score ;
                        break;
                    }
                }
            }
        }
        private void CheckColisionsbulletEnemi()
        {
            for (int i = bulletEnemis.Count - 1; i >= 0; i--)
            {
                BulletEnemi bulletEnemi = bulletEnemis[i];
                Rectangle bulletRect = bulletEnemi.GetPictureBox().Bounds;

                Rectangle player = pictureBox1.Bounds;

                //check si balle touche enemi
                if (bulletRect.IntersectsWith(player))
                {
                    //enleve la balle
                    this.Controls.Remove(bulletEnemi.GetPictureBox());
                        
                    bulletEnemis.RemoveAt(i);

                    vie--;
                    if (vie == 0)
                    {
                        timer1.Enabled = false;
                        this.Hide();
                        MenuGameOver GameOver = new MenuGameOver();
                        GameOver.Show();
                        GameOver.label1.Text = "éviter les Balles ;)aaaw";
                    }
                        
                    break;
                }
                
            }
        }
        private void CheckCollisionsEnemi()
        {

            for (int i = enemis.Count - 1; i >= 0; i--)
            {
                
                Enemi enemi = enemis[i];
                Rectangle enemiRect = enemi.GetPictureBox().Bounds;
            
                    Rectangle player = pictureBox1.Bounds;

                    //check si player touche un enemi
                    if (enemiRect.IntersectsWith(player))
                    {
                        timer1.Enabled = false;
                        this.Hide();

                        MenuGameOver GameOver = new MenuGameOver();
                        GameOver.Show();
                    }
                
                
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "pourquoi tu cliques ici";
        }

        
    }


}
