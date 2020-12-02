using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EquityController : ControllerBase
    {
        public EquityController()
        {
            
        }

        [HttpGet]
        [Route("getWelcome")]
        [Authorize(Roles = Role.Admin)]
        public string GetAll()
        {
            return "Welcome to equity";
        }
                
    }
}
