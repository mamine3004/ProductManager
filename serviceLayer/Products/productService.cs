using coreLayer;
using dataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceLayer.Products
{
    public class productService : IProduct
    {
        ProductContext _context;

        public productService(ProductContext context)
        {
            _context = context;
        }

        public int addProduct(Product po)
        {
            _context.products.Add(po);
            int nb = _context.SaveChanges();
            return nb;
        }

        public List<Product> allProducts()
        {
            List<Product> products = _context.products.ToList();
            return products;
        }

        public Product deleteProduct(int idp)
        {
            throw new NotImplementedException();
        }

        public Product FindById(int id)
        {
            Product p = _context.products.FirstOrDefault(p => p.Id == id);
            return p;
        }

        public int updateProduct(Product po, int idp)
        {
            throw new NotImplementedException();
        }
    }
}
