using api.Application.Commands;
using api.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class CardController : ControllerBase
    {
        // GET: api/<CardController>
        [HttpGet]
        [Route("reader")]
        [SwaggerOperation(
            OperationId = "reader",
            Summary = "Get IDCard Reader Info",
            Description = "Get IDCard Reader Info")]
        public IDCard Get()
        {
            GetCardInfo cardInfo = new GetCardInfo();


            IDCard info = cardInfo.RetrieveCardInfo();


            return info;
        }

        // GET api/<CardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
