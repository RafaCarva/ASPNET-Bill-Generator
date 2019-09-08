using BillGenerator.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Domain.Models
{
    public class CustomerBill:Entity
    {
        public Customer customer { get; set; }
        public List<Perform> performList { get; set; }
        public float billValue { get; set; }
    }
}
