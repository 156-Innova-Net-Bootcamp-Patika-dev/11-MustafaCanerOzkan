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
    public class SellerManager : ISellerService
    {
        private ISellerRepository _sellerRepository;

        public SellerManager(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public void Create(Seller entity)
        {
            _sellerRepository.Create(entity);
        }

        public void Delete(Seller entity)
        {
            _sellerRepository.Delete(entity);
        }

        public List<Seller> GetAll()
        {
            return _sellerRepository.GetAll();
        }

        public Seller GetById(int id)
        {
            return _sellerRepository.GetById(id);
        }

        public void Update(Seller entity)
        {
            _sellerRepository.Update(entity);
        }
    }
}
