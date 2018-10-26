using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tema4
{
    public class Employee
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? EndDate { get; set; }

        public double Salary { get; set; }

        public string GetFullName(string FirstName, string LastName)
        {
            string str = string.Concat(FirstName + LastName);
            return str;
        }
        public bool IsActive(DateTime StartDate, DateTime EndDate)
        {
            if (EndDate > StartDate) return true;
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

        public Employee()
        {
            //EF
        }
        
    }
}
