using SearchApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApp.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ServiceContext _context;
       
        public ServiceRepository(ServiceContext context)
        {
            _context = context;
        }
        
        public SearchResultDto GetSearchResult(SearchDto search)
        {
            var services = _context.GetServices(search);
            List<ServiceItemResult> results = new List<ServiceItemResult>();
            
            foreach (var item in services)
            {
                var dist = Common.Distance(new Position { Lat = search.Lat, Lng = search.Lng }, item.Position);

                results.Add(new ServiceItemResult
                {
                    Id = item.Id,
                    Name = item.Name,
                    Position = item.Position,
                    Distance = dist >= 1000 ? (dist / 1000).ToString("0.00") + "km" : dist.ToString("0.00") + "m",
                    Score = Common.ComputeDistance(search.Name, item.Name)
                });
            }
            return new SearchResultDto()
            {
                TotalDocuments = _context.Count(),
                TotalHits = results.Count(),
                Results = results
            };         
        }
    }
}
