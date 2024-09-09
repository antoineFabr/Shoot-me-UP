using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    internal class player
    {

        private int _X;
        private int _Y;


        public player(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }



        public void moveLeft()
        {
            _X++;
            

        }
    }
}
