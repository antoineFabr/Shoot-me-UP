using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public int speed;
        private string modele;
        private string _color;
        private Pasenger _pasenger;

        public List<Pasenger> _pasengers;


        public Car(string color)
        {
            _color = color;
            _pasenger = new Pasenger(123,"Antoine");
        }
        public void AddPasengers(Pasenger nom)
        {

            _pasengers.Add(nom);
        }
        public void ShowPasengers()
        {
            foreach (Pasenger p in _pasengers)
            {
                Console.WriteLine(p);
            }
        }
       
    }
}
