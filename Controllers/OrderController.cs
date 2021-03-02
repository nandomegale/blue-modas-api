using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;

namespace Controllers
{

    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Order>>> Get([FromServices] DataContext context)
        {
            var orders = await context.Orders.Include(x => x.client).Include(y => y.items).ToListAsync();
            return orders;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(
            [FromServices] DataContext context,
            int id)
        {
            var order = await context.Orders.Include(x => x.client).Include(y => y.items).FirstOrDefaultAsync(i => i.id == id);
            return order;
        }

        public async Task<ActionResult<Order>> Post([FromServices] DataContext context, [FromBody] Order model)
        {
            if (ModelState.IsValid)
            {
                var client = model.client;
                context.Clients.Add(client);

                List<Item> items = model.items;
                context.Items.AddRange(items);

                context.Orders.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}