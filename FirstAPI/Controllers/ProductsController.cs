using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")] //route for the whole class 
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
           _context = context;

            _context.Database.EnsureCreated();
        }
        [HttpGet]

        //RETURNING MULTIPLE ITEMS WITH STATUS CODE
        public async Task <ActionResult> GetAllProducts()
            
        {
          return Ok(await _context.Products.ToArrayAsync());
        }

        //short cause we already have the base route
        [HttpGet("{id}")]
        public async Task <ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            //error handling that says that stuff is not found
            if (product == null)
            {
                 return NotFound();
            }
            return Ok(product);
        }
        [HttpPost]
        //for sending data too add via post 
        public async Task<ActionResult<Product>>PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetProduct",
                new { id = product.Id },
                product);
        }
    }
}
