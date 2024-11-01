/******************************************************************************
** PROGRAMME  ShootMeUp123.cs                                                **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Antoine Fabre                                                 **
** Date      : 01.11.2024                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  :                                                               **
**   Version :                                                               **
**   Date    :                                                               **
**   Raisons :                                                               **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               **
** ce programme est un jeu de type space invaders en 2d où il faut tirer sur **     
** les déchêts avec les missiles du vaisseau. pour savoir ce qu'apporte cette**
** page au jeu voir les commentaire ci-dessous.                              **
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public class BulletEnemi
    {
        public PictureBox uiElement { get; private set; }   //la picture box est mis dans uiElement

        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="pb"></param>
        /// <param name="form"></param>
        public BulletEnemi(int x, int y, PictureBox pb, Form1 form)
        {
  
            uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            uiElement.SizeMode = pb.SizeMode;
            uiElement.Location = new System.Drawing.Point(x, y);
            uiElement.Size = new System.Drawing.Size(164, 68);
            uiElement.Show();
            form.Controls.Add(uiElement);

        }
        /// <summary>
        /// methode pour avoir la picturebox de la balle
        /// </summary>
        /// <returns></returns>
        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        /// <summary>
        /// methode pour afficher au bonne endroit la balle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void BulletShoot(int x, int y)
        {
            uiElement.Visible = true;
            uiElement.Location = new Point(x + 42, y);
        }
        /// <summary>
        /// methode pour faire bouger la balle vers le bas
        /// </summary>
        /// <returns></returns>
        public bool MoveBulletEnemi()
        {
            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
            y += 4;
            uiElement.Location = new Point(x, y);
            //indique si  encore dans le niveau
            return y < 1080;
        }
    }
}