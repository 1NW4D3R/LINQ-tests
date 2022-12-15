using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 13
  /// </summary>
  [TestClass]
  public class Module13Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return the count all OrderDetail objects where the ProductId property is equal to 8.
    /// </summary>
    public void CountOrdersWithProductID()
    {
      int value = 0;
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();

      // Write Query Syntax Here
      

      // Assertion
      Assert.AreEqual(value, 6);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return the minimum of the Price property on all OrderDetail objects.
    /// </summary>
    public void MinimumPriceOnAllOrders()
    {
      decimal value = 0;
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();

      // Write Query Syntax Here
      

      // Assertion
      Assert.AreEqual(value, 5.59M);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return the maximum of the Price property on all OrderDetail objects.
    /// </summary>
    public void MaximumPriceReturnOrderDetail()
    {
      OrderDetail value = new();
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();

      // Write Query Syntax Here
      

      // Assertion
      Assert.AreEqual(value.OrderDetailId, 5);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return the sum of the Price property on all OrderDetail objects.
    /// </summary>
    public void SumPriceOnAllOrders()
    {
      decimal value = 0;
      List<OrderDetail> details = RepositoryHelper.GetOrderDetails();

      // Write Query Syntax Here
     

      // Assertion
      Assert.AreEqual(value, 5806.46M);
    }
  }
}