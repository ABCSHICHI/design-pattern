﻿using Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.EntityClass
{
    /// <summary>
    /// 正方形类 实体类
    /// </summary>
    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
