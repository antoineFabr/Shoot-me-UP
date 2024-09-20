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
        private int _X;
        private int _Y;
        private int _vitesse;
        private int _nbrHP;
        public PictureBox uiElement { get; private set; }
       

        public Enemi(int x, int y,PictureBox pb,Form1 form,int vitesse,int nbrHP)
        {
            this.uiElement = new PictureBox();
            uiElement.BackgroundImage = pb.BackgroundImage;
            
            uiElement.Location = new System.Drawing.Point(x,y);
            
            _vitesse = vitesse; 
            _nbrHP = nbrHP;
            uiElement.Size = new System.Drawing.Size(100, 50);
            uiElement.Show();
            form.Controls.Add(uiElement);
            
            //this.uiElement = pb;
            //this.uiElement.Left = x;
            //this.uiElement.Top = y;
        }

        public bool Move()
        {
            int x = uiElement.Location.X;
            int y = uiElement.Location.Y;
            y += _vitesse;
            
 
           
            uiElement.Location = new Point(x, y);

            //indique si  encore dans le niveau
            return y < 556;
            
        }

       

    }
}
