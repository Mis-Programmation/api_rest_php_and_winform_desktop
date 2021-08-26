using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using Newtonsoft.Json;
namespace service
{
    class ProduitService : ApiService
    {

        public ProduitService() : base("products") { }


        public IList<Product> GetAll()
        {
            Console.WriteLine("----------------------------------- Recuperation des produit ------------------------------------");
            return JsonConvert.DeserializeObject<List<Product>>(base.GetObject().ToString());
        }

    }
}
