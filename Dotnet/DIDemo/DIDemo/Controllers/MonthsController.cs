using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MonthsController : ControllerBase
    {
 
        [Route("month")]
        public JsonResult GetString()
        {
            string fullMonthName1 = new DateTime(2022, 1, 1).ToString("MMM");
            string fullMonthName2 = new DateTime(2022, 2, 1).ToString("MMM");
            string mm = fullMonthName1 +" "+ fullMonthName2;

            return new JsonResult(mm);
        }
    }
}
