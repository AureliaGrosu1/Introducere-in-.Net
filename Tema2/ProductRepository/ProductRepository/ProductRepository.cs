using System;

namespace ProductRepository
{
    public class ProductRepository
    {
        public int Id { get; private set; }
        public String Name { get; private set; }
        public String Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Price { get; private set; }
        public int VAT { get; private set; }

        public bool IsValid(DateTime startDate, DateTime endDate)
        {
            if (startDate < endDate) return true;
            else return false;
        }

        public int TVAMethod(int price)
        {
            if (price > 0) return price + price * (19 / 100);
            else return 0;
        }

        public ProductRepository(String name, String description, DateTime startDate, DateTime endDate, int id, int price, int vat)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Id = id;
            Price = price;
            VAT = vat;
        }


        var productRepository = new ProductRepository(Name, Description, StartDate, endDate, id, price, vat)
        {
            ListProducts = new List<ListProducts>()
            {
                new ListProducts(1),
                new ListProducts(2),
                new ListProducts(3)
            }
        };
        
        public string GetProductByName(String productName)
        {
            if (productName.Length<0)
            {
                throw new IndexOutOfRangeException("Pay attention!!!!");
            }
            return productName;
        }

        public string FindAllProducts()
        {
            var foundProduct = listProducts.Find(foundProduct => foundProduct.id == "Something");
        }

        public AddProduct (Product product)
        {
                Product product = new Product();
                listProduct.Add(product);
        }

        public string GetProductByPosition(int position)
        {
            if (position.Length<0)
            {
                throw new IndexOutOfRangeException("Pay attention!!!!");
            }
            return position;
        }

        public string RemoveProductByName(string productName)
        {
            
        }
    }
}

