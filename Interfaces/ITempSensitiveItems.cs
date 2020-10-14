namespace CSharpVendor.Interfaces
{
  interface ITempSensitiveItems
  {
    int RequiredTemp { get; }
    int StoredTemp { get; }
    string Prepare();
  }
}