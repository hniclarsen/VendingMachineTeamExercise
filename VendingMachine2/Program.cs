using System;

namespace VendingMachine2
{
  class Program
  {
    static Vending_Machine vendingMachine;

    static void Main(string[] args)
    {
      vendingMachine = new Vending_Machine();

      InitializeProducts();

      var flag = true;
      var line = "";

      while(flag)
      {
        line = Console.ReadLine();

        ProcessInput(line);
      }
    }

    public static void PrintHelp()
    {
      
    }

    public static void ProcessInput(string input)
    {
      if (Double.TryParse(input, out double result))
      {
        double amount = Double.Parse(input);
        vendingMachine.AddCurrency(amount);
        return;
      }

      if(String.IsNullOrEmpty(input))
      {
        return;
      }

      var tokens = input.Split(' ');
      switch (tokens[0])
      {
        case "buy":
          PurchaseItem(tokens[1]);
          break;
        default:
          Console.WriteLine("Unrecognized input");
          break;
      }
    }

    public static void PurchaseItem(string item)
    {
      
    }

    public static void InitializeProducts()
    {
      var coke = new Product("Coke", 0.25);
      var pepsi = new Product("Pepsi", 0.35);
      var drPepper = new Product("Dr Pepper", 0.45);

      vendingMachine.AddProduct(coke, 10);
      vendingMachine.AddProduct(pepsi, 10);
      vendingMachine.AddProduct(drPepper, 10);
    }
  }
}
