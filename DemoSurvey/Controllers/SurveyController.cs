using Microsoft.AspNetCore.Mvc;

namespace DemoSurvey.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurveyController : ControllerBase
    {
        private readonly ILogger<SurveyController> _logger;

        public SurveyController(ILogger<SurveyController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "answer")]
        public IActionResult SurveyReply([FromBody] dynamic answer)
        {
            try
            {
                // Procesa la respuesta de la encuesta aquí (por ejemplo, guarda en la base de datos)
                //Console.WriteLine($"Respuesta recibida: ${answer}");
                System.Diagnostics.Trace.TraceInformation($"Respuesta recibida: ${answer}");
                return Ok(new { mensaje = "Answer received successfully" });
            }
            catch (Exception ex) {
                //Console.WriteLine($"Error: ${ex.Message}");
                System.Diagnostics.Trace.TraceError($"Respuesta recibida: ${answer}");
                return BadRequest("answer is null");
            }
        }
    }
}
