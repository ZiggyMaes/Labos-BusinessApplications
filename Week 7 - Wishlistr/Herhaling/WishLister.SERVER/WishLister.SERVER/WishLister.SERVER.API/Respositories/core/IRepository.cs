using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wishlistr.API.Models;

namespace Wishlistr.API.Respositories.core
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Save(T item);
        void Edit(T item);
        void Delete(T item);

        void Add(T item);

    }
}
