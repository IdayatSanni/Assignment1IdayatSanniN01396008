using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1IdayatSanniN01396008.Controllers
{
    public class HostingCostController : ApiController
    {
        [HttpGet]
        [Route("api/HostingCost/{id}")]

        /// <summary>
        /// This method receives a number and calculates the total hosting cost based on the number provided
        /// </summary>
        /// <param name="id">the number to enter</param>
        /// <returns>
        /// It returns three strings that describes the total hosting cost
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/0 -> 1 fortnights at $5.50/FN = $5.50 CAD HST 13% = $2.00 CAD Total = $7.50 CAD
        /// GET: localhost:xx/api/HostingCost/14 -> 2 fortnights at $5.50/FN = $11.00 CAD HST 13% = $2.00 CAD Total = $13.00 CAD
        /// GET: localhost:xx/api/HostingCost/15 -> 2 fortnights at $5.50/FN = $11.00 CAD HST 13% = $2.00 CAD Total = $13.00 CAD
        /// GET: localhost:xx/api/HostingCost/21 -> 2 fortnights at $5.50/FN = $11.00 CAD HST 13% = $2.00 CAD Total = $13.00 CAD
        /// GET: localhost:xx/api/HostingCost/28 -> 3 fortnights at $5.50/FN = $16.50 CAD HST 13% = $13 CAD Total = $29.50 CAD
        /// </example>

        public string HostingCost(int id) { 
        // Calculate their number of fortnights
        int fortnights = (id / 14) + 1;

        // Calculate the cost of hosting
        decimal cost = fortnights * 5.50m;

        // Calculate the hst of the fortnights
        decimal hstPrice = 13 % cost;

        // Calculate the total of adding up the fortnight and hst
        decimal totalAll = cost + hstPrice;

        // the strings that we will output
        string result1 = $"{fortnights} fortnights at $5.50/FN = ${cost} CAD ";
        string result2 = $"HST 13%  = ${hstPrice} CAD ";
        string result3 = $"Total = ${totalAll} CAD";
        return result1 + result2 + result3 ;
        }
    }
}
