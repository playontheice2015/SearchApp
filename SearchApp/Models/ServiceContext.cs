using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApp.Models
{
    public class ServiceContext
    {

        private readonly List<ServiceItem> Services = new List<ServiceItem>();
        public ServiceContext() 
        {
            var webClient = new System.Net.WebClient();
            var json = webClient.DownloadString(@"../SearchApp/data.json");
            Services = JsonConvert.DeserializeObject<List<ServiceItem>>(@json);
        }
        public List<ServiceItem> GetServices(SearchDto search)
        {
            return Services.Where(x => x.Name.Contains(search.Name))?.ToList();           
        }

        public int Count()
        {
            return Services.Count();
        }
    }
}

