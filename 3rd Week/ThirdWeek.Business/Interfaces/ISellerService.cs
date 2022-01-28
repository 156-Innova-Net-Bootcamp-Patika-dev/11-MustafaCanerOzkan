using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekModel.Entities;

namespace ThirdWeek.Business.Interfaces
{
    // Metot imzalarını tanımlıyoruz.
    public interface ISellerService
    {
        List<Seller> GetAll();

        Seller GetById(int id);

        void Create(Seller entity);

        void Update(Seller entity);

        void Delete(Seller entity);
    }
}
