using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Entities;
using WebApi.Models;
using MySql.Data.MySqlClient;
using System;

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
        [Route("getAdmin")]
        [Authorize(Roles = Role.Admin)]
        public string GetAdmin()
        {
            return "Welcome to Admin";
        }

        [HttpGet]
        [Route("getUser")]
        [Authorize(Roles = Role.User)]
        public string GetUser()
        {
            return "Welcome to User";
        }

    }
}
