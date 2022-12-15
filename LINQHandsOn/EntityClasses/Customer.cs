using System.Text;

namespace LINQHandsOn
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string Phone { get; set; }
    public decimal TotalSales { get; set; }

    #region ToString Override 
    public override string ToString()
    {
      StringBuilder sb = new(1024);

      sb.AppendLine($"{LastName}, {FirstName}   Customer ID: {CustomerId}");
      sb.AppendLine($"   Email Address: {EmailAddress}");
      sb.AppendLine($"   Phone: {Phone}");

      return sb.ToString();
    }
    #endregion
  }
}
