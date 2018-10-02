using System;

namespace MyFortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer player1 = new FNPlayer();
            FNPlayer player2 = new FNPlayer("MachineGun", 100, 100);

            Console.WriteLine("Shield before: " + player2.shield);
            Console.WriteLine("Hit points before: " + player2.hitPoints);

            player1.Attack(player2);

            Console.WriteLine("Shield after: " + player2.shield);
            Console.WriteLine("Hit points after: " + player2.hitPoints);
        }
    }
}
