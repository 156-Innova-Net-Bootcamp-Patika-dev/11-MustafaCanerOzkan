using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        private static List<Company> Companies = new List<Company>()
        {
            new Company {Id=1, Name="Microsoft", Description="Microsoft Corporation is an American multinational technology corporation which produces computer software, consumer electronics, personal computers, and related services.", Country="USA", FoundingDate="April 4, 1975"},
            new Company {Id=2, Name="Meta", Description="Meta Platforms, also known as Meta and formerly known as Facebook, is a multinational technology conglomerate based in Menlo Park, California. The company is the parent organization of Facebook, Instagram, and WhatsApp, among other subsidiaries.", Country="USA", FoundingDate="January 4, 2004"},
            new Company {Id=3, Name="SAP", Description="SAP is a German multinational software corporation based in Walldorf, Baden-Württemberg, that develops enterprise software to manage business operations and customer relations.", Country="Germany", FoundingDate="April 1, 1972"},
            new Company {Id=4, Name="CD Projekt", Description="CD Projekt is the largest Polish video game developer, publisher and distributor based in Warsaw, founded in May 1994 by Marcin Iwiński and Michał Kiciński.", Country="Poland", FoundingDate="1994"},
        };


        [HttpGet]
        public List<Company> Get()
        {
            var _companies = Companies.ToList();
            return _companies;
        }

        [HttpGet("{id}")]
        public Company Get(int id)
        {
            var _companies = Companies.SingleOrDefault(x => x.Id == id);
            return _companies;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Company newCompany)
        {
            if (newCompany == null) { return BadRequest("Opps..."); }

            Companies.Add(newCompany);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Company updateCompany)
        {
            var _company = Companies.SingleOrDefault(x => x.Id == id);
            if (_company == null) { return BadRequest("Opps..."); }

            _company.Name = updateCompany.Name;
            _company.Description = updateCompany.Description;
            _company.Country = updateCompany.Country;
            _company.FoundingDate = updateCompany.FoundingDate;
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _company = Companies.SingleOrDefault(x => x.Id == id);
            if (_company == null) { return BadRequest("Opps..."); }

            Companies.Remove(_company);
            return Ok();
        }

    }
}
