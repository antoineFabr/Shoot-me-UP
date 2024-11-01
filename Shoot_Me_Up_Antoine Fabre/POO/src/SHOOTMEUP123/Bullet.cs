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
    public class Bullet
    {

        public PictureBox uiElement { get; private set; }
        public int _Y;
        public int _X;
        public Bullet(int Y, int x, PictureBox pb, Form1 form)
        {
            this._Y = Y;
            this._X = x;
            this.uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            uiElement.SizeMode = pb.SizeMode;
            uiElement.Location = new System.Drawing.Point(_X, _Y);
            uiElement.Size = new System.Drawing.Size(33, 67);
            uiElement.Show();
            form.Controls.Add(uiElement);

        }

        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        public void BulletShoot(int x, int y)
        {

            uiElement.Visible = true;
            uiElement.Location = new Point(x + 42, y);

        }
        public bool MoveBullet()
        {

            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
            _Y = y;
            _Y -= 40;
            y = _Y;
            uiElement.Location = new Point(x, y);

            //indique si  encore dans le niveau
            return y > 0 - uiElement.Height;
        }
       
    }
}
