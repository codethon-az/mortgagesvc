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
        //{"AccountDetails":{"office":null,"AccountNumber":null,"FA":null,"KeyACcount":null,"UserId":null,"AUM":null,"Tenure":null},"PropertyDetails":{"Zipcode":null,"Area":null,"contrustedIn":"0001-01-01T00:00:00","AgeInYears":0,"NumberOfBedrooms":0,"Cost":0.0,"PropertyId":null}}
        [HttpPost]
        public string Post(GetQuoteRequest request)
        {
            var response = new QuoteResponse();
            var IseverythingAlright = Validate(request);
            if(!IseverythingAlright)
            {
                return "Please check input parameters, Something is not right!";
            }

            response = CalculateOffer(request);            
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return jsonresponse;
        }

        private QuoteResponse CalculateOffer(GetQuoteRequest request)
        {
            var response = new QuoteResponse();
            if(request.PropertyDetails.Cost/request.AccountDetails.AUM > 5)
            {
                response.DownPayment = 50000;
                response.RateofInterest = "5.0%";
                response.IsPreApproved = true;
            }
            else if (request.PropertyDetails.Cost / request.AccountDetails.AUM > 8)
            {
                response.DownPayment = 40000;
                response.RateofInterest = "4.0%";
                response.IsPreApproved = true;
            }
            else if (request.PropertyDetails.Cost / request.AccountDetails.AUM > 10)
            {
                response.DownPayment = 10000;
                response.RateofInterest = "2.5%";
                response.IsPreApproved = true;
            }
            else
            {
                response.IsPreApproved = false;
            }
            response.PropertyId = request.PropertyDetails.PropertyId;
            response.UserId = request.AccountDetails.UserId;
            response.AccountNumber = request.AccountDetails.AccountNumber;
            response.MonthlyEMI = (request.PropertyDetails.Cost - response.DownPayment) / 240;
            return response;

        }

        private bool Validate(GetQuoteRequest request)
        {
            if(request == null || request.AccountDetails?.UserId == null ||
                request.AccountDetails?.AUM == null
                || request.PropertyDetails?.PropertyId ==null || request.PropertyDetails?.Cost == null)
            {
                return false;
            }
            
            return true;
            
        }
    }
}
