﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class BDCreate
    {
        public string database { get; set; }

        public BDCreate() { }

        public BDCreate(string database)
        {
            this.database = database;
        }
    }
}