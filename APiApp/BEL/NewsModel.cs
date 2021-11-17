using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class NewsModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Headline { get; set; }
        public string Details { get; set; }
        public System.DateTime Date { get; set; }
        public int AdminId { get; set; }
    }
}
