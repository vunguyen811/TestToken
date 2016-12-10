using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TestToken.Model
{
    public class UserLogins : IdentityUserLogin<string>
    {
        //public string Id { get; set; }
        //public UserLogins()
        //{
        //    Id = Guid.NewGuid().ToString();
        //}
    }
}
