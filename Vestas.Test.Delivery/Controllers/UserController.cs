using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            await _service.Add(user);

            return Created("", user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(User user)
        {
            await _service.Update(user);

            return Accepted();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.Delete(id);

            return Accepted();
        }
    }
}