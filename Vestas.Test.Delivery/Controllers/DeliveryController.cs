using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryPointService _service;

        public DeliveryController(IDeliveryPointService service)
        {
            _service = service;
        }

        [HttpGet("shortdistance/{pointA}/{pointB}")]
        public IActionResult Get(char pointA, char pointB)
        {
            return Ok(new { Time = _service.GetShortDistance(pointA, pointB)});
        }

        [HttpGet]
        public IActionResult GetPoints()
        {
            return Ok(_service.GetPoints());
        }

        [HttpGet("{node}")]
        public IActionResult GetPointsByNode(char node)
        {
            return Ok(_service.GetPointsByNode(node));
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePoint(DeliveryPoint point)
        {
           await _service.UpdatePoint(point);

            return Accepted();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePoint(DeliveryPoint point)
        {
            await _service.CreatePoint(point);
            
            return Created($"/GetPointsByNode/{point.Origin}", point);
        }

        [HttpDelete("{pointA}/{pointB}")]
        public async Task<IActionResult> DeletePoint(char pointA, char pointB)
        {
            await _service.DeletePoint(pointA, pointB);

            return Accepted();
        }
    }
}