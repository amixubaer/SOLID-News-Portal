using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        public static List<CategoryModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CategoryDataAcess();
            var data = mapper.Map<List<CategoryModel>>(da.Get());
            return data;
        }

        public static void Add(CategoryModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(n);
            DataAccessFactory.CategoryDataAcess().Add(data);
        }


        public static void Edit(CategoryModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(n);
            DataAccessFactory.CategoryDataAcess().Edit(data);
        }

        public static void Delete(CategoryModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CategoryModel, Category>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(n);
            DataAccessFactory.CategoryDataAcess().Delete(data);
        }
    }
}
