using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootMeUp
{
    internal class Program
    {

        
        public class Player
        {
            private int _x;
            private int _y;
            private int _vitesse;
            public Player(int x, int y, int vitesse)
            {
                _x = x;
                _y = y;
                _vitesse = vitesse;
            }


        }
        static void Main(string[] args)
        {
            int intVitesse = 3;
            int intX = 35;
            int intY = 35;

            Player player1 = new Player(35, 35 , 3);


        }
    }
}
