using System.Text;

namespace LINQHandsOn
{
  public class OrderHeader
  {
    public int OrderHeaderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Price { get; set; }
    public string PromotionalCode { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"Order ID: {OrderHeaderId}");
      sb.AppendLine($"   Customer ID: {CustomerId}");
      sb.AppendLine($"   Order Date: {OrderDate:d}");
      sb.AppendLine($"   Price: {Price:c}");
      sb.AppendLine($"   Promotional Code: {PromotionalCode}");

      return sb.ToString();
    }
    #endregion
  }
}
