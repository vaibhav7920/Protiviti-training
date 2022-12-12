using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenController : ControllerBase
    {
        [Route("evennum")]
        public JsonResult GetString()
        {
            List<int> even = new List<int>();
            for(int i = 2; i <= 100; i=i+2)
            {
                even.Add(i);
            }
            return new JsonResult(even);
        }
    }
}
