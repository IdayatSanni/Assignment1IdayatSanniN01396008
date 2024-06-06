using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1IdayatSanniN01396008.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            string response = "Hello World!";
            return response;
        }

        public string Get(int id)
        {
            string message = $"Greetings to {id} people!";
            return message;
        }
    }
}
