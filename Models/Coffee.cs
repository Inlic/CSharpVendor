using System;
using CSharpVendor.Interfaces;

namespace CSharpVendor.Models
{
  class Coffee : IVendable, ITempSensitiveItems
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public int Amount { get; set; }

    public bool Cream { get; set; }

    public bool Sugar { get; set; }

    public int RequiredTemp { get; set; }

    public int StoredTemp { get; set; }

    public Coffee(string name, int price, string type, int amount, bool cream, bool sugar, int requiredtemp, int storedtemp)
    {
      Name = name;
      Price = price;
      Type = type;
      Amount = amount;
      Cream = cream;
      Sugar = sugar;
      RequiredTemp = requiredtemp;
      StoredTemp = storedtemp;
    }

    public string Prepare()
    {
      return "\nPlease Wait. Item is being prepared.\n";
    }
  }

}