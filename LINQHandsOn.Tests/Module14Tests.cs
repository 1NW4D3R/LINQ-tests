using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 14
  /// </summary>
  [TestClass]
  public class Module14Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to set the TotalSales property on the Customer class by summing up the sales for that customer in the OrderDetail list.
    /// </summary>
    public void CalculateTotalSalesForCustomer()
    {
      List<Customer> list = CustomerRepository.GetAll();
      List<OrderDetail> orders = OrderDetailRepository.GetAll();

      // Write Query Syntax Here
      

      // Assertion
      Assert.AreEqual(list[0].TotalSales, 5441.14M);
    }
  }
}