using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class FavAds
    {
        public int AdId { get; set; }
        public Ad Ad { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
