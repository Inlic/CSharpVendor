using CSharpVendor.Interfaces;

namespace CSharpVendor.Models
{
  class Snack : IVendable
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public string Type { get; set; }
    public int Amount { get; set; }

    public Snack(string name, int price, string type, int amount)
    {
      Name = name;
      Price = price;
      Type = type;
      Amount = amount;
    }
  }

}