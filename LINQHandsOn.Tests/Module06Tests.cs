using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 6
  /// </summary>
  [TestClass]
  public class Module06Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to retrieve a single product where the ProductId property is equal to 20.
    /// </summary>
    public void GetSingleProduct()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      Product product = new();

            // Write Your Query Here
            product = (from p in products
                      where p.ProductId == 20
                      select p).First();

      // Assertion
      Assert.AreEqual(product.ProductName, "PurolatorBOSS Air Filter");
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to retrieve just the first Product object where the Category property is equal to "Batteries".
    /// </summary>
    public void GetFirstProductWithCategoryOfBatteries()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      Product product = new();

            // Write Your Query Here
            product = (from p in products
                       where p.Category == "Batteries"
                       select p).First();

      // Assertion
      Assert.AreEqual(product.Category, "Batteries");
    }
  }
}