using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1IdayatSanniN01396008.Controllers
{
    public class NumberMachineController : ApiController
    {
        [HttpGet]
        [Route("api/NumberMachine/{id}")]

        public int Method(int id) 
        {
            int sum = id + 10;
            int divide = id / 10;
            int multiply = id % 10;

            var result = new
            {
                add = sum,
                divisonMami = divide,
                multiplication = multiply
            };
            return ok(result);

        }


    }
}
