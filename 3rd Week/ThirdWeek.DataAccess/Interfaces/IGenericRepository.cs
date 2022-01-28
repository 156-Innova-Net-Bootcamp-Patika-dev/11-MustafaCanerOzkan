using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdWeek.DataAccess.Interfaces
{
    // Her entity için ayrı ayrı interface'ler tanımlamak yerine  burada tanımladığımız genel bir
    // interface üzerinden, diğer interface'lerin implementasyonunu sağlıyoruz.
    public interface IGenericRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
