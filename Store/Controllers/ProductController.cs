using Microsoft.AspNetCore.Mvc;
using Store.Db;

namespace Store.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private StoreDBContext _context;
        public ProductController(StoreDBContext context)
        {
            _context = context;
        }
        
        
        [HttpGet]
        public List<Product> GetProducts() 
        {
           return _context.Products.ToList();
        
        }


        [HttpPost]
        public void PostProducts(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        [HttpPut]
        public void PutProducts(Product product) 
        {
        _context.Products.Update(product);

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteProducts(int id)
        {
            _context.Remove(id);

            _context.SaveChanges();

        
        }

    }
}
