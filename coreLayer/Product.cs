using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreLayer
{
    public class Product
    {
        int id;
        string designation;
        float prix;
        int qte;
        Categorie? categorie;

        public int Id { get => id; set => id = value; }
        public string Designation { get => designation; set => designation = value; }
        public float Prix { get => prix; set => prix = value; }
        public int Qte { get => qte; set => qte = value; }
        public Categorie? Categorie { get => categorie; set => categorie = value; }
    }
}
