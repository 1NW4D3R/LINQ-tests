using System.Text;

namespace LINQHandsOn
{
  public class Product
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int YearBegin { get; set; }
    public int YearEnd { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{ProductName}  Product Id: {ProductId}");
      sb.AppendLine($"   Category: {Category}");
      sb.AppendLine($"   Price: {Price:c}");
      sb.AppendLine($"   Year Begin: {YearBegin}  Year End: {YearEnd}");

      return sb.ToString();
    }
    #endregion
  }
}
