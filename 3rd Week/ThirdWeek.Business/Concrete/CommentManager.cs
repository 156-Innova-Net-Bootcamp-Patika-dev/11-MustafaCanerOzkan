using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeek.Business.Interfaces;
using ThirdWeek.DataAccess.Interfaces;
using ThirdWeekModel.Entities;

namespace ThirdWeek.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void Create(Comment entity)
        {
            _commentRepository.Create(entity);
        }

        public void Delete(Comment entity)
        {
            _commentRepository.Delete(entity);
        }

        public List<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public void Update(Comment entity)
        {
            _commentRepository.Update(entity);
        }
    }
}
