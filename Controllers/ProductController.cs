using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;
using System.IO;
using Newtonsoft.Json;

namespace Controllers
{

    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)         
        {             
            List<Product> products = await context.Products.ToListAsync();   
            if(products.Count == 0) {
                using (StreamReader r = new StreamReader("./mock/products.json")){
                    string json = r.ReadToEnd();
                    products = JsonConvert.DeserializeObject<List<Product>>(json);
                    context.Products.AddRange(products);
                    await context.SaveChangesAsync();
                }
            }          
            return products;         
        }
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post([FromServices] DataContext context, [FromBody] Product model)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(model);
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