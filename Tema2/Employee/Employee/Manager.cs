using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Manager : Employee
    {
        public Manager(string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) :
        base(firstName, lastName, startDate, endDate, salary)
        {

        }
   
        public override string Salutation()
        {
            return "Hello manager!";
        }
    }
}
