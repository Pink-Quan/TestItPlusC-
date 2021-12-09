using System;
using System.Collections.Generic;
using System.Text;

namespace This_is_for_complite
{
    class Deer:Animal
    {
        public Deer(int id, string Name, bool IsCarnivores, float Velocity) : base(id, Name, IsCarnivores, Velocity) { }
        public float Run()
        {
            Console.WriteLine($"Deer name: {name} - Velocity = {velocity}");
            return velocity;
        }
    }
}
