using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Customer added :" +customer.Name);
        }
        public void Update(Customer customer) 
        {
            Console.WriteLine("Customer updated :" + customer.Name);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted :" + customer.Name);
        }





    }
}
