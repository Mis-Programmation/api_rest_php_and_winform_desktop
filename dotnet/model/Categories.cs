using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Categories
    {

        public int id { set; get; }
        public String libelle { set; get; }
        public System.DateTime? createdAt { get; set; }

        // private List<Product> products { set; get; }

    }
}
