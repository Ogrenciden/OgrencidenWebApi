using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrencidenWebApi.Dtos
{
    public class UserForLoginDto
    {
        public string EMail { get; set; }
        public string password { get; set; }
    }
}
