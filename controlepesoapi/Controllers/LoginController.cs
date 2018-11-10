using controlepesoapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController:ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<User> Login([FromServices] UserDao dao,
                                        [FromBody] User toLogin)
        {
            return dao.Auth(toLogin);
        }
    }
}
