using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 8
  /// </summary>
  [TestClass]
  public class Module08Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return true if all values in the product Category property contain a space.
    /// </summary>
    public void AllProductCategoriesContainSpace()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      bool value = true;

      // Write Your Query Here
      

      // Assertion
      Assert.IsFalse(value);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return true if any customer has a LastName property that starts with the letter 'W'.
    /// </summary>
    public void AnyCustomerLastNamesStartWithW()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      bool value = false;

      // Write Your Query Here


      // Assertion
      Assert.IsTrue(value);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to return if the customer collection contains a customer where the CustomerId property Contains the value '4009'. Use the Contains() method and a Customer Comparer class for this query.
    /// </summary>
    public void SearchCustomersUsingComparerClass()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      CustomerIdComparer pc = new();
      bool value = false;

      // Write Your Query Here


      // Assertion
      Assert.IsTrue(value);
    }
  }
}