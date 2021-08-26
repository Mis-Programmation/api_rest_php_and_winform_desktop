using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Product
    {
        public int id { get; set; }
        public string designation { get; set; }
        public string libelle { get; set; }
        public double pu { get; set; }
        public Categories category { get; set; }
        public System.DateTime datePeremption { get; set; }
        public System.DateTime ?createdAt { get; set; }
    }
}
