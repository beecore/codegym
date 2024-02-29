using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("40kg", "1.5", "mrcorgi");
            dog.PrintInfo();
            Console.ReadLine();
        }
    }
}
