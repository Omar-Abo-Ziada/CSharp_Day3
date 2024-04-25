using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal abstract class Creature
    {
        public int Age;
        protected int Height;
        private int Weight;

        public Creature() : this(7, 10)
        {
        }

        public Creature(int weight) : this(weight, 10)
        {
        }

        public Creature(int weight, int height)
        {
            Weight = weight;
            Age = 1;
            Height = height;

            //Console.WriteLine("Creature is HERE");
        }

        public abstract void Move();

        //public virtual void Move()
        //{
        //    Console.WriteLine("Creature is moving");
        //}

        public virtual void Eat()
        {
            Console.WriteLine("Creature is eating");
        }

        public void Die()
        {
            Console.WriteLine("Creature dies");
        }

        public virtual void Test()
        {

        }
    }
}
