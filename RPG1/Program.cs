using System;
using RPG.src.entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 749, 72);
            Wizard jenica = new Wizard("Jenica", 23, "White Wizard", 601, 482);
            Wizard topapa = new Wizard("Topapa", 23, "Black Wizard", 601, 482);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);

            Console.WriteLine(arus);
            Console.WriteLine(jenica);
            Console.WriteLine(topapa);
            Console.WriteLine(wedge);
            Console.WriteLine(arus.Attack(3));
            Console.WriteLine(jenica.Attack(6));
            Console.WriteLine(topapa.Attack(9));
            Console.WriteLine(wedge.Attack(7));
            

        }
    }
}
