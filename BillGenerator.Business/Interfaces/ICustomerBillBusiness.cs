using BillGenerator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Business.Interfaces
{
    public interface ICustomerBillBusiness
    {
        CustomerBill Insert(CustomerBill customerBill);
        List<CustomerBill> GetAll();
    }
}
