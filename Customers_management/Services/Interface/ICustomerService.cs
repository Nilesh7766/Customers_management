using Customers_management.Models;

namespace Customers_management.Services.Interface
{
    public interface ICustomerService
    {
        void AddCustomer(tblCustomers customer);
        void UpdateCustomer(tblCustomers customer);
        void DeleteCustomer(int customerId);
       List<tblCustomers> GetAllCustomers();
        tblCustomers GetIdWiseCustomer(int customerId);

    }
}
