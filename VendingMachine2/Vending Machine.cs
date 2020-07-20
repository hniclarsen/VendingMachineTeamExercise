using System;
using System.Collections.Generic;

namespace VendingMachine2
{
  class Vending_Machine
  {
    public Dictionary<Product, int> Inventory;
    public double CurrencyInput { get; private set; }

    public Vending_Machine()
    {
      Inventory = new Dictionary<Product, int>();
      CurrencyInput = 0.00;
    }

    public void AddCurrency(double input)
    {
      CurrencyInput += input;
    }

    public void AddProduct(Product product, int quantity)
    {
      Inventory.Add(product, quantity);
    }

    public void ResetProductQuantity()
    {
      foreach (var product in Inventory)
      {
        Inventory[product.Key] = 10;
      }
    }

    public void PrintInventory()
    {
      foreach (var product in Inventory)
      {
        Console.WriteLine($"{product.Key.Name}, Price: {product.Key.Price}");
      }
    }
  }
}
