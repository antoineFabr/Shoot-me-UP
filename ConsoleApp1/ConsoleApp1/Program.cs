using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


class player
{
    //position du vaisseau
    private int X;
    private int Y;

    private string sprite;
    
    public player ( string sprite, int positionX, int positionY)
    {
        this.sprite = sprite;
        this.X = positionX;
        this.Y = positionY;
    }



    public void Apparition()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(sprite);
    }

    public void NextMove()
    {
        //mouvement
         if (Console.KeyAvailable)
        {
            if(NativeKeyboard.IsKeyDown(KeyCode.Left))

        }
    }

}