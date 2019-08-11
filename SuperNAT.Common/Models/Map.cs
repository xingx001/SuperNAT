﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNAT.Common.Models
{
    [Table("map")]
    public class Map
    {
        [Key]
        public int id { get; set; }
        public string local { get; set; }
        public string remote { get; set; }
        public string protocol { get; set; }
        public string certfile { get; set; }
        public string certpwd { get; set; }
        public int ssl_type { get; set; }
        public int user_id { get; set; }
    }
}