namespace LINQHandsOn
{
  public static class RepositoryHelper
  {
    #region GetCustomers Method
    public static List<Customer> GetCustomers()
    {
      // Get all Customer Data
      return CustomerRepository.GetAll();
    }
    #endregion

    #region GetProducts Method
    public static List<Product> GetProducts()
    {
      // Get all Product Data
      return ProductRepository.GetAll();
    }
    #endregion

    #region GetOrderHeaders Method
    public static List<OrderHeader> GetOrderHeaders()
    {
      // Get all Order Header Data
      return OrderHeaderRepository.GetAll();
    }
    #endregion

    #region GetOrderDetails Method
    public static List<OrderDetail> GetOrderDetails()
    {
      // Get all Order Detail Data
      return OrderDetailRepository.GetAll();
    }
    #endregion
  }
}
