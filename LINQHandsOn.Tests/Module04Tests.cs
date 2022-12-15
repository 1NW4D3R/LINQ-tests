using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 4
  /// </summary>
  [TestClass]
  public class Module04Tests
  {   
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get all products and order the results by the ProductName property
    /// </summary>
    public void OrderProductsByName()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

            // Write Your Query Here
            list = (from p in products
                    orderby p.ProductName
                    select p).ToList();

      // Assertion
      Assert.AreEqual(list[0].ProductName, "ACDelco Alternator");
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get all products and order the results by the Category property in descending order and then the Price property in ascending order.
    /// </summary>
    public void OrderProductsByCategoryPrice()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

            // Write Your Query Here
            list = (from p in products
                    orderby p.Category descending,p.Price
                    select p).ToList();

      // Assertions
      Assert.AreEqual(list[0].Category, "Wax");
      Assert.AreEqual(list[0].Price, 7.79M);
    }
  }
}