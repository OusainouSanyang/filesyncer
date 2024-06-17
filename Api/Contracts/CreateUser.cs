using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Contracts
{
    public class CreateUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}