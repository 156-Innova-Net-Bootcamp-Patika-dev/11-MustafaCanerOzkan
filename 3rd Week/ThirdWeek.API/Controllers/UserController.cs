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
    public class UserController : ControllerBase
    {
        // Dependency injection kullanarak bağımlılığı en aza indirgiyoruz.
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public void PostUser([FromBody] User entity)
        {
            _userService.Create(entity);
        }

        [HttpPut]
        public void PutUser([FromBody] User entity)
        {
            _userService.Update(entity);
        }

        [HttpDelete("{id}")]
        public void DeleteUser(User entity)
        {
            _userService.Delete(entity);
        }
    }
}
