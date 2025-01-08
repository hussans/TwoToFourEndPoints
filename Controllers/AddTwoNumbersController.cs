using Microsoft.AspNetCore.Mvc;
using TwoToFourEndPoints.services;

namespace TwoToFourEndPoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;

        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices)
        {
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("Sum/{num1}/{num2}")]

        public string GetSumOfTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersServices.GetSum(num1, num2);
        }

    }
}