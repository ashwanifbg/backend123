

using TransactionAPI.Models;
using TransactionAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

//using TaskManagementAPI.Services;
//using TaskManagementAPI.Models;


namespace TransactionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class TransactionController : ControllerBase
    {
        //log code start
       
        ILogger _logger;
        TransactionService _service;
        public TransactionController(TransactionService service,
            ILogger<TransactionController> log)
        {
            _service = service;
            _logger = log;
        }


        /// <summary>
        /// log code end
        /// </summary>



        TransactionService tra = new TransactionService();
        // GET: api/<RestaurantController>
        [HttpGet]
        public Task<List<Transaction>> Get()
        {
            _logger.LogInformation("Get information :" + DateTime.Now.ToString() + Request.Host.Value);
            return tra.GetAllTransactions();
        }

        // GET api/<RestaurantController>/5
        [HttpGet("{id}")]
        public Transaction Get(int id)
        {
            return tra.GetById(id);
        }

        // POST api/<RestaurantController>
        [HttpPost]
        public void Post([FromBody] Transaction r)
        {
            tra.AddTransaction(r);
        }

        // PUT api/<RestaurantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Transaction r)
        {
            tra.UpdateTransaction(id, r);
        }

        // DELETE api/<RestaurantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            tra.DeleteTransaction(id);
        }
    }
}
