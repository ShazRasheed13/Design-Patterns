using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibilityPattern;

namespace ChainOfResponsibilityPattern
{
    // Handler interface
    public interface IApprover
    {
        void ProcessRequest(PurchaseRequest request);
    }

    // Concrete Handlers
    public class Manager : IApprover
    {
        private readonly decimal approvalLimit = 1000;
        public void ProcessRequest(PurchaseRequest request)
        {
            if (request._amount <= approvalLimit)
                Console.WriteLine($"Manager approves purchase request #{request._requestNumber}");
            else
                Console.WriteLine($"Manager cannot approve. Passing to Director.");
        }
    }

    public class Director : IApprover
    {
        private readonly decimal approvalLimit = 5000;

        public void ProcessRequest(PurchaseRequest request)
        {
            if (request._amount <= approvalLimit)
                Console.WriteLine($"Director approves purchase request #{request._requestNumber}");
            else
                Console.WriteLine($"Director cannot approve. Passing to VP.");
        }
    }

    public class VicePresident : IApprover
    {
        public void ProcessRequest(PurchaseRequest request)
        {
            Console.WriteLine($"Vice President approves purchase request #{request._requestNumber}");
        }
    }




}
