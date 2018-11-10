using controlepesoapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController:ControllerBase
    {
        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public User Post([FromBody] User toSave,
                         [FromServices] UserDao dao)
        {
            return dao.Add(toSave);
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get([FromServices] UserDao dao)
        {
            return dao.GetAll();
        }
    }
}
