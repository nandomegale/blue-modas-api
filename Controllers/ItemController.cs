using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace Controllers
{

    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Item>>> Get([FromServices] DataContext context)
        {
            var items = await context.Items.ToListAsync();
            return items;
        }

    }
}