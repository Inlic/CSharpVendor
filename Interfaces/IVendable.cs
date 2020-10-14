namespace CSharpVendor.Interfaces
{
  interface IVendable
  {
    string Name { get; set; }
    int Price { get; set; }
    string Type { get; set; }
    int Amount { get; set; }

  }
}