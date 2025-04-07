using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EES.Exceptions;

namespace EES.Models
{
    public class Person
    {
        int _id;
        sbyte _age;

        public Person(string fullName, sbyte age)
        {
            Id = _id;
            FullName = fullName;
            Age = age;
            _id++;
        }

        public string FullName { get; set; }
        public int Id { get; set; }
        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (value < 0 && value > 125)
                    throw new InvalidAgeException("Invalid Age");
                _age = value; 
            }
        }
    }
}
