using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABS.Core.Domain.Customers;
using ABS.Data;

namespace ABS.Data.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            ABSDbContext context= new ABSDbContext();
            EFRepository<Customer> customerRepository= new EFRepository<Customer>(context);
            customerRepository.Insert(new Customer { Id = 1,Name = "testCustomer",Active = true,Deleted =false});



        }
    }
}
