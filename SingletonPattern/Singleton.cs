using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {
        //The Singleton class has a private static instance and a private constructor to prevent external instantiation.
        // The single instance of the class.
        private static Singleton instance;

        // Private constructor to prevent instantiation from outside the class.
        private Singleton() { }

        // Public method to get the instance of the class. If it doesn't exist, create it.
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Your other class methods and properties go here.
        public void DisplayMessage()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }
}
