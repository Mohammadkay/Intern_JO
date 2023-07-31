﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Account : IdentityUser
    {
        public string FullName { get; set; }
        public string AccountImage { get; set; }
    }
}
