using System;
using System.Collections.Generic;
using System.Text;

namespace Tema4
{
    public class EmployeeRepository : Employee
    {
        static void Main(string[] args)
        {

            using (var db = new ApplicationContext())
            {
                db.Employees.Add(new Employee
                {
                    Id = new Guid("CB4263DD-2BA2-4768-8F69-4E88B7651428"),
                    FirstName = "Delia",
                    LastName = "Arcana",
                    StartDate = new DateTime(2015, 12, 25),
                    EndDate = new DateTime(2019, 12, 25),
                    Salary = 1112
                });

                db.Employees.Add(new Employee
                {
                    Id = new Guid("EC8C9276-A6BF-4A35-B0B4-8628752FAF63"),
                    FirstName = "Alina",
                    LastName = "Ciobanu",
                    StartDate = new DateTime(2016, 10, 25),
                    EndDate = new DateTime(2020, 12, 25),
                    Salary = 1100
                });

                db.Employees.Add(new Employee
                {
                    Id = new Guid("6EFD6C58-826E-484C-A3DE-BCD2000116A6"),
                    FirstName = "Aurica",
                    LastName = "Apostol",
                    StartDate = new DateTime(2017, 12, 25),
                    EndDate = new DateTime(2021, 10, 25),
                    Salary = 1500
                });

                Employee updateEmployee = db.Employees.Find("6EFD6C58-826E-484C-A3DE-BCD2000116A6");
                updateEmployee.Salary = 2000;

                Employee removeEmployee = db.Employees.Find("EC8C9276-A6BF-4A35-B0B4-8628752FAF63");
                db.Remove(removeEmployee);

                var saveChanges = db.SaveChanges();
                Console.WriteLine($"{saveChanges} recorded have been added");
            }
        }
        public Guid GetById(Guid id)
        {
            return id;
        }
        public string GetByAll(Guid id, String fistName, string lastName, DateTime startdate, DateTime endDate, double salary)
        {
            return id + " " + fistName + " " + lastName + " " + startdate + " " + endDate + " " + salary;
        }



    }
}
