using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public class Enemis
    {

        public PictureBox PictureBox2 { get; private set; }
       

        private int _X; 
        private int _Y;
        
        
        public Enemis(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }





        public void Enemis_Move(object sender, KeyEventArgs e)
        {

            int x = PictureBox2.Location.X;

            int y = PictureBox2.Location.Y;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    x += 3;

                }
                y += 3;

            }
            PictureBox2.Location = new Point(x, y);
        }

       

    }
}
