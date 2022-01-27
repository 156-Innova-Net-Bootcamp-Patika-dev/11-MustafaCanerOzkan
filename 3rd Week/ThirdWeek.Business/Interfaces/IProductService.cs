using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdWeekModel.Entities;

namespace ThirdWeek.Business.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        void Create(Product entity);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
