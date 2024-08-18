using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFDemo.Models;
using EFDemo.Services;



namespace EFDemo.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
    public class CommentController : ControllerBase
    {


        ILogger _logger;
        CommentService _service;
        public CommentController(CommentService service,
            ILogger<CommentController> log)
        {
            _service = service;
            _logger = log;
        }



        CommentService tra = new CommentService();
        // GET: api/<RestaurantController>
        [HttpGet]
        public Task<List<Comment>> Get()
        {
            _logger.LogInformation("Get information :" + DateTime.Now.ToString() + Request.Host.Value);
            return tra.GetAllComment();
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Comment Get(int id)
        {
            return tra.GetById(id);
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] Comment r)
        {
            tra.AddComment(r);
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Comment r)
        {
            tra.UpdateComment(id, r);
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tra.DeleteComment(id);
        }
    }
}
