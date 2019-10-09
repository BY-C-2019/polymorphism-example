using System;
using System.Collections.Generic;

namespace polymorphism
{
	class Product {
		public string amount;

		public virtual void Configure() {
			BaseConfigure();
		}

		protected void BaseConfigure() {
			Console.WriteLine("Skriv in antal:");
			amount = Console.ReadLine();
		}

		public virtual void PrintReceipt() {
			Console.WriteLine("[KVITTO] " + amount + " st produkter");
		}
	}

	class Candy : Product
	{	
		public string flavor;

		public override void Configure() {
			BaseConfigure();
			
			Console.WriteLine("Ange smak:");
			flavor = Console.ReadLine();
		}

		public override void PrintReceipt() {
			Console.WriteLine("[KVITTO] " + amount + "st godis produkter med smaken " + flavor);
		}
	}

	class Car : Product
	{
		public string model;
		public string color;

		public override void Configure() {
			BaseConfigure();
			
			Console.WriteLine("Ange färg:");
			color = Console.ReadLine();
			Console.WriteLine("Ange model:");
			model = Console.ReadLine();
		}

		public override void PrintReceipt() {
			Console.WriteLine("[KVITTO] " + amount + " st "+ color +" bilar av modellen " + model);
		}
	}

    class Program
    {
		static void Main(string[] args)
        {
			List<Product> cart = new List<Product>();

			Candy myCandy = new Candy();
			myCandy.Configure();
			cart.Add(myCandy);

			Candy mySecondCandy = new Candy();
			mySecondCandy.amount = "1";
			mySecondCandy.flavor = "smak";
			cart.Add(mySecondCandy);

			Car myCar = new Car();
			myCar.Configure();
			cart.Add(myCar);

			foreach (Product product in cart) {
				product.PrintReceipt();
			}

			// Console.WriteLine("Min produkt är en:");
			// string stringToWrite = myProduct.ToString();
			// Console.WriteLine(stringToWrite);
        }
    }
}
