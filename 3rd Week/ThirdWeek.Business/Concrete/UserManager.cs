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
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User entity)
        {
            _userRepository.Create(entity);
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
