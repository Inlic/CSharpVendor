using System.Collections.Generic;
using CSharpVendor.Interfaces;
using CSharpVendor.Models;

namespace CSharpVendor.Services
{
  class VendorService
  {
    public List<IVendable> Vendables { get; set; }

    internal string GetVendables(string type)
    {
      var vendables = Vendables.FindAll(v => v.Type == type);
      if (vendables.Count == 0)
      {
        return "Nothing in Vending Machine";
      }
      string List = "";
      for (int i = 0; i < vendables.Count; i++)
      {
        List += $"{i + 1}. {vendables[i].Name} - ${vendables[i].Price} - Amount Left {vendables[i].Amount}\n";
      }
      return List;
    }
    internal string BuyVendable(string type, int index)
    {
      var vendables = Vendables.FindAll(v => v.Type == type);
      if (index < vendables.Count && vendables[index].Amount > 0)
      {
        vendables[index].Amount -= 1;
        return "Enjoy your item";
      }
      return "Invalid Selection.";
    }
    public VendorService()
    {
      Vendables = new List<IVendable>()
      {
        new Snack("Fritos", 1,"snacks",10),
        new Coffee("Mocha", 3,"coffee",3, true, true, 160, 68),
        new ColdFood("Chocolate Covered Banana", 2,"coldfood",12, 10, 68),
        new HotFood("Chicken Soup", 4, "hotfood", 5, 136, 68)
      };
    }
  }
}