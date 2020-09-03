using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class Ad
    {

        /*
         *
         * Todo
         *
         * add a isSold prop
         *
         */

        public Ad()
        {
            Photos = new List<Photo>();
            FavAdses = new List<FavAds>();
            AdAndCategories = new List<AdAndCategory>();
        }
        public int AdId { get; set; }
        public string AdTitle { get; set; }
        public string AdInfo { get; set; }
        public double Price { get; set; }
        public DateTime AdDate { get; set; }
        public DateTime AdValidDate { get; set; }
        public string City { get; set; }
        public bool IsSold { get; set; }
        public User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public Category Category { get; set; }
        public ICollection<FavAds> FavAdses { get; set; }
        public ICollection<AdAndCategory> AdAndCategories { get; set; }


    }
}
