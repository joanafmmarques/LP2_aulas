using System;
namespace MyFortnite
{
    public class FNPlayer
    {
 		private string equipedWeapon;
        private  double hitPoints;
        private double shield;

        public static double MaxHitPoints { get; set; } = 100;

        public static void Apocalipse() 
        {
            MaxHitPoints /= 2;
        }

        public FNPlayer()
        {
            equipedWeapon = "picareta";
            hitPoints = 100;
            shield = 0;

        }

        public FNPlayer(string equipedWeapon, double hitPoints, double shield)
        {
            this.equipedWeapon = equipedWeapon;
            this.hitPoints = hitPoints;
            this.shield = shield;
        }

        public double GetShield()
        {
            return shield;
        }

        public void SetShield(double shield)
        {
            if (shield >= 0)
            {
                this.shield = shield;
            }
        }

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
                  //  Die();
                }
            }
        }

    }
}

