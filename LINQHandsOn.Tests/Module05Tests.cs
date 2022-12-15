using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 5
  /// </summary>
  [TestClass]
  public class Module05Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get those customers where the EmailAddress contains the string 'mortco.com'.
    /// </summary>
    public void GetCustomersByEmail()
    {
      List<Customer> customers = RepositoryHelper.GetCustomers();
      List<Customer> list = new();

            // Write Your Query Here
            list = (from c in customers
                    where c.EmailAddress.Contains("mortco.com")
                    select c).ToList();

      // Assertion
      Assert.AreEqual(list.Count, 3);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to get products where the YearBegin property is greater than or equal to 2016 and the YearEnd property is less than or equal to 2021.
    /// </summary>
    public void GetProductsBetweenYears()
    {
      List<Product> products = RepositoryHelper.GetProducts();
      List<Product> list = new();

      // Write Your Query Here
      list = (from p in products
              where (p.YearBegin >= 2016) && (p.YearEnd <= 2021)
              select p).ToList();

      // Assertion
      Assert.AreEqual(list.Count, 17);
    }
  }
}