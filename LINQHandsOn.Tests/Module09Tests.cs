using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

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
            value = list1.SequenceEqual(list2); // Miért kell túlbonyolítani Customer Comparer osztállyal?



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
              foreach(Product p1 in list1)
              {
                  bool notContains = true;
                  foreach(Product p2 in list2)
                  {
                      if(pc.Equals(p1, p2))
                      {
                          notContains = false;
                          continue;
                      }
                  }
                  if(notContains)
                  {
                      list.Add(p1);
                  }
              }
              // Ez LINQ-val nem ment

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
            list = (from p1 in list1
                   join p2 in list2
                   on p1.Category equals p2.Category
                   into Common
                   where Common.Any()
                   select p1).ToList();

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
            list = (from p in products
                   where categories.Contains(p.Category)
                   group p by p.Category into g
                   select new Product { Category = g.Key }).ToList();

      // Assertion
      Assert.AreEqual(list.Count, 2);
    }
  }
}