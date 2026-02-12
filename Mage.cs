using System;

namespace AshenDuel
{
    public class Mage : Character
    {
        private Random random = new Random();

        public Mage(string name) : base(name, 80, 25)
        {
        }

        public override int DoAttack()
        {
            int damage = Attack;

            // 25% chance of critical hit
            if (random.Next(0, 4) == 0)
            {
                damage *= 2;
                Console.WriteLine("Critical hit!");
            }

            return damage;
        }
    }
}
