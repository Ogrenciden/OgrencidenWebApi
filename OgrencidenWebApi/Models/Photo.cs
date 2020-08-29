using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public DateTime PhotoAddedDate { get; set; }
        public DateTime PhotoValidDate { get; set; }
        public Ad Ad { get; set; }

    }
}
