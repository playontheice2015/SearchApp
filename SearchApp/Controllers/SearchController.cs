using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SearchApp.Models;
using SearchApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace SearchApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {

        private readonly IServiceRepository _serviceRepository;
        public SearchController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        } 

        //[HttpGet, ValidateAntiForgeryToken]
        [HttpGet]
        public ActionResult<string> GetName([FromQuery] SearchDto search)
        {
            return JsonConvert.SerializeObject(_serviceRepository.GetSearchResult(search));
        }
    }
}
