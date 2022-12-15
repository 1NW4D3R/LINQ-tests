using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 9
  /// </summary>
  [TestClass]
  public class Module09Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return true if two customer collections are equal using a Customer Comparer class.
    /// </summary>
    public void AreTwoCustomerCollectionsEqual()
    {
      List<Customer> list1 = RepositoryHelper.GetCustomers();
      List<Customer> list2 = RepositoryHelper.GetCustomers();
      CustomerComparer pc = new();
      bool value = true;

      list1.RemoveAt(0);

      // Write Your Query Here
      

      // Assertion
      Assert.IsFalse(value);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return a list of products NOT in common between two lists.
    /// </summary>
    public void FindProductsNotInCommon()
    {
      List<Product> list1 = RepositoryHelper.GetProducts();
      List<Product> list2 = RepositoryHelper.GetProducts();
      ProductComparer pc = new();
      List<Product> list = new();

      // Make lists different by removing some categories
      list2.RemoveAll(p => p.Category == "Spark Plugs" ||
                      p.Category == "Alternators");

      // Write Your Query Here
     

      // Assertion
      Assert.AreEqual(list.Count, 4);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return a list products that ARE in common between two lists.
    /// </summary>
    public void FindProductsInCommon()
    {
      List<Product> list1 = RepositoryHelper.GetProducts();
      List<Product> list2 = RepositoryHelper.GetProducts();
      ProductComparer pc = new();
      List<Product> list = new();

      // Make lists different by removing some categories
      list2.RemoveAll(p => p.Category == "Spark Plugs" ||
                      p.Category == "Alternators");

      // Write Your Query Here
      

      // Assertion
      Assert.AreEqual(list.Count, 30);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return a set of products that match a set of categories.
    /// </summary>
    public void FindDistinctProductsInCommon()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

      // List of categories to locate
      List<string> categories = new() { "Spark Plugs", "Batteries" };

      // Write Your Query Here
      

      // Assertion
      Assert.AreEqual(list.Count, 2);
    }
  }
}