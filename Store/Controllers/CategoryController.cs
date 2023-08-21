using Microsoft.AspNetCore.Mvc;
using Store.Db;

namespace Store.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
        private StoreDBContext _context;
        public CategoryController(StoreDBContext context)
        {
            _context = context;
        }
        
        
        [HttpGet]
        [Route("create")]
        public void CrearCategories() 
        {
            _context.Categories.Add(new Category() { 
            Name = "Mascotas",
            Description="Comida o articulos paa mascotas",
            });
            _context.Categories.Add(new Category()
            {
                Name = "Lacteos",
                Description = "Leche, queso,etc",
            });
            _context.Categories.Add(new Category()
            {
                Name = "Enbutidos",
                Description = "mortadela, hotdog,etc",
            });
            _context.SaveChanges();
        }

        [HttpGet]
        public List<Category> GetCategories() 
        {
           return _context.Categories.ToList();
        
        }


    }
}
