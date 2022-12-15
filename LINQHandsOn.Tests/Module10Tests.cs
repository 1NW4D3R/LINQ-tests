using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 10
  /// </summary>
  [TestClass]
  public class Module10Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to union two products lists together using the ProductComparer class
    /// </summary>
    public void UnionProductDataOnCategoryAndPrice()
    {
      ProductComparer pc = new();
      List<Product> list = new();
      // Load Products With Category = "Spark Plugs"
      List<Product> list1 = ProductRepository.GetAll().Where(p => p.Category == "Spark Plugs").ToList();
      // Load Products Where Price > 200
      List<Product> list2 = ProductRepository.GetAll().Where(p => p.Price > 200).ToList();

      // Write Your Query Here
      

      // Assertion
      Assert.AreEqual(list.Count, 4);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return a list of customers by adding one list to another
    /// </summary>
    public void ConcatCustomers()
    {
      List<Customer> list = new();
      // Load Customers by Email Address
      List<Customer> list1 = CustomerRepository.GetAll().Where(c => c.EmailAddress.Contains("xyzcorp")).ToList();
      // Load Customers by Email Address
      List<Customer> list2 = CustomerRepository.GetAll().Where(p => p.EmailAddress.Contains("mortco")).ToList();

      // Write Your Query Here
      

      // Assertion
      Assert.AreEqual(list.Count, 5);
    }
  }
}