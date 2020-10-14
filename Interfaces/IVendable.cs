namespace CSharpVendor.Interfaces
{
  class IVendable
  {
    string Name { get; set; }
    int Price { get; }
    string Type { get; }
    int Amount { get; set; }

  }
}