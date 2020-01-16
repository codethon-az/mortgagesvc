using System;
using System.Collections.Generic;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace az_snappers_mortgagesvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(GetQuoteRequest request)
        {
            QuoteResponse response = new QuoteResponse() { HouseCost = 2500000, IsPreapproved = true, RateofInterest = "2.40" };
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return new string[] { jsonresponse };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"item {id} returned.";
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
