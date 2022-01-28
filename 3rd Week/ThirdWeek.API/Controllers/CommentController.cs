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
    public class CommentController : ControllerBase
    {
        // Dependency injection kullanarak bağımlılığı en aza indirgiyoruz.
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public List<Comment> GetComments()
        {
            return _commentService.GetAll();
        }

        [HttpGet("{id}")]
        public Comment GetComment(int id)
        {
            return _commentService.GetById(id);
        }

        [HttpPost]
        public void PostComment([FromBody] Comment entity)
        {
            _commentService.Create(entity);
        }

        [HttpPut]
        public void PutComment([FromBody] Comment entity)
        {
            _commentService.Update(entity);
        }

        [HttpDelete("{id}")]
        public void DeleteComment(Comment entity)
        {
            _commentService.Delete(entity);
        }
    }
}
