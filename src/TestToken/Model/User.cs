using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestToken.Model
{
    public class User : IdentityUser
    {
        public bool IsSuperman { get; set; }
    }
}
