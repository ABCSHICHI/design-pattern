﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Delegate_Pattern
{
    public class EJBService : BusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("调用 EJBService 服务 执行任务");
        }
    }
}
