using System;

namespace Employee
{
    public abstract class Employee
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public double Salary { get; private set; }

        public string GetFullName(string firstName, string lastName)
        {
            string str = string.Concat(firstName + lastName);
            return str;
        }
        public bool IsActive(DateTime startDate, DateTime endDate)
        {
            if (endDate > startDate) return true;
            else return false;
        }
        public Employee(string firstName, string lastName, DateTime startDate, DateTime endDate, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
        }

        public abstract string Salutation();
    }
}
