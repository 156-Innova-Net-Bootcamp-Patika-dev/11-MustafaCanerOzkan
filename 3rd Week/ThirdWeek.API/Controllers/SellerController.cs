using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdWeek.Business.Interfaces;
using ThirdWeekModel.Entities;

namespace ThirdWeek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        // Dependency injection kullanarak bağımlılığı en aza indirgiyoruz.
        private readonly ISellerService _sellerService;

        public SellerController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        [HttpGet]
        public List<Seller> GetSellers()
        {
            return _sellerService.GetAll();
        }

        [HttpGet("{id}")]
        public Seller GetSeller(int id)
        {
            return _sellerService.GetById(id);
        }

        [HttpPost]
        public void PostSeller([FromBody] Seller entity)
        {
            _sellerService.Create(entity);
        }

        [HttpPut]
        public void PutSeller([FromBody] Seller entity)
        {
            _sellerService.Update(entity);
        }

        [HttpDelete("{id}")]
        public void DeleteSeller(Seller entity)
        {
            _sellerService.Delete(entity);
        }
    }
}
