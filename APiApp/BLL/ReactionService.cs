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
    public class ReactionService
    {
        public static List<ReactionModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reaction, ReactionModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ReactionDataAcess();
            var data = mapper.Map<List<ReactionModel>>(da.Get());
            return data;
        }

        public static List<ReactionModel> Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Reaction, ReactionModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ReactionDataAcess();
            var data = mapper.Map<List<ReactionModel>>(da.Get(id));
            return data;
        }
    }
}
