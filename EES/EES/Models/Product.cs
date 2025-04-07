using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.Exceptions;


namespace EES.Models
{
    public class Product
    {
        int _id;
        int _price;

        public Product(string name, int type, int price)
        {
            Id = _id;
            Name = name;
            Type = type;
            Price = price;
            _id++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; } //Baker, Drink, Meat, Diary

        public int Price
        {
            get { return _price; }
            set 
            {
                if (value < 0)
                    throw new PriceMustBeGratherThanZeroException();

                _price = value;
            }
        }

    }
}
