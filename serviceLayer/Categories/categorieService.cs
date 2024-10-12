using coreLayer;
using dataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
            List<Categorie> categories = _context.categories.Include(p => p.Products).ToList();
            return categories;
        }

        public Categorie? deleteCategorie(int idc)
        {
            Categorie? categorieModel = _context.categories.FirstOrDefault(x => x.Id == idc);
            if (categorieModel == null)
            {
                return null;
            }
            _context.categories.Remove(categorieModel);

            _context.SaveChanges();

            return categorieModel;
        }

        public Categorie FindById(int id)
        {
            Categorie c = _context.categories.Include(p => p.Products).FirstOrDefault(c=>c.Id==id);
            return c;

        }

        public Categorie? updateCategorie(Categorie ct, int idc)
        {
            Categorie? categorieModel = _context.categories.Include(p => p.Products).FirstOrDefault(x => x.Id == idc);
            if (categorieModel == null)
            {
                return null;
            }
            categorieModel.Libelle = ct.Libelle;

            _context.SaveChanges();
            return categorieModel;
        }
    }
}
