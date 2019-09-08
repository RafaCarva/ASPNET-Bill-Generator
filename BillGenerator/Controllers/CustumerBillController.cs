using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillGenerator.Domain.Models;
using BillGenerator.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BillGenerator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustumerBillController : ControllerBase
    {

        private readonly ICustomerBillServices _customerBillService;

        public CustumerBillController(ICustomerBillServices customerBillService)
        {
            _customerBillService = customerBillService;
        }

        // GET api/client
        [HttpGet]
        public ActionResult<IEnumerable<CustomerBill>> GetAll()
        {
            try
            {
                return Ok(_customerBillService.GetAll());
            }
            catch (Exception exception)
            {
                return new StatusCodeResult(500);
            }
        }

        // POST: api/CustumerBill
        [HttpPost]
        public ActionResult<CustomerBill> Post([FromBody] CustomerBill customerBill)
        {
            try
            {
                var clientEntity = _customerBillService.Insert(customerBill);
                //return Ok("success");    
                return Ok(clientEntity);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

    }
}
