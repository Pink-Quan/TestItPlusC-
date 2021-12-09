using System;
using System.Collections.Generic;
using System.Text;

namespace This_is_for_complite
{
    class Animal
    {
        protected int ID { get; set; }
        public string name { get; set; }
        protected bool isCarnivores { get; set; }
        public float velocity { get; private set; }
        public Animal(int id,string Name,bool IsCarnivores,float Velocity)
        {
            ID = id;
            name = Name;
            isCarnivores = IsCarnivores;
            velocity = Velocity;
        }
        public Animal() { }
    }
    
}
