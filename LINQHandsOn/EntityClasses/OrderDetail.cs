using System.Text;

namespace LINQHandsOn
{
  public class OrderDetail
  {
    public int OrderDetailId { get; set; }
    public int CustomerId { get; set; }
    public int OrderHeaderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"Detail ID: {OrderDetailId}   Order ID: {OrderHeaderId}");
      sb.AppendLine($"   Customer ID: {CustomerId}   Product ID: {ProductId}");
      sb.AppendLine($"   Quantity: {Quantity}   Price: {Price:c}");

      return sb.ToString();
    }
    #endregion
  }
}
