﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    /// <summary>
    /// 模型层
    /// </summary>
    class Student
    {
        private string rollNo;
        private string name;

        public string RollNo { get => rollNo; set => rollNo = value; }
        public string Name { get => name; set => name = value; }
    }
}
