using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            var Products = new List<Product>();
            Products.Add(new Product() { name = "lettuce", price = 10.5, Quantity = 50, type = "Leafy green" });
            Products.Add(new Product() { name = "cabbage", price =  20 , Quantity = 100, type = "Cruciferous " });
            Products.Add(new Product() { name = "pumpkin", price =  30 , Quantity = 30, type = " Marrow" });
            Products.Add(new Product() { name = "cauliflower", price = 10, Quantity = 25, type = "Cruciferous " });
            Products.Add(new Product() { name = "zucchini", price =20.5, Quantity = 50, type = "Marrow" });
            Products.Add(new Product() { name = "yam", price = 30, Quantity = 50, type = "Root" });
            Products.Add(new Product() { name = "spinach", price = 10 , Quantity = 100, type = "Leafy green" });
            Products.Add(new Product() { name = "broccoli", price = 20.2, Quantity = 75, type = " Cruciferous" });
            Products.Add(new Product() { name = "garlic", price = 30, Quantity = 20, type = "Leafy green" });
            Products.Add(new Product() { name = "silverbeet", price =10, Quantity = 50, type = "Marrow" });

            Console.WriteLine("The Total no Product in the list :" + Products.Count);

            Products.Add(new Product() { name = "Potato", price =10, Quantity = 50, type = "Root" });
            foreach (var product in Products)
            {
                Console.WriteLine(product.name + " " + product.price + " " + product.Quantity + " " + product.type + "\n");

            }
            Console.WriteLine("The Total no of Product in the modified List" + Products.Count);
            Console.WriteLine("The products which is leafy");
            foreach (var product in Products)
            {
                if (product.type == "Leafy green")
                {
                    Console.WriteLine(product.name + " " + product.price + " " + product.Quantity + " " + product.type + "\n");
                }

            }




            int i = 0;
            for (i = 0; i < Products.Count; i++)
            {
                if (Products[i].name == "garlic")
                {
                    Products.RemoveAt(i);
                }



            }

            Console.WriteLine("The List of Product after Garlic got sold out");

            foreach (var product in Products)
            {


                Console.WriteLine(product.name + " " + product.price + " " + product.Quantity + " " + product.type + "\n");


            }

            for (i = 0; i < Products.Count; i++)
            {
                if (Products[i].name == "cabbage")
                {
                    Products[i].Quantity -= 50;
                    Console.WriteLine("The Final Quantity of Cabbage in the inventory:" + Products[i].Quantity);
                    break;
                }

            }
            double total_price=0;
            foreach(var product in Products)
            {
                if(product.name=="lettuce")
                {
                    total_price +=( 1 * (product.price / product.Quantity));

                }
                if(product.name=="zucchini")
                {
                    total_price += (2 * (product.price / product.Quantity));
                }
                if (product.name == "broccoli")
                {
                    total_price += (1 * (product.price / product.Quantity));
                }
            }




            Console.WriteLine("The price the user need to pay if he/she purchases 1kg lettuce,2kg zucchini and 1kg broccoli "+Math.Round(total_price) );




        }
    }
}
