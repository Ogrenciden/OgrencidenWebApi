using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Ad> Ads { get; set; }
        public ICollection<AdAndCategory> AdAndCategories { get; set; }
    }
}
