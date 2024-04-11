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
        /// <summary>
        /// Gets all F1 products.
        /// </summary>
        [HttpGet]

        //RETURNING MULTIPLE ITEMS WITH STATUS CODE
        //Responsible for returning Products
        // use of ASYNC and AWAIT for multithreading / performance
        public async Task<ActionResult> GetAllProducts()

        {
            return Ok(await _context.Products.ToArrayAsync());
        }


        /// <summary>
        /// Gets data based on id.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            //error handling that says that stuff is not found
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// Post F1 Data
        /// </summary>
        [HttpPost]
        //for sending data too add via post 
        //
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetProduct",
                new { id = product.Id },
                product);
        }
        /// <summary>
        /// update F1 data details 
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> PutProduct(int id, [FromBody] Product updatedProduct)
        {
            var existingProduct = await _context.Products.FindAsync(id);

            if (existingProduct == null)
            {
                return NotFound(); // Return a 404 Not Found response if the product doesn't exist
            }

            // Update the existing product properties with the data from updatedProduct
            existingProduct.DriverName = updatedProduct.DriverName;
            existingProduct.TeamName = updatedProduct.TeamName;
            existingProduct.CarDescription = updatedProduct.CarDescription;
            existingProduct.FastestTime = updatedProduct.FastestTime;
            existingProduct.Contractvalid = updatedProduct.Contractvalid;
            existingProduct.CategoryId = updatedProduct.CategoryId;
          

            // Save changes to the database
            await _context.SaveChangesAsync();

            return Ok(existingProduct); // Return a 200 OK response with the updated product
        }

        //[HttpDelete("{id}")]

        //public async Task<Ac>
    }
}
