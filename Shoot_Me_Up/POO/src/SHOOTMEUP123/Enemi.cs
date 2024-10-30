using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using SHOOTMEUP123.Properties;

namespace SHOOTMEUP123
{
    public class Enemi
    {
        private int _X; //variable pour choisir la position sur l'axe des X de l'ennemi
        private int _Y; //variable pour choisir la position sur l'axe des Y de l'ennemi
        private int _vitesse;   //variable pour choisir la vitesse de l'ennemi
        private int _nbrHP; //variable pour choisir le nombre de vie 
        bool movingRight = true;    //variable pour savoir si les ennemis doivent aller a gauche ou a droite 
        int step = 0;   //variable pour savoir si l'ennemi va descendre 
        public PictureBox uiElement { get; private set; }   //la picture box est mis dans uiElement
        
        //constructeur de la classe
        public Enemi(int x, int y,PictureBox pb,Form1 form,int vitesse,int nbrHP)
        {
            this.uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            uiElement.Location = new System.Drawing.Point(x,y);
            _vitesse = vitesse; 
            _nbrHP = nbrHP;
            uiElement.Size = new System.Drawing.Size(100,101);
            uiElement.Show();
            form.Controls.Add(uiElement);
        }

        //methode move pour faire bouger les Enemis
        public bool Move()
        {
            //recuperation de la position de l'ennemi
            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
            // Étape de déplacement horizontal (vers la droite)
            if (movingRight == true && step == 0)
                        uiElement.Left += _vitesse; // Déplacer vers la droite

                    else if (movingRight == false && step == 0)
                        uiElement.Left -= _vitesse; // Déplacer vers la gauche

                    else if (step == 1)
                    {
                        uiElement.Top += 25; // aller vers le bas
                        if (movingRight == true)
                        {
                            uiElement.Left += 5; // on est obligé de déplacer a gauche car sinon l'enemi reste toujours au dessus de 1920
                        }

                        if (movingRight == false)
                        {
                            uiElement.Left -= 5;
                        }
                        step = 0;
                    }
           

            // Vérifier si l'entité a atteint les bords du formulaire
            if (x >= 1920 - uiElement.Width)
            {
                movingRight = false;//on met la variable movingright a faux pour qu'il aille ensuite a gauche 
                step = 1;

            }
            else if (x <= 0)
            {
                movingRight = true;
                step = 1;
            }

            //indique si  encore dans le niveau
            return y < 556;
            
        }
        //methode pour enlever de la vie a l'ennemi
        public void sethp(int HPenmoin)
        {
            _nbrHP -= HPenmoin;
        }
        //methode pour avoir la picture box de l'ennemi
        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
       

    }
}
