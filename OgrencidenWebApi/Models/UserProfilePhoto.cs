using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Models
{
    public class UserProfilePhoto
    {

        [Key]
        public int PhotoId { get; set; }
        public string ProfilePhotoUrl { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

    }
}
