using Microsoft.AspNetCore.Mvc;

using Core;

namespace Cloudathon_2022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanDetailsController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {
            QuoteResponse response = new QuoteResponse() { HouseCost = 25000000, IsPreapproved = true, RateofInterest = "2.40" };
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return jsonresponse;
        }
    }
}
