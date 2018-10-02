using System;

namespace MyFortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            FNPlayer player1 = new FNPlayer();
            FNPlayer player2 = new FNPlayer("MachineGun", 100, 100);

            Console.WriteLine("Shield before: " + player2.GetShield());

            player1.Attack(player2);

            Console.WriteLine("Shield after: " + player2.GetShield());

            Console.WriteLine("P1 shield before: " + player1.GetShield());
            player1.SetShield(50);
            Console.WriteLine("P1 shield after: " + player1.GetShield());
        }
    }
}
