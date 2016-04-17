﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class IncludeDbVm
    {
        public string dbType { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public string server { get; set; }
        public string protocol { get; set; }
        public int port { get; set; }
        public string alias { get; set; }

        public IncludeDbVm()
        {

        }
        public IncludeDbVm(string dbType, string username, string pass, string server, string protocol, int port, string alias)
        {
            this.dbType = dbType;
            this.username = username;
            this.pass = pass;
            this.server = server;
            this.protocol = protocol;
            this.port = port;
            this.alias = alias;

        }

       

    }
}