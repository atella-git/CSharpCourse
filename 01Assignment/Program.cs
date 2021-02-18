using System;
using System.Diagnostics;

namespace _01Assignment
{
    //Aditya Tella
    //Lesson 3
  
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to .NET Soda Vending Machine");

            //Create a instance of class PurchasePrice
            PurchasePrice price = new PurchasePrice();
            
            //Create a instance of class CanRack
            CanRack rack = new CanRack();
            rack.FillTheCanRack();
            
            // Grab the value of the priceofsoda 
            Console.WriteLine($"Please enter {price.Priceofsodadec} cents");

            //Extract the price entered by the user
            string valueEntered = Console.ReadLine();
            if (decimal.TryParse(valueEntered, out decimal decimalEntered))
            {
                Console.WriteLine($"You have inserted {decimalEntered} cents");
            }
            else 
            {
                Console.WriteLine($"You have inserted {valueEntered} cents");
            }

            //call class canrack
            Console.Write("Please enter soda flavor:");
            string sodaFlavor = Console.ReadLine();
            if (Enum.TryParse<Flavortype>(sodaFlavor, out Flavortype flavorName))
            {
                if (Enum.IsDefined(typeof(Flavortype), flavorName)) 
                {
                    rack.RemoveACanof(flavorName);
                }

            }

            Console.WriteLine("Here is your soda");

        }
    }
}

