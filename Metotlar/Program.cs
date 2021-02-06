using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 15;
            string explanation = "Amasya's Apple";

           
            string[] fruits = new string[] {"Apple","Watermelon" };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya's Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır's Watermelon";

            Product[] products = new Product[] {product1,product2 };

            //type-safe -- tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("....................");

            }


            Console.WriteLine("----------Metotlar-------");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Pear", "Green Pear", 12, 10);
            sepetManager.Add2("Apple", "Green apple", 12, 9);
            sepetManager.Add2("Watermelon", "Diyarbakır's watermelon", 12, 8);




        }
    }
}


 // dont repeat yourself - DRY - Clean Code - Best Practice