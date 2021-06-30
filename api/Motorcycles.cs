using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using shared;

namespace ch.wettsti
{
    public static class Motorcycles
    {
        private static readonly List<MotorcycleDto> MotorcycleList = new List<MotorcycleDto>
        {
            new MotorcycleDto() { Make = "Yamaha", Model = "MT-07", BuildYear = 2015, KmWhenBought = 0, KmNow = 9900, BoughtInYear = new DateTime(2015, 04, 14), SoldInYear = new DateTime(2015, 11, 30), UpdateDate = new DateTime(2021, 06, 30, 21, 34, 00) },
            new MotorcycleDto() { Make = "Yamaha", Model = "MT-07", BuildYear = 2016, KmWhenBought = 0, KmNow = 17_000, BoughtInYear = new DateTime(2016, 02, 04), SoldInYear = null, UpdateDate = new DateTime(2021, 06, 30, 21, 34, 00) },
            new MotorcycleDto() { Make = "KTM", Model = "450 EXC Six Days", BuildYear = 2012, KmWhenBought = 0, KmNow = 0, BoughtInYear = new DateTime(2016, 04, 02), SoldInYear = null, UpdateDate = new DateTime(2021, 06, 30, 21, 34, 00) }
        };

        [FunctionName("motorcycles")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var response = JsonConvert.SerializeObject(MotorcycleList);

            return new OkObjectResult(response);
        }
    }
}
