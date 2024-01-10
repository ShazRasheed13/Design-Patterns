using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_StudentExample
{
    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string RollNo { get; set; }

        public void Display()
        {
            Console.WriteLine($"Name:{Name}, Gender:{Gender}, Roll No.:{RollNo}");
        }
    }
}
