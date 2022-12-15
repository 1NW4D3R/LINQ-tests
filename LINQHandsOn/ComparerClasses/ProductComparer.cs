namespace LINQHandsOn
{
  public class ProductComparer : EqualityComparer<Product>
  {
    public override bool Equals(Product x, Product y)
    {
      // Compare each property to the other to determine equality
      return x.ProductId == y.ProductId &&
             x.ProductName == y.ProductName &&
             x.Category == y.Category &&
             x.Price == y.Price &&
             x.YearBegin == y.YearBegin &&
             x.YearEnd == y.YearEnd;
    }

    public override int GetHashCode(Product obj)
    {
      string value = obj.ProductId.ToString() +
        obj.ProductName +
        obj.Category +
        obj.Price.ToString() +
        obj.YearBegin.ToString() +
        obj.YearEnd.ToString();

      return value.GetHashCode();
    }
  }
}
