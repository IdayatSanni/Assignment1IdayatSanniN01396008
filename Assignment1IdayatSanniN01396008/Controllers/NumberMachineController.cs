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

        /// <summary>
        /// This method receives a number and returns the result of applying applies four mathematical operations to it
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>id + 10, id /2, id -5, id * 10</returns>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/10 -> {"sum":20,"divide":5,"subtract":5,"multiply":100}
        /// GET: localhost:xx/api/NumberMachine/-5 -> {"sum":5,"divide":-2,"subtract":-10,"multiply":-50}
        /// GET: localhost:xx/api/NumberMachine/30 -> {"sum":40,"divide":15,"subtract":25,"multiply":300}
        /// </example>
        public IHttpActionResult Method(int id) 
        {
            int sum = id + 10;
            int divide = id / 2;
            int subtract = id - 5;
            int multiply = id * 10;

            var result = new
            {
                sum,
                divide,
                subtract,
                multiply
            };

            return Ok(result);

        }


    }
}
