using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string n) : base(n, 3, 25, 3, 50) { }

        public override int Attack(Human target)
        {
            int damage = Intelligence * -5;
            target.ChangeHealth(damage);
            int heal = Intelligence * 5;
            ChangeHealth(heal);
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return damage;
        }

        public void Heal(Human target)
        {
            int healAmount = Intelligence * 10;
            target.ChangeHealth(healAmount);
        }
    }
}