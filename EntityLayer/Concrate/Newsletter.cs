﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Newsletter
    {
        [Key]
        public int NewletterID { get; set; }
        public string Mail { get; set; }
    }
}
