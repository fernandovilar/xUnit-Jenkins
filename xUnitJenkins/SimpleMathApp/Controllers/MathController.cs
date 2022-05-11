using Microsoft.AspNetCore.Mvc;
using SimpleMathLib;

namespace SimpleMathApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        private readonly ILogger<MathController> _logger;
        private readonly IMath math;

        public MathController(ILogger<MathController> logger, IMath math)
        {
            _logger = logger;
            this.math = math;
        }

        [HttpGet(Name = "Sum")]
        public double GetSum(double a, double b)
        {
            this._logger.Log(LogLevel.Debug, $"GetSum({a}, {b})");

            return this.math.Sum(a, b);
        }
    }
}