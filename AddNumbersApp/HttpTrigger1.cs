using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using AddNumbersApp;  // Include the namespace where AddNumbers class is located

namespace Company.Function
{
    public class HttpTrigger1
    {
        private readonly ILogger<HttpTrigger1> _logger;

        public HttpTrigger1(ILogger<HttpTrigger1> logger)
        {
            _logger = logger;
        }

        [Function("HttpTrigger1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            // Get parameters from query string
            int num1 = int.TryParse(req.Query["num1"], out int n1) ? n1 : 0;
            int num2 = int.TryParse(req.Query["num2"], out int n2) ? n2 : 0;

            int sum = AddNumbers.AddTwoNumbers(num1, num2);
            //set
            return new OkObjectResult($"The sum is: {sum}");
        }
    }
}
