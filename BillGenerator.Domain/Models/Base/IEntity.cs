using System;
using System.Collections.Generic;
using System.Text;

namespace BillGenerator.Domain.Models.Base
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
