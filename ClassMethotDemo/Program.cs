using System;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Hilal";
            customer1.CustomerNo = 123;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Harun";
            customer2.CustomerNo = 121;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Buse";
            customer3.CustomerNo = 135;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer3);
            customerManager.Update(customer1);
            customerManager.Delete(customer2);


        }
    }
}
