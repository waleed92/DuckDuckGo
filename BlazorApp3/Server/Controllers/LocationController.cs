using BlazorApp3.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp3.Server.Controllers
{
    [ApiController]
    [Route("api/Location")]
    public class LocationController : ControllerBase
    {
       
        private readonly ILogger<LocationController> _logger;


        public static HttpClient httpClient = new HttpClient();

        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync(string searchText)
        {
            var client = httpClient;
            var result = await client.GetStringAsync(string.Format(Data.ServiceEndPoint, searchText, Data.authCode));
            return Ok(result);

        }
    }
}