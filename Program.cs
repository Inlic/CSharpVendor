using System;
using CSharpVendor.Controllers;

namespace CSharpVendor
{
  class Program
  {
    static void Main(string[] args)
    {
      new VendorController().Run();
    }
  }
}
