using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Models
{
    public class Store
    {
        public Store()
        {
            Product[] products = new Product[0];
        }

        public Product[] Products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[^1] = product;
        }

        public void RemoveProductById(int id)
        {
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    //remoove product from Products
                }
            }
        }

        public Product GetProduct(int? id)
        {
            foreach(Product product in Products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }
    }
}
