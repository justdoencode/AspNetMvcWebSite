﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AspNetMvcWebSite.DataAccessLayer
{
    public class DatabaseInitializer:DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
    }
}