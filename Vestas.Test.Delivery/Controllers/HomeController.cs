using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IDeliveryPointService _service;

        public HomeController(IDeliveryPointService service)
        {
            _service = service;
        }

        [HttpGet("shortdistance/{pointA}/{pointB}")]
        public IActionResult Get(char pointA, char pointB)
        {
            return new JsonResult(new { Count = _service.GetShortDistance(pointA, pointB)});
        }
    }
}