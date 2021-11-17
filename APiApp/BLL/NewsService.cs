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
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                //c.CreateMap<Department, DepartmentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NewsDataAcess();
            var data = mapper.Map<List<NewsModel>>(da.Get());
            return data;
        }
        
        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            DataAccessFactory.NewsDataAcess().Add(data);
        }
    }
}
