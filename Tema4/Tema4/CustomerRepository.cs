using System;
using System.Collections.Generic;
using System.Text;

namespace Tema4
{
    public class CustomerRepository : Customer
    {
        static void Main(string[] args)
        {

            using (var db = new ApplicationContext())
            {
                db.Customers.Add(new Customer
                {
                    Id = new Guid("BD4F96DA-A3B5-4802-B7B0-E1D8A0B6A9FB"),
                    Name = "Aurelia",
                    Address = "Principal Street",
                    PhoneNumber = +40760760706,
                    Email = "aureliagrosu20@gmail.com"
                });

                db.Customers.Add(new Customer
                {
                    Id = new Guid("26296DEC-387A-4A68-B328-9EA21B471CBF"),
                    Name = "Elena",
                    Address = "Principal Street",
                    PhoneNumber = +40760000000,
                    Email = "elena@gmail.com"
                });

                db.Customers.Add(new Customer
                {
                    Id = new Guid("35E289A9-4264-433E-AB11-5856199FB2B8"),
                    Name = "Mihai",
                    Address = "Principal Street",
                    PhoneNumber = +40768560706,
                    Email = "mihai@yahoo.com"
                });

                Customer updateCustomer = db.Customers.Find("35E289A9-4264-433E-AB11-5856199FB2B8");
                updateCustomer.Name = "Mihail";

                Customer deleteCustomer = db.Customers.Find("26296DEC-387A-4A68-B328-9EA21B471CBF");
                db.Remove(deleteCustomer);

                var saveChanges = db.SaveChanges();
                Console.WriteLine($"{saveChanges} recorded have been added");
            }

        }
        public Guid GetById(Guid id)
        {
            return id;
        }
        public string GetByAll(Guid id, String name, string addess, long numberPhone, string email)
        {
            return id + " " + name + " " + addess + " " + numberPhone + " " + email;
        }
        
    }
}
