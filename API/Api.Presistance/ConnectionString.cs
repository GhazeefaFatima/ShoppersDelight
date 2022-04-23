using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Api.Presistence
{
   public class ConnectionString
    {
        private readonly IConfiguration _configuration;
        public ConnectionString(IConfiguration configuration)
        {
            _configuration = configuration;


        }

        public static string GetConnectionString(string name = "Local_Db")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    
    }
}
