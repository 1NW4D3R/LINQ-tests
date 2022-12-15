using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 11
  /// </summary>
  [TestClass]
  public class Module11Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to create a new Order class by joining the OrderHeader and OrderDetail objects based on the OrderHeaderId property.
    /// </summary>
    public void JoinOrderHeadersAndDetails()
    {
      List<OrderHeader> headers = RepositoryHelper.GetOrderHeaders();
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();
      List<Order> list = new();

      // Write Your Query Here
      

      // Assertion
      Assert.IsTrue(list.Count == 54);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to create a new HeaderAndDetails class by joining the OrderHeader and OrderDetail objects. The Header property is the single OrderHeader object and the Details property is the list of OrderDetail objects that match the OrderHeaderId.
    /// </summary>
    public void CreateHeaderAndDetails()
    {
      List<HeaderAndDetails> list = new();
      List<OrderHeader> headers = RepositoryHelper.GetOrderHeaders();
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();

      // Write Query Syntax Here
     

      // Assertions
      Assert.IsTrue(list.Count == 31);
      Assert.IsTrue(list[0].Details.Count == 3);
    }
  }
}