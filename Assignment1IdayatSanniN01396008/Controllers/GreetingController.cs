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
        /// <summary>
        /// This method listens for a post request and provides a string response
        /// </summary>
        /// <returns>
        /// "Hello World!"
        /// </returns>
        /// <example>
        /// Post: localhost:xx/api/Greeting -> "Hello World!"
        /// curl -d "" http://localhost:56442/api/Greeting
        /// </example>
        public string Post()
        {
            string response = "Hello World!";
            return response;
        }

        /// <summary>
        /// This method receives a number and returns a message indicating what number was entered
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>"Greetings to {id} people!"</returns>
        /// <example>
        /// GET: localhost:xx/api/Greetings/{id} -> "Greetings to {id} people!"
        /// GET: localhost:xx/api/Greetings/3 -> "Greetings to 3 people!"
        /// GET: localhost:xx/api/Greetings/6 -> "Greetings to 6 people!"
        /// GET: localhost:xx/api/Greetings/0 -> "Greetings to 0 people!"
        /// </example>
        public string Get(int id)
        {
            string message = $"Greetings to {id} people!";
            return message;
        }
    }
}
