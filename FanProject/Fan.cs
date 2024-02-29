using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanProject
{
    public class Fan
    {
        private static int SLOW = 1;
        private static int MEDIUM = 2;
        private static int FAST = 3;
        private int speed;
        public int Speed { get; set; }
        private bool on;
        public bool On { get; set; }
        private double radius;
        public int Radius { get; set; }
        private string color;
        public string Color { get; set; }

        public Fan()
        {
            speed = SLOW;
            on = false;
            radius = 5;
            color = "blue";

        }
        public void SetMaxSPeed()
        {
            speed = FAST;

        }
        public void SetMediumSPeed()
        {
            speed = MEDIUM;

        }
        public void ToString()
        {
            Console.WriteLine("Speed:" + speed + " On:" + on + " Radius:" + Radius + " Color: " + Color);
        }
    }
}
