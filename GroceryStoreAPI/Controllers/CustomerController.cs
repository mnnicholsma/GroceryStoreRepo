using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroceryStoreAPI.Data;
using System.Collections.Generic;

namespace GroceryStoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public CustomerController(IUnitOfWork untOfWork)
        {
            _unitOfWork = untOfWork;
        }

        [HttpGet]
        [Route("get-all-customers")]
        public async Task<IList<Customer>> GetAllCustomers()
        {
            var allCustomers = await _unitOfWork.Customer.GetAllCustomers();
            return allCustomers;
        }

        [HttpGet]
        [Route("get-customer/{id:int}")]
        public async Task<IList<Customer>> GetCustomer(int id)
        {
            var allCustomers = await _unitOfWork.Customer.GetCustomer(id);
            return allCustomers;
        }




        [HttpPut]
        [Route("customer-update")]
        public async Task<Models.ResponseCustomerUpdate> CustomerUpdateAsync(Customer customerData)
        {
            if (!ModelState.IsValid)
            {
                return new Models.ResponseCustomerUpdate
                {
                    Status = "error",
                    Message = "Error updating customer record into database."
                };
            }

            try
            {
                var customerObjAdded = await _unitOfWork.Customer.UpdateCustomer(customerData);

                if (customerObjAdded != null)
                {
                    await _unitOfWork.Save();
                    return new Models.ResponseCustomerUpdate
                    {
                        Status = "success",
                        Message = "Success"
                    };
                }


            }
            catch (Exception ex)
            {
                //    TODO: ERROR LOGGING
            }
            return new Models.ResponseCustomerUpdate
            {
                Status = "error",
                Message = "Error updating customer record into database."
            };

        }

        [HttpPost]
        [Route("customer-add")]
        public async Task<Models.ResponseCustomerAdd> CustomerAddAsync(Customer customerData)
        {

            bool customerIsValid=CheckCustomerForErrors(customerData);
            if (customerIsValid==false)
            {
                return new Models.ResponseCustomerAdd
                {
                    Status = "error",
                    Message = "Error adding customer record into database."
                };
            }

            try
            {
                var customerObjAdded = await _unitOfWork.Customer.InsertCustomer(customerData);
                await _unitOfWork.Save();

                return new Models.ResponseCustomerAdd
                {
                    Status = "success",
                    Message = "Success"
                };
            }
            catch (Exception ex)
            {
                //    TODO: ERROR LOGGING
            }
            return new Models.ResponseCustomerAdd
            {
                Status = "error",
                Message = "Error adding customer record into database."
            };
        }

        private bool CheckCustomerForErrors(Customer customerData)
        {
            bool customerIsValid = true;
            if (customerData.DateOfBirth > DateTime.Now)
            {
                customerIsValid = false;
            }
            else if (customerData.DateOfBirth < DateTime.Today.AddYears(-120))
            {
                customerIsValid = false;
            }
            return customerIsValid;
        }
    }
}
