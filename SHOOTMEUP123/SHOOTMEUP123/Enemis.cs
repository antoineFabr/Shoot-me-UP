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

        public PictureBox uiElement { get; private set; }
       

        public Enemis(int x, int y,PictureBox pb)
        {
            this.uiElement = pb;
            this.uiElement.Left = x;
            this.uiElement.Top = y;
        }

        public void Move()
        {
            uiElement.Top++;
        }

       

    }
}
