﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Data.Entities
{
   public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
    }
}