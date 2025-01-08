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
    public class TwoQuestionController : ControllerBase
    {
        private readonly TwoQuestionServices _twoQuestionServices;
        
        public TwoQuestionController(TwoQuestionServices twoQuestionServices)
        {
            _twoQuestionServices = twoQuestionServices;
        }

        [HttpGet]
        [Route("TwoQuestions/{name}/{wakeTime}")]

        public string GetGreetUser(string name,string wakeTime)
        {
            return _twoQuestionServices.GetGreetUser(name, wakeTime);
        }
        
    }
}