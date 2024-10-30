using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    internal class BulletUltimate
    {
        public PictureBox uiElement { get; private set; }   //la picture box est mis dans uiElement
        private int _Y;//variable pour choisir la position sur l'axe des Y de la balle
        private int _X;//variable pour choisir la position sur l'axe des X de la balle

        //constructeur de la classe
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

        //methode pour avoir la picturebox
        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        //methode pour affiher au bon endroit la balle
        public void BulletShoot(int x, int y)
        {

            uiElement.Visible = true;
            uiElement.Location = new Point(x , y - 100);

        }
        //methode pour faire bouger la balle
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
