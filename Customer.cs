using System;

namespace myApp
{
    public class Customer
    {
        public string Name;
        public int id;

        public Customer() => this.Name = "sin nombre";
        public Customer(String name)
        {
            this.Name=name;
        }
    }
}
