using Customers_management.Models;
using Customers_management.Services.Interface;

namespace Customers_management.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private CustomersDBContext _Customercontext;
        public CustomerService(CustomersDBContext customercontext)
        {
           _Customercontext = customercontext;
        }

        public void AddCustomer(tblCustomers customer)
        {
            _Customercontext.Add(customer);
            _Customercontext.SaveChanges();

        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _Customercontext.Customers.FirstOrDefault(c => c.CustomerId == customerId);

            if (customer != null)
            {
                _Customercontext.Customers.Remove(customer);
                _Customercontext.SaveChanges();
            }
            else
            {
                throw new Exception("Customer not found.");
            }
        }

        public List<tblCustomers> GetAllCustomers()
        {
            return _Customercontext.Customers.ToList();
        }

        public tblCustomers GetIdWiseCustomer(int customerId)
        {
            var lst= _Customercontext.Find<tblCustomers>(customerId);
            return lst;
        }

        public void UpdateCustomer(tblCustomers customer)
        {
            _Customercontext.Update(customer);
            _Customercontext.SaveChanges();

        }
    }
}
