using ExampleApi.ApiClients;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetCsvFileController : ControllerBase
    {
        private readonly ICsvApiClient _csvApiClient;

        public GetCsvFileController(ICsvApiClient csvApiClient)
        {
            _csvApiClient = csvApiClient;
        }
    }
}