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
        void Delete(T e);
        List<T> Get();
        T Get(ID category);
        T Get(Category category, Date date);
    }

    public interface IRepo<T, ID>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> Get();
        List<T> Get(ID id);
    }

    public interface IRepo<T>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> Get();
    }
}
