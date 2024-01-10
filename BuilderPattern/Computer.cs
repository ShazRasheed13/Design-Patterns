using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Product class representing a computer
    public class Computer
    {
        public string Processor { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string GraphicsCard { get; set; }

        public void DisplayConfiguration()
        {
            Console.WriteLine($"Processor: {Processor}, RAM: {RAM}GB, Storage: {Storage}GB, Graphics Card: {GraphicsCard}");
        }
    }
}
