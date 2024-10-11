using SHOOTMEUP123.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace SHOOTMEUP123
{
    public partial class Form1 : Form
    {




        // creation de la liste des balles du joueur
        List<Bullet> bullets = new List<Bullet>();

        //creation de la liste des enemis
        List<Enemi> enemis = new List<Enemi>();

        //creation de la liste des balles des énemis
        List<BulletEnemi> bulletEnemis = new List<BulletEnemi>();

        //creation de la liste des balles de l'ultimate
        List<BulletUltimate> ultimates = new List<BulletUltimate>();

        int cooldown;       // variable pour le cooldown de l'ultimate

        int level = 1;          //variable pour le niveau du joueur

        int XPlevel;        // variable pour l'xp 

        public int rapiditétirdebs = 1000;  //variable pour le tick du  timer de tir des attaques de base

        int levelattaquebase = 1; //variable pour savoir combien de fois l'attaque de base a ete amelioré

        public Form1()
        {
            

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            //creation de 11 enemis et on les ajouts a la liste enemis
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

            RondScore.Region = GetRoundedImagePictureBox(RondScore);
            
        }
        

        public int Getwidthfenetre()
        {
            int largeurFenetre = this.ClientSize.Width;
            return largeurFenetre;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            label1.Text = "" + score;

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

            if (e.KeyCode == Keys.E) 
            {
                nbrbullet++;
                if (cooldown < 1)
                {
                    BulletUltimate newultimate = new BulletUltimate(x, Y, Ultimate, this);
                    newultimate.BulletShoot(x, Y);
                    ultimates.Add(newultimate);
                    cooldown = 10;
                }
            }
           
            // Update ship location
            pictureBox1.Location = new Point(x, Y);
        }
        
        //Cooldown de la competance E
        private void CoolDown_Tick(object sender, EventArgs e)
        {
            if (cooldown > 0)
            {
                pictureBox6.Show();
                cooldown -= 1;

                label2.Text = cooldown.ToString();
                label2.Visible = true;
            }
            if (cooldown == 0)
            {
                label2.Visible = false;
                pictureBox6.Hide();
            }
        }

        //Timer pour la creation des bullets Enemis
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

        //timer pour la creation de balle du joueur
        private void TimerCrationBall_Tick(object sender, EventArgs e)
        {
            int x = pictureBox1.Location.X;

            int Y = pictureBox1.Location.Y;
            Bullet newbullet = new Bullet(x, Y, Bullet123, this);
            newbullet.BulletShoot(x, Y);
            bullets.Add(newbullet);

            bullettimer.Enabled = true;
            TimerCrationBall.Interval = rapiditétirdebs;
        }
        private void bullettimer_Tick(object sender, EventArgs e)
        {
            foreach (BulletUltimate ultime in ultimates.ToList())
            {
                if (!ultime.MoveBullet())
                {
                    ultimates.Remove(ultime);
                }
            }
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
            CheckCollisionsUltime();
        }

        int score = 0;
        int vie = 1;

        private void timerLevelUp_Tick(object sender, EventArgs e)
        {         
            LevelUp();         
        }
        private void CheckCollisionsUltime()
        {
            for (int i = ultimates.Count - 1; i >= 0; i--)
            {
                BulletUltimate bullet = ultimates[i];
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
                        ultimates.RemoveAt(i);
                        enemis.RemoveAt(j);
                        score++;
                        label1.Text = "" + score;
                        XPlevel += 1;
                        break;
                    }
                }
            }
        }
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
                        label1.Text = ""+ score ;
                        XPlevel += 6;
                        break;
                    }
                }
            }
        }
        private void LevelUp()
        {
            //si on passe d'un niveau
            if (XPlevel == 6)
            {
                //on ajoute 1 au niveau
                level += 1;
                // on reset l'xp a zero
                XPlevel = 0;
                //si le niveau d'attaque de base n'est pas a 5 ond affiche le bouton 1
                if (levelattaquebase <= 4)
                {
                    button1.Enabled = true;
                    button1.Visible = true;
                }
                
                button2.Enabled = true;
                button2.Visible =true;
                label3.Text = level.ToString();
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
                        GameOver.label1.Text = "éviter les Balles ;)";
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
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "pourquoi tu cliques ici"; 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }
        private Region GetRoundedImagePictureBox(PictureBox pictureBox)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            Region rg = new Region(graphicsPath);
            return rg;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            levelattaquebase += 1;
            rapiditétirdebs -= 80;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            if (levelattaquebase == 2)
            {
                pictureBox18.Visible = true;
            }
            if (levelattaquebase == 3)
            {
                pictureBox19.Visible = true;    
            }
            if (levelattaquebase == 4)
            {
                pictureBox20.Visible = true;
            }
            if ((levelattaquebase == 5))
            {
                pictureBox21.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rapiditétirdebs -= 80;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
        }
    }


}
