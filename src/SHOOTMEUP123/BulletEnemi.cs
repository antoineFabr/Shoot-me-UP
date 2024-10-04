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
        public PictureBox uiElement { get; private set; }

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

        public PictureBox GetPictureBox()
        {
            return uiElement;
        }
        public void BulletShoot(int x, int y)
        {

            uiElement.Visible = true;
            uiElement.Location = new Point(x + 42, y);

        }
        public bool MoveBulletEnemi()
        {

            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
 
            y += 4;

            uiElement.Location = new Point(x, y);

            //indique si  encore dans le niveau
            return y < 537 - uiElement.Height;
        }
    }
}
