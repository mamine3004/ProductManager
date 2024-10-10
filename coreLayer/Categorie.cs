using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreLayer
{
    public class Categorie
    {
        int id;
        string libelle;
        List<Product>? products;
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public List<Product>? Products { get => products; set => products = value; }
    }
}
