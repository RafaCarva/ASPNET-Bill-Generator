using BillGenerator.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Domain.Models
{
    public class Perform
    {
        public string performName { get; set; }
        public PerformType performType { get; set; }
        public int audience { get; set; }
    }
}
