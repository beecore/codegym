﻿using System;

namespace FanProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.SetMaxSPeed();
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;
            fan1.ToString();

            Fan fan2 = new Fan();
            fan2.SetMediumSPeed();
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            fan2.ToString();

            Console.ReadLine();
        }
    }
}