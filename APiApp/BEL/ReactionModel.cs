﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ReactionModel
    {
        public int Id { get; set; }
        public string React { get; set; }
        public int NewsId { get; set; }
        public int UserId { get; set; }
    }
}
