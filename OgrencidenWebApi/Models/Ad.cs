using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class Ad
    {
        public Ad()
        {
            Photos = new List<Photo>();
            FavAdses = new List<FavAds>();
            AdAndCategories = new List<AdAndCategory>();
        }
        public int AdId { get; set; }
        public string AdInfo { get; set; }
        public DateTime AdDate { get; set; }
        public DateTime AdValidDate { get; set; }
        public User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Category Category { get; set; }
        public ICollection<FavAds> FavAdses { get; set; }
        public ICollection<AdAndCategory> AdAndCategories { get; set; }


    }
}
