using Customers_management.Models;
using Customers_management.Services.Interface;
using Customers_management.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Diagnostics;
using static System.Exception;
using Microsoft.Extensions.Primitives;

namespace Customers_management.Controllers
{

    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomerApiController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        // GetAllCustomers List
        [HttpGet]
        [Route("api/GetCustomers")]
        public List<tblCustomers> GetCustomers()
        {
            try
            {
                return _customerService.GetAllCustomers();
            }
            catch (Exception)
            {
                throw new Exception("Unable to fetch customers");
            }
        }
        //Get Id Wise Customers 
        [HttpGet]
        [Route("api/GetCustomer/{id}")]
       // Status Code:
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public tblCustomers GetIdWiseCustomer(int customerId)
        {
            try
            {
                return _customerService.GetIdWiseCustomer(customerId);
            }
            catch (Exception)
            {
                throw new Exception("Unable to find Id");
            }
        }
        //Add New Customers
        [HttpPost]
        [Route("api/AddCustomers")]
        //StatusCode:
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public string AddCustomers(tblCustomers customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerService.AddCustomer(customer);
                    return "Customer Added Successfully";
                }
                return "Customer Not Added";
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        //Update Exist Customers
        [HttpPut]
        [Route("api/UpdateCustomers")]
        //Status Code:
        [ProducesResponseType(200)]
        [ProducesResponseType(411)]
        public string UpdateCustomers(tblCustomers customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _customerService.UpdateCustomer(customer);
                    return "Customer Updated Successfully";

                }
                return "Customer Not Updated";
            }
            catch(Exception)
            {
                throw ;
            }
        }
        //Delete Id Wise Customers
        [HttpDelete]
        [Route("api/DeleteCustomer/{id}")]
        //Status Code:
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public string DeleteCustomer(int customerId)
        {
            try
            {
                _customerService.DeleteCustomer(customerId);
                return "Customer Deleted Successfully";
            }
            catch (Exception ex)
            {
                return $"An error occurred while deleting the customer: {ex.Message}";
            }
        }
    }
}
