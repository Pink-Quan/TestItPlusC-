using System;
using System.Collections.Generic;
using System.Text;

namespace This_is_for_complite
{
    class Lion:Animal
    {

        public string eat (string victim)
        {
            return $"The Lion {name} tries to eat {victim}";
        }
        public float accelerator()
        {
            return velocity * 1.1f;
        }    
        public Lion(int id, string Name, bool IsCarnivores, float Velocity):base(id, Name, IsCarnivores, Velocity) { }
        public float Predatory()
        {
            Console.WriteLine($"Name Lion: {name} - Velocity = {velocity}");
            return velocity;
        }

    }
}
