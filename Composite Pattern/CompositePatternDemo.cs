﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    class CompositePatternDemo
    {
        static void Main(string[] args)
        {
            Employee CEO = new Employee("John", "CEO", 30000);

            Employee headSales = new Employee("Robert", "Head Sales", 20000);
            Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

            Employee clerk1 = new Employee("Laura", "Marketing", 10000);
            Employee clerk2 = new Employee("Bob", "Marketing", 10000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarketing);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            headMarketing.Add(clerk1);
            headMarketing.Add(clerk2);

            Console.WriteLine(CEO.TransString());
            foreach (var headEmployee in CEO.GetSubordinates())
            {
                Console.WriteLine(headEmployee.TransString());
                foreach (var item in headEmployee.GetSubordinates())
                {
                    Console.WriteLine(item.TransString());
                }
            }
        }
    }
}
