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
    public class BulletUltimate
    {
        public PictureBox uiElement { get; private set; }   //la picture box est mis dans uiElement
        private int _Y;//variable pour choisir la position sur l'axe des Y de la balle
        private int _X;//variable pour choisir la position sur l'axe des X de la balle

        /// <summary>
        /// constructeur de la classe
        /// </summary>
        /// <param name="Y"></param>
        /// <param name="x"></param>
        /// <param name="pb"></param>
        /// <param name="form"></param>
        public BulletUltimate(int Y, int x, PictureBox pb, Form1 form)
        {
            this._Y = Y;
            this._X = x;
            this.uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            uiElement.SizeMode = pb.SizeMode;
            uiElement.Location = new System.Drawing.Point(_X, _Y);
            uiElement.Size = new System.Drawing.Size(84, 282);
            uiElement.Show();
            form.Controls.Add(uiElement);

        }

        /// <summary>
        /// methode pour avoir la picturebox
        /// </summary>
        /// <returns></returns>
        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        /// <summary>
        /// methode pour affiher au bon endroit la balle
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void BulletShoot(int x, int y)
        {

            uiElement.Visible = true;
            uiElement.Location = new Point(x , y - 100);

        }
        /// <summary>
        /// methode pour faire bouger la balle
        /// </summary>
        /// <returns></returns>
        public bool MoveBullet()
        {

            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
            _Y = y;
            _Y -= 45;
            y = _Y;
            uiElement.Location = new Point(x, y);

            //indique si  encore dans le niveau
            return y > 0 - uiElement.Height;
        }
    }
}
