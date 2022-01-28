using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekModel.Entities;

namespace ThirdWeek.Business.Interfaces
{
    // Metot imzalarını tanımlıyoruz.
    public interface IUserService
    {
        List<User> GetAll();

        User GetById(int id);

        void Create(User entity);

        void Update(User entity);

        void Delete(User entity);
    }
}
