using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class PurchaseHandler(IApprover handler)
    {
        public void ProcessPurchase(PurchaseRequest request)
        {
            handler.ProcessRequest(request);
        }
    }
}
