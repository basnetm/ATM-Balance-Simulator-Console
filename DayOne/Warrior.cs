namespace DayOne
{
    public class Warrior : Game_Character_Stat
    {
        public void ShowHealth()
        {
            Console.WriteLine("Health: " + health);
        }
        public void Damage()
        {
            TakeDamage();
        }
        public void Heal()
        {
            Heals();
            Console.WriteLine("print your name for 5 times");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("MANOJ");
            }
            Console.ReadLine();
        }
    }
}
