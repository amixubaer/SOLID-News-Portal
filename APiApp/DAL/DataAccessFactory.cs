using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static NPEntities db;
        static DataAccessFactory()
        {
            db = new NPEntities();
        }
        public static IRepo<News, int, string, DateTime> NewsDataAcess()
        {
            return new NewsRepo(db);
        }

        public static IRepo<Category> CategoryDataAcess()
        {
            return new CategoryRepo(db);
        }

        public static IRepo<Comment, int> CommentDataAcess()
        {
            return new CommentRepo(db);
        }

        public static IRepo<Reaction, int> ReactionDataAcess()
        {
            return new ReactionRepo(db);
        }




    }
}
