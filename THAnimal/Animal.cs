using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAnimal
{
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
    }
}
