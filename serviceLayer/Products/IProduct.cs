using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using coreLayer;
namespace serviceLayer.Products
{
    public interface IProduct
    {
        int addProduct(Product po);
        Product FindById(int id);
        List<Product> allProducts();
        Product? updateProduct(Product po, int idp);
        Product? deleteProduct(int idp);
    }
}
