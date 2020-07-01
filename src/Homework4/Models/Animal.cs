using Homework4.Enums;
using Homework4.Interfaces;
using System;

namespace Homework4.Models
{
    class Animal{

        private readonly Guid _id = Guid.NewGuid();
       
        public string Name { get; set; }
        public Taxonomic TaxonomikClass { get; set; }
        public string Variety { get; set; }

        public Animal()
        {
            Variety = "nonvariety";
            Name = "noname";
            TaxonomikClass = Taxonomic.None;
            _id.ToString();
        }

        public Animal(string variety)
        {
            Variety = variety;
        }

        public Animal(string variety, string name)
        {
            Name = name;
            Variety = variety;
        }
        public Animal(string variety, string name, Taxonomic taxonomikClass)
        {
            Name = name;
            TaxonomikClass = taxonomikClass;
            Variety=variety;
        }
        public Guid Getid() {
            return _id;
        }
    };
}
