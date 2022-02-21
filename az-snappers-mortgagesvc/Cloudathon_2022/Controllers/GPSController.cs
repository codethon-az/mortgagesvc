using Microsoft.AspNetCore.Mvc;
using Core;
using Newtonsoft.Json;

namespace Cloudathon_2022.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GPSController : Controller
    {
        [HttpGet]
        public string Index(Role persona = Role.Managed, approach approach = approach.Aggressive, decimal HouseCost = 5000000, decimal InvestedToday = 500000, int timeduration =10)
        {

            var gpsdtl = new GPSDetails() { YearstoSave = timeduration, GoalAmount = HouseCost, PlanningApproach = approach.ToString(), GoalName = "Dream Home" , UserPersona = new Persona() { Age = 35, Name = "Jack McArthy",PersonaType = Role.Managed.ToString() } };
            
            switch (approach)
            {
                case approach.Conservative:
                    gpsdtl.AmountLefttoSave = HouseCost - InvestedToday;
                    gpsdtl.Amountneededperyear = gpsdtl.AmountLefttoSave  / timeduration;
                    break;
                case approach.Aggressive:
                    gpsdtl.AmountLefttoSave = HouseCost - InvestedToday;
                    gpsdtl.Amountneededperyear = gpsdtl.AmountLefttoSave / timeduration;
                    break;
                default:
                    gpsdtl.AmountLefttoSave = HouseCost - InvestedToday;
                    gpsdtl.Amountneededperyear = gpsdtl.AmountLefttoSave / timeduration;
                    break;
            }
            return JsonConvert.SerializeObject(gpsdtl);
        }
    }
}
