namespace LINQHandsOn
{
  public class CustomerIdComparer : EqualityComparer<Customer>
  {
    public override bool Equals(Customer x, Customer y)
    {
      return x.CustomerId == y.CustomerId;
    }

    public override int GetHashCode(Customer obj)
    {
      return obj.CustomerId.GetHashCode();
    }
  }
}
