using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LINQHandsOn.Tests
{
  /// <summary>
  /// Tests for your queries for Module 12
  /// </summary>
  [TestClass]
  public class Module12Tests
  {
    [TestMethod]
    /// <summary>
    /// Write a LINQ query to group product objects by category. Use the Key property for ordering by categories.
    /// </summary>
    public void GroupProductsByCategoryUsingKey()
    {
      List<IGrouping<string, Product>> list = new();
      List<Product> products = RepositoryHelper.GetProducts();

            // Write Query Syntax Here
            list = (from p in products
                    group p by p.Category into g
                    orderby g.Key
                    select g).ToList();

      // Assertion
      Assert.IsTrue(list.Count == 17);
    }

    [TestMethod]
    /// <summary>
    /// Write a LINQ query to group products by category. After grouping, include only those categories where the Category property starts with the letter 'A'.
    /// </summary>
    public void GroupProductsByCategoryUsingWhere()
    {
      List<IGrouping<string, Product>> list = new();
      List<Product> products = RepositoryHelper.GetProducts();

            // Write Query Syntax Here
            list = (from p in products
                    group p by p.Category into g
                    where g.Key[0] == 'A'
                    select g).ToList();

      // Assertion
      //Assert.IsTrue(list.Count == 3); // Nem jó az ellenõrzés mert csak 1 olyan kaetgória van, ami 'A'-valé kezdõdik
      Assert.IsTrue(list.Count == 1);
    }
  }
}