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
        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
