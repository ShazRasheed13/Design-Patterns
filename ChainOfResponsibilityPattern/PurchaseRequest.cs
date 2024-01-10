using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class PurchaseRequest
    {
        public  int _requestNumber;
        public  string _purpose;
        public  decimal _amount;

        public PurchaseRequest(int requestNumber, string purpose, decimal amount)
        {
            _requestNumber = requestNumber;
            _purpose = purpose;
            _amount = amount;
        }
        
    }
}
