using NUnit.Framework;
using SampleTestingApp;
using System.Collections.Generic;

namespace SampleTest
{
    public class Tests
    {
        ManageCustomer manage ;
        [SetUp]
        public void Setup()
        {
            //List<Customer> customers = new List<Customer>()
            //{
            //    new Customer(){Id=101,Name="Kim"}
            //};
            //manage = new ManageCustomer(customers);
        }

      //[TestCase(25)]
      //[TestCase(20)]
      //  public void TestGetCustomerID(int res)
      //  {
      //      //Arrange
           
      //      //Act
      //      var result = manage.GetCustomerID(10);
      //      //Assert
      //      Assert.AreEqual(res, result);
      //  }
      //  [TestCase(101)]
      //  [TestCase(102)]
      //  public void TestAddCustomer(int cid)
      //  {
      //      //Arrange
      //      //ManageCustomer manage = new ManageCustomer();
      //      //Act
      //      var result = manage.AddCustomer(new Customer { Id = cid, Name = "Tim" });
      //      //Assert
      //      Assert.AreEqual(true, result);
      //  }
    }
}