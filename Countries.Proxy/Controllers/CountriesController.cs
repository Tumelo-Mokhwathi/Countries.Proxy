using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Country.Proxy.Models;

namespace Country.Proxy.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private CountriesDBContext _context = new CountriesDBContext();


        [Produces("application/json")]
        [HttpGet]
        public ActionResult<CountriesResult> GetAreas()
        {
            return new CountriesResult() { countries = _context.Countries.ToArray() };
        }
        private bool CountriesExists(string id)
        {
            return _context.Countries.Any(e => e.Id == id);
        }
    }
}