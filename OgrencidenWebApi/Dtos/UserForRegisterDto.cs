using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Dtos
{
    public class UserForRegisterDto
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
