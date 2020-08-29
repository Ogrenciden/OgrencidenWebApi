using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class AdAndCategory
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AdId { get; set; }
        public Ad Ad { get; set; }
    }
}
