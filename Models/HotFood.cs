using CSharpVendor.Interfaces;

namespace CSharpVendor.Models
{
  class HotFood : IVendable, ITempSensitiveItems
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public int Amount { get; set; }

    public int RequiredTemp { get; set; }

    public int StoredTemp { get; set; }

    public HotFood(string name, int price, string type, int amount, int requiredtemp, int storedtemp)
    {
      Name = name;
      Price = price;
      Type = type;
      Amount = amount;
      RequiredTemp = requiredtemp;
      StoredTemp = storedtemp;
    }
    public string Prepare()
    {
      return "\nPlease Wait. Item is being heated.\n";
    }
  }

}