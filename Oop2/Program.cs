﻿using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            //engin demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.IdentificationNumber = "12345678910";

            //kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            


        }
    }
}
