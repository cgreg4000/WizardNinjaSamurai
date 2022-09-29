using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string n) : base(n, 3, 3, 3, 200) { }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.ChangeHealth(-target.Health);
            }


            return target.Health;
        }

        public void Meditate()
        {
            int fullHealthDifference = 200 - this.Health;
            ChangeHealth(fullHealthDifference);
        }
    }
}