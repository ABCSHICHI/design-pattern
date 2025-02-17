﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlerClass
{
    //ConcreteHandler 具体处理者
    class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, request.ProductName);
            else if (NextApprover != null)
                NextApprover.ProcessRequest(request);
        }
    }
}
