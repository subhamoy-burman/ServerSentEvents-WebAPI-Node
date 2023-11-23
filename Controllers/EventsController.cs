using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventSource.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpGet]
        public async Task Get()
        {
            var response = Response;
            response.Headers.Add("Content-Type", "text/event-stream");

            for (var i = 0; true; i++)
            {
                await response.WriteAsync($"data: Controller action invoked at: {DateTime.Now}\n\n");
                response.Body.Flush();
                await Task.Delay(10000);
            }
        }
    }
}
