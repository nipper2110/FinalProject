using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Shop
    {
        public static void Main(string[] args)
        {

            bannerTitle();

            int customerChoice = 0;
            while (customerChoice != 4)
            {
                Console.WriteLine("Here is Our Menu For Today");
                Console.WriteLine("1. Pizza");
                Console.WriteLine("2. Burger");
                Console.WriteLine("3. Drink");
                Console.WriteLine("4. Exit");

                Console.Write("Select... ");
                customerChoice = Convert.ToInt32(Console.ReadLine());

                switch (customerChoice)
                {
                    case 1:
                        pizzaMenu();
                        break;

                     case 2:
                        burgerMenu();
                        break;
                     case 3:
                        drinkMenu();
                        break; 
                    case 4:
                        bye();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease select menu between 1 and 4!!!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }

        public static void bannerTitle()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n");
            Console.WriteLine("███████╗██╗     ██╗ ██████╗███████╗     ██████╗ ███████╗\r\n██╔════╝██║     ██║██╔════╝██╔════╝    ██╔═══██╗██╔════╝\r\n███████╗██║     ██║██║     █████╗      ██║   ██║█████╗  \r\n╚════██║██║     ██║██║     ██╔══╝      ██║   ██║██╔══╝  \r\n███████║███████╗██║╚██████╗███████╗    ╚██████╔╝██║     \r\n╚══════╝╚══════╝╚═╝ ╚═════╝╚══════╝     ╚═════╝ ╚═╝     \r\n                                                        \r\n██╗  ██╗███████╗ █████╗ ██╗   ██╗███████╗███╗   ██╗     \r\n██║  ██║██╔════╝██╔══██╗██║   ██║██╔════╝████╗  ██║     \r\n███████║█████╗  ███████║██║   ██║█████╗  ██╔██╗ ██║     \r\n██╔══██║██╔══╝  ██╔══██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║     \r\n██║  ██║███████╗██║  ██║ ╚████╔╝ ███████╗██║ ╚████║     \r\n╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝     ");
            Console.WriteLine("===========================");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void pizzaMenu()
        {
            Console.Clear();

            bannerTitle();
            Console.WriteLine("We have :");
            Console.WriteLine("1. Pepperonni Pizza (100 Baht)");
            Console.WriteLine("2. Hawaii Pizza (110 Baht)");

            int pizzaChoice;
            Console.Write("\nWhat kind of pizza would you like to order? : ");
            pizzaChoice = Convert.ToInt32(Console.ReadLine());

            if (pizzaChoice == 1)
            {
                Console.WriteLine("\nPepperonni Pizza (100 Baht)");
                Console.Write("How many pizza would you like to order?: ");

                int orderPizza = int.Parse(Console.ReadLine());
                int totalValue = orderPizza * 100;

                shipping(totalValue);
            }
            else if (pizzaChoice == 2)
            {
                Console.WriteLine("\nHawaii Pizza (110 Baht)");
                Console.Write("How many pizza would you like to order?: ");

                int orderPizza = int.Parse(Console.ReadLine());
                int totalValue = orderPizza * 110;

                shipping(totalValue);
            }
            
        }

        public static void burgerMenu()
        {
            Console.Clear();

            bannerTitle();
            Console.WriteLine("We have :");
            Console.WriteLine("1. Beef Burger (65 Baht)");
            Console.WriteLine("2. Chicken Burger (50 Baht)");

            int burgerChoice;
            Console.Write("\nWhat kind of burger would you like to order? : ");
            burgerChoice = Convert.ToInt32(Console.ReadLine());

            if (burgerChoice == 1)
            {
                Console.WriteLine("\nBeef Burger (65 Baht)");
                Console.Write("How many burgers would you like to order?: ");

                int orderBurger = int.Parse(Console.ReadLine());
                int totalValue = orderBurger * 65;

                shipping(totalValue);
            }
            else if (burgerChoice == 2)
            {
                Console.WriteLine("\nChicken Burger (50 Baht)");
                Console.Write("How many burgers would you like to order?: ");

                int orderBurger = int.Parse(Console.ReadLine());
                int totalValue = orderBurger * 50;

                shipping(totalValue);
            }
        }

        public static void drinkMenu()
        {
            Console.Clear();

            bannerTitle();
            Console.WriteLine("We have :");
            Console.WriteLine("1. Cola (15 Baht)");
            Console.WriteLine("2. Lemon Tea (25 Baht)");

            int drinkChoice;
            Console.Write("\nWhat kind of drink would you like to order? : ");
            drinkChoice = Convert.ToInt32(Console.ReadLine());

            if (drinkChoice == 1)
            {
                Console.WriteLine("\nCola (15 Baht)");
                Console.Write("How many cola would you like to order?: ");

                int orderCola = int.Parse(Console.ReadLine());
                int totalValue = orderCola * 15;

                shipping(totalValue);
            }
            else if (drinkChoice == 2)
            {
                Console.WriteLine("\nLemon Tea (25 Baht)");
                Console.Write("How many lemon tea would you like to order?: ");

                int orderLemon = int.Parse(Console.ReadLine());
                int totalValue = orderLemon * 25;

                shipping(totalValue);
            }
        }

        private static void bye()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGood-Bye!\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void shipping(int total)
        {
            string[] shipping = new string[3];
            Console.Write("\nEnter your name: ");
            shipping[0] = "Name: " + Console.ReadLine();

            Console.Write("Enter your address: ");
            shipping[1] = "Address: " + Console.ReadLine();

            Console.Write("Enter your phone: ");
            shipping[2] = "Phone: " + Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nOrder successfully!");
            Console.WriteLine("Total: " + total + " Bahts");

            for (int i = 0; i < shipping.Length; i++)
            {
                Console.WriteLine(shipping[i]);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("We will ship you in 30min.\n");

            Console.ForegroundColor = ConsoleColor.White;
        }

        
    }
}
