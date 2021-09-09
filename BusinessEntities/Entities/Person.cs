﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public abstract class Person : IPerson
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Email { get; set; }
    }
}
