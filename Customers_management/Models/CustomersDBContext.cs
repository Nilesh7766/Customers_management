using Customers_management.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Customers_management.Models
{
    public class CustomersDBContext:DbContext
    {
        public CustomersDBContext(DbContextOptions<CustomersDBContext> options) : base(options) 
        { 
       
        }

        public DbSet<tblCustomers> Customers { get; set; }
    }
}
