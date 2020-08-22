using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrelloTasker.Model.DTO;


namespace TrelloTasker.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrelloWebhookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnWebhookCallBack(TrelloWebhookDTO trelloWebhookDTO)
        {
            
            //Este metodo inicia cuando se cambia algo en trello, y nos avisa por aca.
            if(trelloWebhookDTO.action.data.card.name.EndsWith("Bi-daily"))
            return new OkObjectResult(trelloWebhookDTO);
            throw new NotImplementedException();
        }
    }
}