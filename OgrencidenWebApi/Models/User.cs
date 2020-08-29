using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<Ad> Ads { get; set; }
        public ICollection<FavAds> FavAdses { get; set; }
        public UserProfilePhoto UserProfilePhoto { get; set; }
    }
}
