using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Architect : Employee
    {
        public Architect(string firstName, string lastName, DateTime startDate, DateTime endDate, double salary) :
        base(firstName, lastName, startDate, endDate, salary)
        {

        }

        public override string Salutation()
        {
            return "Hello architect";
        }
    }
}

