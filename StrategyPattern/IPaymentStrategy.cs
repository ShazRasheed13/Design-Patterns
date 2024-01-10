using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(double amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of {amount:C}");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }

    public class BankTransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Bank Transfer payment of {amount:C}");
        }
    }


}
