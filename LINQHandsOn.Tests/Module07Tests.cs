using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 7
  /// </summary>
  [TestClass]
  public class Module07Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get just the first five customers.
    /// </summary>
    public void GetFirstFiveCustomers()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      List<Customer> list = new();

            // Write Your Query Here
            list = (from c in customers
                    select c).Take(5).ToList();

      // Assertion
      Assert.AreEqual(list.Count, 5);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get customers 5 through 10.
    /// </summary>
    public void GetCustomersFiveThroughTen()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      List<Customer> list = new();

            // Write Your Query Here
            list = (from c in customers
                    select c).Skip(5).Take(5).ToList();

            // Assertion
            Assert.AreEqual(list[0].CustomerId, 4007);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to skip orders where the CustomerId property is equal to 1.
    /// </summary>
    public void SkipOrdersWhereCustomerOne()
    {
      List<OrderHeader> orders = RepositoryHelper.GetOrderHeaders();
      List<OrderHeader> list = new();

      // Write Your Query Here
      list = (from o in orders
              where o.CustomerId != 1
              select o).ToList();

      // Assertion
      Assert.AreEqual(list[0].OrderHeaderId, 8);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get all distinct categories and return a list of Product objects sorted by the Category property.
    /// </summary>
    public void GetDistinctCategories()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

            // Write Your Query Here
            list = ( from p in products
                     orderby p.Category
                     select new Product { Category = p.Category}).Distinct().ToList();

      // Assertions
      Assert.IsTrue(list.Count == 17);
      Assert.AreEqual(list[0].Category, "Alternators");
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to split the customer collection into an array of 3 customers each.
    /// </summary>
    public void SplitCustomersIntoGroupsOfThree()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      List<Customer[]> list = new();

      // Write Your Query Here
      list = from c in customers
             group c by 

      // Assertions
      Assert.AreEqual(list.Count, 8);
      Assert.AreEqual(list[0].Length, 3);
    }
  }
}