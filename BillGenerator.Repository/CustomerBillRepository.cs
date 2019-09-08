using BillGenerator.Domain.Models;
using BillGenerator.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Octobooks.Repository.Base;

namespace BillGenerator.Repository
{
    public class CustomerBillRepository : Repository<CustomerBill>, ICustomerBillRepository
    {
        public CustomerBillRepository(IConfiguration config, ILogger<Repository<CustomerBill>> logger) : base(config, logger)
        {

        }

    }
}
