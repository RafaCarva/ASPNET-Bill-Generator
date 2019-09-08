using BillGenerator.Domain.Models;
using BillGenerator.Services.Interfaces;
using BillGenerator.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Services
{
    public class CustomerBillService : ICustomerBillServices
    {
        private readonly ICustomerBillBusiness _customerBillBusiness;

        public CustomerBillService(ICustomerBillBusiness customerBillBusiness)
        {
            _customerBillBusiness = customerBillBusiness;
        }

        public List<CustomerBill> GetAll()
        {
            return _customerBillBusiness.GetAll();
        }

        public CustomerBill Insert(CustomerBill customeBill)
        {
            throw new NotImplementedException();
        }
    }
}
