﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcWebSite.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Eposta { get; set; }
        public string Password { get; set; }

    }
}