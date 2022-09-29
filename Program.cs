using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("John");
            Wizard w1 = new Wizard("Fred");
            Ninja n1 = new Ninja("Bob");
            Samurai s1 = new Samurai("Alice");
            Samurai s2 = new Samurai("Jill");
            
            n1.Steal(s2);
            Console.WriteLine(s2.Health);
            Console.WriteLine(n1.Health);
        }
    }
}
