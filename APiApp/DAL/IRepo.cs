using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepo<T, ID, Category, Date>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(ID id);
        List<T> Get();
        T Get(ID category);
        T Get(Category category, Date date);
    }
}
