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
    public class PostController:ControllerBase
    {
        [HttpPost]
        public Post Post([FromBody] Post toSave,
                         [FromServices] PostDao dao)
        {
            return dao.Add(toSave);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Post>> Get([FromServices] PostDao dao)
        {
            return dao.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Post> GetOne([FromServices] PostDao dao, Guid id)
        {
            return dao.GetOne(id);
        }

        [HttpGet("byuser/{id}")]
        public ActionResult<IEnumerable<Post>> GetByUser([FromServices] PostDao dao, Guid id)
        {
            return dao.GetByUser(id);
        }
    }
}
