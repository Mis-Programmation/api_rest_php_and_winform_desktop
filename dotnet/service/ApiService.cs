using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using model;
namespace service
{
    abstract public partial class ApiService 
    {

        protected static readonly string baseUrl = "https://localhost:8000/api/";
        protected String route;
        protected HttpClient httpClient = null;
    
        protected ApiService(String route)
        {
            httpClient = new HttpClient();
            this.route = route;
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }


        protected String GetObject(int ?id = null)
        {


            String url = baseUrl + this.route;
            url += id != null ? "/" + id : String.Empty;

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(baseUrl +this.route).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseData = response.Content.ReadAsStringAsync().Result;
                    return responseData;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            return null;

        }


        protected String AddObject(Object o)
        {

            var json = JsonConvert.SerializeObject(o);

            var content = new StringContent(json,Encoding.UTF8,"application/json");
       
            try
            {
           
                HttpResponseMessage response = httpClient.PostAsync(baseUrl + this.route,content).Result;
               
                if (response.IsSuccessStatusCode)
                {
                    var responseData = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(responseData);
                    return responseData;
                }
                else
                {
                    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("ssssssssssssssssssssssssss");
                return null; ;
            }

            return null;

        }

        protected bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<object> getAll()
        {
            throw new NotImplementedException();
        }

        public object update(object o)
        {
            throw new NotImplementedException();
        }
    }
}
