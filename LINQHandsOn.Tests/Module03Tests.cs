using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 3
  /// </summary>
  [TestClass]
  public class Module03Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get all customers and put into a new list.
    /// </summary>
    public void GetAllCustomers()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      List<Customer> list = new();

      // Write Your Query Here
      list = (from c in customers
                   select c).ToList();

      // Assertion
      Assert.AreEqual(list.Count, 23);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get all products, create a new Product object, but only set the ProductName and Price properties.
    /// </summary>
    public void GetProductNameAndPrice()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

      // Write Your Query Here
      list = (from p in products
             select new Product{ ProductName = p.ProductName, Price = p.Price }).ToList();

      // Assertions
      Assert.IsNotNull(list[0].ProductName);
      Assert.IsNotNull(list[0].Price);
      Assert.IsNull(list[0].Category);
    }
  }
}