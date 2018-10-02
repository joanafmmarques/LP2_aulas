using System;
namespace MyFortnite
{
    public class FNPlayer
    {
 		string equipedWeapon;
        double hitPoints;
        double shield;

        public void Attack(FNPlayer enemy)
        {
            enemy.TakeDamage(10);
        }

        public void TakeDamage(double damage)
        {
            if (shield > 0)
            {
                shield -= damage;
                if (shield < 0)
                {
                    shield = 0;
                }
            } else 
            {
                hitPoints -= damage;
                if (hitPoints <= 0)
                {
                    Die();
                }
            }
        }

    }
}

