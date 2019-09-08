using BillGenerator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Services.Interfaces
{
    public interface ICustomerBillServices
    {
        List<CustomerBill> GetAll();
        CustomerBill Insert(CustomerBill customeBill);
    }
}
