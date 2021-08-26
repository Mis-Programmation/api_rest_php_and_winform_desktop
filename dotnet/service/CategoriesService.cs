using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using Newtonsoft.Json;
namespace service
{
    public partial class CategoriesService : ApiService
    {


        public CategoriesService() : base("categories"){}

    
        public IList<Categories> GetAll()
        {
            Console.WriteLine("----------------------------------- Recuperation de categories ------------------------------------");
            return JsonConvert.DeserializeObject<List<Categories>>(base.GetObject().ToString());
        }


        public Categories Add(Categories category)
        {
            Console.WriteLine("----------------------------------- Ajouter categories ------------------------------------");

            var categoryObject = new
            {
                libelle = category.libelle
            };

            return JsonConvert.DeserializeObject<Categories>(base.AddObject(categoryObject).ToString());
        }
    }
}
