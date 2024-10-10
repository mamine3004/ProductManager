using coreLayer;
using dataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceLayer.Categories
{
    public class categorieService : ICategorie
    {
        ProductContext _context;

        public categorieService(ProductContext context)
        {
            _context = context;
        }

        public int addCategorie(Categorie ct)
        {
            _context.categories.Add(ct);
            int nb = _context.SaveChanges();
            return nb;
        }

        public List<Categorie> allCategories()
        {
            List<Categorie> categories = _context.categories.ToList();
            return categories;
        }

        public int deleteCategorie(int idc)
        {
            throw new NotImplementedException();
        }

        public Categorie FindById(int id)
        {
            Categorie c = _context.categories.FirstOrDefault(c=>c.Id==id);
            return c;

        }

        public int updateCategorie(Categorie ct, int idc)
        {
            throw new NotImplementedException();
        }
    }
}
