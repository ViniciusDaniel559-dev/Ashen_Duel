using System;

namespace AshenDuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ashen Duel ===");
            Console.WriteLine("Two warriors enter. One leaves.\n");

            Character player1 = new Warrior("Ragnar");
            Character player2 = new Mage("Elyra");

            // TODO: Improve combat system to support more than 2 characters

            Console.WriteLine("Battle Start!\n");

            while (player1.IsAlive() && player2.IsAlive())
            {
                int damage1 = player1.DoAttack();
                player2.TakeDamage(damage1);

                Console.WriteLine(player1.Name + " dealt " + damage1 + " damage.");
                Console.WriteLine(player2.Name + " HP: " + player2.Health);
                Console.WriteLine();

                if (!player2.IsAlive())
                    break;

                int damage2 = player2.DoAttack();
                player1.TakeDamage(damage2);

                Console.WriteLine(player2.Name + " dealt " + damage2 + " damage.");
                Console.WriteLine(player1.Name + " HP: " + player1.Health);
                Console.WriteLine();
            }

            Console.WriteLine("Battle finished!\n");

            if (player1.IsAlive())
                Console.WriteLine(player1.Name + " wins!");
            else
                Console.WriteLine(player2.Name + " wins!");

            Console.ReadLine();
        }
    }
}
