namespace LINQHandsOn
{
  public class CustomerComparer : EqualityComparer<Customer>
  {
    public override bool Equals(Customer x, Customer y)
    {
      return x.CustomerId == y.CustomerId &&
             x.FirstName == y.FirstName &&
             x.LastName == y.LastName &&
             x.EmailAddress == y.EmailAddress &&
             x.Phone == y.Phone;
    }

    public override int GetHashCode(Customer obj)
    {
      string value = obj.CustomerId.ToString() +         
        obj.FirstName + 
        obj.LastName + 
        obj.EmailAddress + 
        obj.Phone;

      return value.GetHashCode();
    }
  }
}
