using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFourEndPoints.services
{
    public class TwoQuestionServices
    {

        public string GetGreetUser(string name, string wakeTime)
        {
            string response = $"Hey {name}. You woke up at {wakeTime}.";
            return response;
    }
}
}