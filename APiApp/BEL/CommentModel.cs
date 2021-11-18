using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Comment1 { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
    }
}
