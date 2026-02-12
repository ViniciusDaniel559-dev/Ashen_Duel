using System;

namespace AshenDuel
{
    public abstract class Character
    {
        public string Name;
        public int Health;
        public int Attack;

        public Character(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
                Health = 0;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public abstract int DoAttack();
    }
}
