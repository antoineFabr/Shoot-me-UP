using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    internal class BulletEnemi
    {
        public PictureBox uiElement { get; private set; }   //la picture box est mis dans uiElement

        //constructeur de la classe
        public BulletEnemi(int x, int y, PictureBox pb, Form1 form)
        {
  
            uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            uiElement.SizeMode = pb.SizeMode;
            uiElement.Location = new System.Drawing.Point(x, y);
            uiElement.Size = new System.Drawing.Size(33, 67);
            uiElement.Show();
            form.Controls.Add(uiElement);

        }
        //methode pour avoir la picturebox de la balle
        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        //methode pour afficher au bonne endroit la balle
        public void BulletShoot(int x, int y)
        {
            uiElement.Visible = true;
            uiElement.Location = new Point(x + 42, y);
        }
        //methode pour faire bouger la balle vers le bas
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