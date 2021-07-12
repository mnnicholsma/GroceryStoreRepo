using System;
using GroceryStoreAPI;
using GroceryStoreAPI.Data;
using Xunit;
using System.Threading.Tasks;
using Moq;

namespace UnitTest
{
    public class CustomerTests
    {
        [Fact]
        public async Task MoqNewCustomer()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var customerObj = new Customer();
            customerObj.DateOfBirth = DateTime.Now;
            customerObj.FirstName = "Test";
            customerObj.LastName = "Name";
            mockUnitOfWork.Setup(uow => uow.Customer.InsertCustomer(customerObj));
            GroceryStoreAPI.Controllers.CustomerController customerController = new GroceryStoreAPI.Controllers.CustomerController(mockUnitOfWork.Object);

            var result = await customerController.CustomerAddAsync(customerObj);
            Assert.Equal("Success", result.Message);
        }

        [Fact]
        public async Task NewCustomerFutureBirthDateNotAllowed()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var customerObj = new Customer();
            customerObj.DateOfBirth = DateTime.Today.AddDays(1);
            customerObj.FirstName = "Test";
            customerObj.LastName = "Name";
            mockUnitOfWork.Setup(uow => uow.Customer.InsertCustomer(customerObj));
            GroceryStoreAPI.Controllers.CustomerController customerController = new GroceryStoreAPI.Controllers.CustomerController(mockUnitOfWork.Object);

            var result = await customerController.CustomerAddAsync(customerObj);
            Assert.Equal("error", result.Status);
        }

        [Fact]
        public async Task NewCustomerBirthDateGreaterThan120NotAllowed()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var customerObj = new Customer();
            customerObj.DateOfBirth = DateTime.Today.AddYears(-130);
            customerObj.FirstName = "Test";
            customerObj.LastName = "Name";
            mockUnitOfWork.Setup(uow => uow.Customer.InsertCustomer(customerObj));
            GroceryStoreAPI.Controllers.CustomerController customerController = new GroceryStoreAPI.Controllers.CustomerController(mockUnitOfWork.Object);

            var result = await customerController.CustomerAddAsync(customerObj);
            Assert.Equal("error", result.Status);
        }

    }
}
