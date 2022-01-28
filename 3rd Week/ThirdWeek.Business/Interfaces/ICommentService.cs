using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekModel.Entities;

namespace ThirdWeek.Business.Interfaces
{
    // Metot imzalarını tanımlıyoruz.
    public interface ICommentService
    {
        List<Comment> GetAll();

        Comment GetById(int id);

        void Create(Comment entity);

        void Update(Comment entity);

        void Delete(Comment entity);
    }
}
