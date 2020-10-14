using System;

namespace CSharpVendor.Controllers
{
  internal class VendorController
  {
    private VendorService _Service { get; set; } = new VendorService();

    public bool _Running { get; set; } = true;

    public void Run()
    {
      while (_Running)
      {
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      Console.WriteLine("Options: Snacks, Coffee, Hot food, Cold food");
      string input = Console.ReadLine().ToLower();
      Console.Clear();
      switch (input)
      {
        case "snacks":
          BuySnacks();
          break;
        case "coffee":
          BuyCoffee();
          break;
        case "hotfood":
        case "hot food":
          BuyHotFood();
          break;
        case "coldfood":
        case "cold food":
          BuyColdFood();
          break;
        default:
          Console.WriteLine("Invalid Command");
          break;
      }
    }

    private void BuySnacks()
    {
      Console.WriteLine(_Service.GetVendables("snacks"));
      Console.WriteLine("Enter a number to buy the item.");
      string inputStr = Console.ReadLine();
      if (int.TryParse(inputStr, out int index) && index > 0)
      {
        Console.WriteLine(_Service.BuyVendable("snacks", index - 1));
      }
    }

    private void BuyCoffee()
    {
      Console.WriteLine(_Service.GetVendables("coffee"));
      Console.WriteLine("Enter a number to buy the item.");
      string inputStr = Console.ReadLine();
      if (int.TryParse(inputStr, out int index) && index > 0)
      {
        Console.WriteLine(_Service.BuyVendable("coffee", index - 1));
      };
    }

    private void BuyColdFood()
    {
      Console.WriteLine(_Service.GetVendables("coldfood"));
      Console.WriteLine("Enter a number to buy the item.");
      string inputStr = Console.ReadLine();
      if (int.TryParse(inputStr, out int index) && index > 0)
      {
        Console.WriteLine(_Service.BuyVendable("coldfood", index - 1));
      }
    }
    private void BuyHotFood()
    {
      Console.WriteLine(_Service.GetVendables("hotfood"));
      Console.WriteLine("Enter a number to buy the item.");
      string inputStr = Console.ReadLine();
      if (int.TryParse(inputStr, out int index) && index > 0)
      {
        Console.WriteLine(_Service.BuyVendable("hotfood", index - 1));
      }
    }

    public VendorController()
    {
    }
  }
}