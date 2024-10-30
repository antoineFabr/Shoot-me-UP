using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

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

        int levelattaqueultime = 1; //variable pour savoir combien de fois l'ultime a ete ameliore

        int nbrVague = 0;   //variable pour compter le nombre de vague 

        int score = 0;  //variable pour compter le score 

        int vie = 1;    //variable qui compte la vie du joueur

        public Form1()
        {

            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            timer1.Enabled = true;  //lancement du timer 1

            bulletenemitimer.Enabled = true;    //lancement du timer pour bouger les balles des Enemis

            RondScore.Region = GetRoundedImagePictureBox(RondScore);    //rendre rond le fond deriere le score
            
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = "" + score;   //changement du text du label 1 pour afficher le score

            int nbrbullet = 0;  //variable pour compter le nombre d'ultime tiré

            int x = pictureBox1.Location.X; //variable pour savoir ou se trouve le vaisseau sur l'axe X

            int Y = pictureBox1.Location.Y; //variable pour savoir ou se trouve le vaisseau sur l'axe Y

            //si on appuie sur d le vaisseau se deplace a droite
            if (e.KeyCode == Keys.D)
            {
                x += 20;
            }
            //si on appuie sur a le vaisseau se deplace a gauche
            if (e.KeyCode == Keys.A)
            {
                x -= 20;
            }
            //si on appuie sur w le vaisseau se deplace en haut
            if (e.KeyCode == Keys.W)
            {
                Y -= 20;
            }
            //si on appuie sur s le vaisseau se deplace en bas
            if (e.KeyCode == Keys.S)
            {
                Y += 20;
            }
            //si on appuie sur e on crée un ultime 
            if (e.KeyCode == Keys.E)
            {
                //ajout de 1 au nombre d'ultime tirer
                nbrbullet++;
                //si le cooldown est a zero on peut tirer
                if (cooldown < 1)
                {
                    //on créer l'ultime
                    BulletUltimate newultimate = new BulletUltimate(x, Y, Ultimate, this);
                    //on appele la methode pour rendre la balle visible 
                    newultimate.BulletShoot(x, Y);
                    //on ajoute cet ultime dans la liste ultimates
                    ultimates.Add(newultimate);
                    //et on remet le cooldown a 10 secondes
                    cooldown = 10;
                }
            }
                // Update ship location
                pictureBox1.Location = new Point(x, Y);
        }

        //Cooldown de l'ultime
        private void CoolDown_Tick(object sender, EventArgs e)
        {
            //si le cooldown est au dessus de zero 
            if (cooldown > 0)
            {
                //on affiche l'image opaque de la competence
                pictureBox6.Show();
                //on enleve 1 au cooldown 
                cooldown -= 1;
                //on affiche les secondes restante du cooldown 
                label2.Text = cooldown.ToString();
                //on affiche le label 2 pour afficher le cooldown
                label2.Visible = true;
            }
            //si le cooldown est a 0
            if (cooldown == 0)
            {
                //on desaffiche le label 2 qui affiche le cooldown
                label2.Visible = false;
                //et on cache la picture box qui affiche l'image opaque de la competence 
                pictureBox6.Hide();
            }
        }

        //Timer pour la creation des bullets Enemis
        private void timerCreationBullet_Tick(object sender, EventArgs e)
        {
            //variable pour savoir ou est le vaisseau
            int x = pictureBox1.Location.X;
            //on créer une balle enemi qui sera juste au dessus du vaisseau du joueur
            BulletEnemi newbullets = new BulletEnemi(x, 1, Bullet123, this);
            //on affiche la balle 
            newbullets.BulletShoot(x, 1);
            //et on ajoute la balle a la liste bulletEnemis
            bulletEnemis.Add(newbullets); 
        } 
        //timer pour bouger les balles enemis
        private void bulletenemitimer_Tick(object sender, EventArgs e)
        {
            //boucle foreach pour faire avancer toute les balles qui sont dans la liste bulletEnemis
            foreach (BulletEnemi bulletEnemi in bulletEnemis.ToList())
            {         
                //si la balle n'avance pas on la remove 
                if (!bulletEnemi.MoveBulletEnemi())
                {
                    bulletEnemis.Remove(bulletEnemi);
                }         
            }
        }
        //methode pour voir si le joueur a gagné 
        private void CheckSiGameWin()
        {
            //si le nombre d'enemi est a zero et que on est la vague numero cinq
            if (enemis.Count == 0 && nbrVague == 5)
            {
                //on ferme la fenetre du jeu (Form1)
                this.Close();
                //on créer la fenetre de fin
                MenuGameOver win = new MenuGameOver();
                //on l'affiche 
                win.Show();
                //on affiche qu'on a gagné
                win.label1.Text = "Bravo vous avez gagné";
                win.label4.Text = "Game Win";
            }
        }
        //timer pour la creation de balle du joueur
        private void TimerCrationBall_Tick(object sender, EventArgs e)
        {
            //variable pour savoir la position du joueur sur l'axe des x
            int x = pictureBox1.Location.X;
            //variable pour savoir la position du joueur sur l'axe des y
            int Y = pictureBox1.Location.Y;
            //on crée la balle 
            Bullet newbullet = new Bullet(x, Y, Bullet123, this);
            //on l'affiche la ou se trouve le vaisseau 
            newbullet.BulletShoot(x, Y);
            //et on ajoute la balle a la liste bullets
            bullets.Add(newbullet);
            //ensuite on active le timer qui fait bouger la balle
            bullettimer.Enabled = true;
            //on change la rapidité du timer en fonction de cette variable 
            TimerCrationBall.Interval = rapiditétirdebs;
        }
        //timer pour faire bouger les balles
        private void bullettimer_Tick(object sender, EventArgs e)
        {
            //foreach pour faire avancer toute les ultimes qui sont dans la liste ulitmates
            foreach (BulletUltimate ultime in ultimates.ToList())
            {
                //si la balle ne bouge plus on la remove
                if (!ultime.MoveBullet())
                {
                    ultimates.Remove(ultime);
                }
            }
            //foreach pour faire avancer toute les balles qui sont dans la liste bullets
            foreach (Bullet bullet in bullets.ToList())
            {            
                //si le missile sort su niveau, on le supprime
                if (!bullet.MoveBullet())
                {
                    bullets.Remove(bullet);
                }              
            }
        }      
        //timer pour faire avancer les enemis et aussi appele des methodes
        private void timer1_Tick(object sender, EventArgs e)
        {
            //foreach pour faire avancer tous les enemis qui sont dans la liste enemis
            foreach (Enemi newenemi in enemis.ToList())
            {
                if (!newenemi.Move())
                {
                    enemis.Remove(newenemi);
                }
            }
            //appele de la methode qui check si une balle touche un enemi
            CheckCollisionsBullet();
            //appele de la methode qui check si un enemi rentre en colision avec le vaisseau du joueur
            CheckCollisionsEnemi();
            //appele de la methode qui check si les balles des enemis touchent le vaisseau du joueur
            CheckColisionsbulletEnemi();
            //appele de la methode qui check si la balle de l'ultime touche des enemis
            CheckCollisionsUltime();
            //appele de la methode qui check si la partie est gagnée 
            CheckSiGameWin();
            //appele de la methode qui créer des vagues d'énemis
            CreationVagueEnemi();
        }
        //timer pour appeler la methode LevelUp
        private void timerLevelUp_Tick(object sender, EventArgs e)
        {         
            LevelUp();         
        }
        //methode pour check si l'ultime touche des enemis
        private void CheckCollisionsUltime()
        {
            //boucle for qui se repete le nombre d'ultimate qu'il y a 
            for (int i = ultimates.Count - 1; i >= 0; i--)
            {
                //on appele chaque ultime dans la liste ultimates
                BulletUltimate bullet = ultimates[i];
                //et avec cet ultime on va créer un rectangle en fonction de la picture box de cet ultime
                Rectangle bulletRect = bullet.GetPictureBox().Bounds;
                //boucle for pour faire la meme chose mais avec les enemis
                for (int j = enemis.Count - 1; j >= 0; j--)
                {
                    Enemi enemi = enemis[j];
                    Rectangle enemiRect = enemi.GetPictureBox().Bounds;

                    //check si l'ultime touche un enemi
                    if (bulletRect.IntersectsWith(enemiRect))
                    {
                        //donc si la balle touche un enemi l'enemi il est enlevé mais la balle continue son chemin
                        this.Controls.Remove(enemi.GetPictureBox());
                        //donc on enleve cette enemi de la liste
                        enemis.RemoveAt(j);
                        //on ajoute de plus 1 au score
                        score += 1;
                        //on affiche le score qui a changé 
                        label1.Text = "" + score;
                        //et on ajoute 1 d'experience 
                        XPlevel += 1;
                        break;
                    }
                }
            }
        }
        //methode qui va check si une balle touche un enemi
        private void CheckCollisionsBullet()
        {
            //boucle for qui se repete en fonction du nombre de balle qu'il y a dans le jeu 
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                //on appele chaque balle dans la liste bullets
                Bullet bullet = bullets[i];
                //et avec cet balle on va créer un rectangle en fonction de la picture box de cet balle 
                Rectangle bulletRect = bullet.GetPictureBox().Bounds;
                //check si l'ultime touche un enemi
                for (int j = enemis.Count - 1; j >= 0; j--)
                {
                    Enemi enemi = enemis[j];
                    Rectangle enemiRect = enemi.GetPictureBox().Bounds;

                    //check si balle touche enemi
                    if (bulletRect.IntersectsWith(enemiRect))
                    {
                        //on enleve la balle et l'enemi touché 
                        this.Controls.Remove(bullet.GetPictureBox());
                        this.Controls.Remove(enemi.GetPictureBox());
                        //on les enleve aussi de leur list aussi
                        bullets.RemoveAt(i);
                        enemis.RemoveAt(j);
                        //on ajoute 1 au score aussi
                        score += 1;
                        //on change le score affiché aussi
                        label1.Text = ""+ score ;
                        //et on ajoute 1 d'experience
                        XPlevel += 1;
                        break;
                    }
                }
            }
        }
        //methode pour monter de niveau
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
                //sinon on ne l'affiche pas
                else
                {
                    button1.Enabled = false;
                    button1.Visible = false;
                }
                
                if (levelattaqueultime <=4)
                {
                    button2.Enabled = true;
                    button2.Visible = true;
                }
                else
                {
                    button2.Enabled = false;
                    button2.Visible = false;
                }
                //on modifie le niveau affiché
                label3.Text = level.ToString();
            }
        }
        //methode pour savoir si une balle enemi rentre en colision avec le vaisseau du joueur
        private void CheckColisionsbulletEnemi()
        {
            //boucle for qui se repete le nombre de fois qu'il y a de balle enemis dans le jeu
            for (int i = bulletEnemis.Count - 1; i >= 0; i--)
            {
                //on appele chaque qu'il y a dans la liste bulletEnemis
                BulletEnemi bulletEnemi = bulletEnemis[i];
                //et avec cette balle on va créer un rectangle en fonction de la picture box de cette balle enemi
                Rectangle bulletRect = bulletEnemi.GetPictureBox().Bounds;
                //on va faire la meme chose avec la picture box du vaisseau du joueur
                Rectangle player = pictureBox1.Bounds;

                //check si balle touche enemi
                if (bulletRect.IntersectsWith(player))
                {
                    //enleve la balle et le vaisseau
                    this.Controls.Remove(bulletEnemi.GetPictureBox());
                    this.Controls.Remove(pictureBox1);
                    //enleve la balle de la liste
                    bulletEnemis.RemoveAt(i);
                    //on enleve une vie au joueur
                    vie -= 1;
                    //si il n'y a plus de vie 
                    if (vie == 0)
                    {
                        timer1.Enabled = false;
                        this.Hide();
                        MenuGameOver GameOver = new MenuGameOver();
                        GameOver.Show();
                        GameOver.label1.Text = "éviter les Balles ;)";
                        GameOver.label4.Text = "Game Over";
                        
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

        //methode si on clique sur le boutton 2 on ameliore l'ultime
        private void button2_Click(object sender, EventArgs e)
        {
            //on ajoute 1 a cette variable pour savoir combien de fois on a amelioré
            levelattaqueultime += 1;

            //a refaire les ameliorations 
            rapiditétirdebs -= 80;
            button1.Enabled = false;
            button1.Visible = false;
            button2.Enabled = false;
            button2.Visible = false;
            if ( levelattaqueultime == 2)
            {
                pictureBox23.Visible = true;
            }
            if (levelattaqueultime == 3)
            {
                pictureBox24.Visible = true;
            }
            if (levelattaqueultime == 4)
            {
                pictureBox25.Visible = true;
            }
            if (levelattaqueultime == 5)
            {
                pictureBox26.Visible = true;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
        //methode pour créer des enemis
        private void VagueEnemi(int vitesse)
        {
            //création de 10 Enemis et on les mets dans la liste enemis
            Enemi newenemi = new Enemi(1, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi);
            Enemi newenemi2 = new Enemi(190, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi2);
            Enemi newenemi3 = new Enemi(380, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi3);
            Enemi newenemi4 = new Enemi(570, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi4);
            Enemi newenemi5 = new Enemi(760, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi5);
            Enemi newenemi6 = new Enemi(950, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi6);
            Enemi newenemi7 = new Enemi(1140, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi7);
            Enemi newenemi8 = new Enemi(1330, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi8);
            Enemi newenemi9 = new Enemi(1520, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi9);
            Enemi newenemi10 = new Enemi(1710, 9, pictureBox2, this, vitesse, 1);
            enemis.Add(newenemi10);
        }

        //methode pour créer des vagues d'enemis
        private void CreationVagueEnemi()
        {
            //si en fonction de la vague les enemis créer auront pas la meme vitesse
            if (nbrVague == 0)
            {
                VagueEnemi(6);  //le 6 est la vitesse
                nbrVague += 1;
            }
            if (enemis.Count == 0 && nbrVague ==1)
            {
                VagueEnemi(10);
                nbrVague += 1;
            }
            if (enemis.Count == 0 && nbrVague == 2)
            {
                VagueEnemi(14);
                nbrVague += 1;
            }
            if (enemis.Count == 0 && nbrVague == 3)
            {
                VagueEnemi(18);
                nbrVague += 1;
            }
            if (enemis.Count == 0 && nbrVague == 4)
            {
                VagueEnemi(22);
                nbrVague += 1;
            }
        }

        
    }


}
