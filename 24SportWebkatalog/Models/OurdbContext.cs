﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _24SportWebkatalog.Models
{
    public class OurdbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }

        public DbSet <CatalogItem> catalogItems { get; set; }


    }
}