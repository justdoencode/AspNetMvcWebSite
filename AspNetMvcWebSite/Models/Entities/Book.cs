using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcWebSite.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int NumberOfPage { get; set; }
        public string Category { get; set; }
        public string GeneralInformation { get; set; }

    }
}