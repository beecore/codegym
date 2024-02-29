using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAnimal
{
    class Dog : Animal
    {
        private string Name { get; set; }
        public Dog(string weight, string height, string name): base(weight, height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }
}
