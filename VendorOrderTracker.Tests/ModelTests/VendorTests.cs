using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    // Test methods go here
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   Assert.AreEqual(ExpectedResult, CodeToTest);
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor","bread");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }


  }
}

      // [TestMethod]
      // public void AddItem_AssociatesItemWithCategory_ItemList()
      // {
      //   //Arrange
      //   string description = "Walk the dog.";
      //   Item newItem = new Item(description);
      //   List<Item> newList = new List<Item> { newItem };
      //   string name = "Work";
      //   Category newCategory = new Category(name);
      //   newCategory.AddItem(newItem);

      //   //Act
      //   List<Item> result = newCategory.Items;

      //   //Assert
      //   CollectionAssert.AreEqual(newList, result);
      // }