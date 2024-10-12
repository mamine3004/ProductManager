using coreLayer;
using Microsoft.AspNetCore.Mvc;
using serviceLayer.Categories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {
        private ICategorie categorieService;

        public CategorieController(ICategorie categorieService)
        {
            this.categorieService = categorieService;
        }

        // GET: api/<CategorieController>

        [HttpGet]
        public IEnumerable<Categorie> Get()
        {
            return categorieService.allCategories();
        }

        // GET api/<CategorieController>/5
        [HttpGet("{id}")]
        public Categorie Get(int id)
        {
            return categorieService.FindById(id);
        }

        // POST api/<CategorieController>
        [HttpPost]
        public int CreateCategorie([FromBody] Categorie ct)
        {
            int nb = categorieService.addCategorie(ct);
            return nb;
        }

        //// PUT api/<CategorieController>/5
        [HttpPut("{id}")]
        public Categorie? Put(int id, [FromBody] Categorie ct)
        {
            return categorieService.updateCategorie(ct, id);
        }

        //// DELETE api/<CategorieController>/5
        [HttpDelete("{id}")]
        public Categorie? Delete(int id)
        {
            return categorieService.deleteCategorie(id);
        }
    }
}
