using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwoToFourEndPoints.services;

namespace TwoToFourEndPoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LessOrGreaterController : ControllerBase
    {
        
        private readonly LessOrGreaterServices _lessOrGreaterServices;

        public LessOrGreaterController(LessOrGreaterServices lessOrGreaterServices)
        {
            _lessOrGreaterServices = lessOrGreaterServices;
        }

        [HttpGet]
        [Route("GreaterLess/{num1}/{num2}")]

        public string BiggerThanLessThan(int num1, int num2)
        {
            return _lessOrGreaterServices.BiggerThanLessThan(num1, num2);
        }
    }
}