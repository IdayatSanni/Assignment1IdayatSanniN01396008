using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1IdayatSanniN01396008.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method receives a number and returns the result of the square of the integer input which will be a number
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>id * id</returns>
        /// <example>
        /// GET: localhost:xx/api/Square/2 -> 4
        /// GET: localhost:xx/api/Square/-2 -> 4 
        /// GET: localhost:xx/api/Square/10 -> 100
        /// </example>
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
