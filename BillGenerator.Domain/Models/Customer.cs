using BillGenerator.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Domain.Models
{
    public class Customer: Entity
    {
        public string customerName { get; set; }
    }
}
