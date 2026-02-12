using System;

namespace AshenDuel
{
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, 120, 15)
        {
        }

        public override int DoAttack()
        {
            return Attack;
        }
    }
}
