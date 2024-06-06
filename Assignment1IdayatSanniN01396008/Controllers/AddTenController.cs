using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1IdayatSanniN01396008.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// This method receives a number and returns the result of a mathematical addition applied on the number 
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>{id} + 10</returns>
        /// <example>
        /// GET: localhost:xx/api/AddTen/21 -> 31
        /// GET: localhost:xx/api/AddTen/0 -> 10 
        /// GET: localhost:xx/api/AddTen/-9 -> 1
        /// </example>
        public int Get(int id)
            
        {
            int result = id + 10;
            return result;
        }
    }
}
