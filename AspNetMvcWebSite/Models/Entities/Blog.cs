using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcWebSite.Models.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
    }
}