using coreLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceLayer.Categories
{
    public interface ICategorie
    {
        int addCategorie(Categorie ct);
        Categorie FindById(int id);
        List<Categorie> allCategories();
        Categorie? updateCategorie(Categorie ct,int idc);
        Categorie? deleteCategorie(int idc);
    }
}
