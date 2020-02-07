﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CustomIdentity.Models
{
    public class CustomIdentityUser : IdentityUser
    {
        public string Notes { get; set; }

    }
}
