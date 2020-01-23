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
        
        //POST api/values
        //{"AccountDetails":{"office":null,"AccountNumber":null,"FA":null,"KeyACcount":null},"UUID":"1234567","HouseDetails":{"Zipcode":null,"Area":null,"contrustiedIn":"0001-01-01T00:00:00","AgeInYears":0,"NumberOfBedrooms":0,"Cost":0.0}}
        [HttpPost]
        public string Post(GetQuoteRequest req)
        {
            QuoteResponse response = new QuoteResponse() { HouseCost = 2500000, IsPreapproved = true, RateofInterest = "2.40" };
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return jsonresponse;
        }

        
    }
}
