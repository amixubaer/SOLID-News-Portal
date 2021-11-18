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
    public class CommentService
    {
        public static List<CommentModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CommentDataAcess();
            var data = mapper.Map<List<CommentModel>>(da.Get());
            return data;
        }

        public static List<CommentModel> Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Comment, CommentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.CommentDataAcess();
            var data = mapper.Map<List<CommentModel>>(da.Get(id));
            return data;
        }
    }
}
