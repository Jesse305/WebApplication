﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication.Models
{
    public class CustomUser : IdentityUser
    {
        public string Nome { get; set; }
    }
}
