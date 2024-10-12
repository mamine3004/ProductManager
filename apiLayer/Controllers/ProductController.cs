using coreLayer;
using Microsoft.AspNetCore.Mvc;
using serviceLayer.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProduct productService;

        public ProductController(IProduct productService)
        {
            this.productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productService.allProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productService.FindById(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public int CreateProduct([FromBody] Product po)
        {
            return productService.addProduct(po);
        }

        //// PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public Product? Put(int id, [FromBody] Product po)
        {
            return productService.updateProduct(po,id);
        }

        //// DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public Product? Delete(int id)
        {
            return productService.deleteProduct(id);
        }
    }
}
