﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Domain
{
    public class ApplicationRole: IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRole { get; set; }
    }
}
