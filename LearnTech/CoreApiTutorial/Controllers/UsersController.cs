using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApiTutorial.Models;
using CoreApiTutorial.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiTutorial.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userservice;
        public UsersController(IUserService userservice)
        {
            _userservice = userservice;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]AuthenticateModel model)
        {
            var user = _userservice.Authenticate(model.UserName, model.Password);
            if(user == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            return Ok(user);
        }


        public IActionResult GetAll()
        {
            var users = _userservice.GetAll();
            return Ok(users);
        }

    }
}