using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Repository.IRepository
{
    public interface IBaseRepo<T> where T :class
    {
        Task<List<T>> GetList(string url);
        Task<T> Get(string url);
    }
}
