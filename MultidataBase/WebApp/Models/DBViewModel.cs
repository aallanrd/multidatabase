using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class DBViewModel
    {
        string dbType;
        string username;
        string pass;
        string server;
        string protocol;
        int port;
        string alias;

        public DBViewModel()
        {

        }
        public DBViewModel(string dbType, string username, string pass, string server, string protocol, int port, string alias)
        {
            this.dbType = dbType;
            this.username = username;
            this.pass = pass;
            this.server = server;
            this.protocol = protocol;
            this.port = port;
            this.alias = alias;

        }

        public string getDBType()
        {
            return this.dbType;
        }
        public string getUser()
        {
            return this.username;
        }
        public string getPass()
        {
            return this.pass;
        }
        public string getServer()
        {
            return this.server;
        }
        public string getProtocol()
        {
            return this.protocol;
        }
        public string getAllias()
        {
            return this.alias;
        }
        public int getPort()
        {
            return this.port;
        }

    }
}