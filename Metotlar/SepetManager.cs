using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations. Was added to your cart : " + product.Name);                     
        }


        public void Add2(string productName, string explanation, double price, int stockQuantity)
        {
            Console.WriteLine("Congratulations. Was added to your cart : " + productName);

        }
    }
}
