using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    public class Game_Character_Stat
    {

        //////<summary>
        /// Demonstrates inheritance and the use of a protected variable
        /// through a simple game character and warrior example.
        ///
        ///</summary>
        ///
        bool status = true;
        
        protected float health;
        float damage = 20;
        float heal = 15;
        
        public Game_Character_Stat()
        {
            health = 100;
        }
        public void TakeDamage()
        {
            while (status)
            {
                health = health - damage;
                Console.WriteLine("Damage: " + damage);
                Console.WriteLine("Health: " + health);

                if (health <= 0)
                {
                    Console.WriteLine("Player is dead");
                    status = false;
                }
            }
        }

        public void Heals()
{
    if (status)
    {
        health = health + heal;
        Console.WriteLine("Heal: " + heal);
        Console.WriteLine("Health: " + health);
    }
}

        public void Isalive()
        {

        }
        public void DisplayStatus()
        {

        }


    }
}
