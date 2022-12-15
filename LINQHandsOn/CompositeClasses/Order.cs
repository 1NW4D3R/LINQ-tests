using System.Text;

namespace LINQHandsOn
{
  public class Order
  {
    public int OrderHeaderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public string PromotionalCode { get; set; }
    public int OrderDetailId { get; set; }
    public int Quantity { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"Order ID: {OrderHeaderId}");
      sb.AppendLine($"   Customer ID: {CustomerId}");
      sb.AppendLine($"   Order Detail ID: {OrderDetailId}");
      sb.AppendLine($"   Order Date: {OrderDate:d}");
      sb.AppendLine($"   Product Name: {ProductName}");
      sb.AppendLine($"   Quantity: {Quantity}");
      sb.AppendLine($"   Price: {Price:c}");
      sb.AppendLine($"   Promotional Code: {PromotionalCode}");

      return sb.ToString();
    }
    #endregion
  }
}
