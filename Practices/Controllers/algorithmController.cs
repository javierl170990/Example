using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class algorithmController : ControllerBase
    {
        private readonly IAlgorithmService _ialgorithmService;
        public algorithmController(IAlgorithmService algorithmService)
        {
            _ialgorithmService = algorithmService;
        }

        [HttpGet("KadanesAlgoritm")]
        public IActionResult Kadanse(int[] Arr) 
        {
            return Ok(_ialgorithmService.KadanesAlgorithm(Arr));
        }

       

    }
}
