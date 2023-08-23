using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class SubAbout
    {
        [Key]
        public int SubAboutID { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
    }
}
