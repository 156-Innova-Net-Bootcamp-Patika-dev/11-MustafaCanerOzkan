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
    public class ProductController : ControllerBase
    {
        // Dependency injection kullanarak bağımlılığı en aza indirgiyoruz.
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _productService.GetAll();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public void PostProduct([FromBody] Product entity)
        {
            _productService.Create(entity);
        }

        [HttpPut]
        public void PutProduct([FromBody] Product entity)
        {
            _productService.Update(entity);
        }

        [HttpDelete("{id}")]
        public void DeleteProduct(Product entity)
        {
            _productService.Delete(entity);
        }
    }
}
