using coreLayer;
using dataLayer;
using Microsoft.EntityFrameworkCore;
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
            List<Product> products = _context.products.Include(p => p.Categorie).ToList();
            return products;
        }

        public Product? deleteProduct(int idp)
        {
            Product? productModel = _context.products.FirstOrDefault(x => x.Id == idp);
            if (productModel == null)
            {
                return null;
            }
            _context.products.Remove(productModel);

            _context.SaveChanges();

            return productModel;
        }

        public Product FindById(int id)
        {
            Product p = _context.products.Include(p => p.Categorie).FirstOrDefault(p => p.Id == id);
            return p;
        }

        public Product? updateProduct(Product po, int idp)
        {
            Product? productModel = _context.products.Include(p => p.Categorie).FirstOrDefault(x => x.Id == idp);
            if (productModel == null)
            {
                return null;
            }
            productModel.Designation = po.Designation;
            productModel.Qte = po.Qte;
            productModel.Prix = po.Prix;

            _context.SaveChanges();
            return productModel;
        }
    }
}
