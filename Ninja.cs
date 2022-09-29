using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n, 3, 3, 175, 100) { }

        public override int Attack(Human target)
        {
            int baseDamage = Dexterity * -5;
            Random rand = new Random();
            int critical = rand.Next(1, 6);
            if (critical == 1)
            {
                int totalDamage = baseDamage - 10;
                Console.WriteLine($"Critical Hit!");
                target.ChangeHealth(totalDamage);
                Console.WriteLine($"{Name} attacked {target.Name} for {totalDamage} damage!");
            }
            else
            {
                target.ChangeHealth(baseDamage);
                Console.WriteLine($"{Name} attacked {target.Name} for {baseDamage} damage!");
            }
            return baseDamage;
        }

        public void Steal(Human target)
        {
            target.ChangeHealth(-5);
            ChangeHealth(5);
        }
    }
}