using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Models
{
    public interface IDao<T>
    {
        T Add(T toSave);

        T Update(T toSave);

        void Delete(Guid toDelete);

        T GetOne(Guid toGet);

        List<T> GetAll();
    }
}
