using Microsoft.Extensions.Configuration;
using Midterm_POS_SU4.views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_POS_SU4
{ 
    class Main
    {
        private static int userId;
        private static string userName;
        public static int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public static string GetConnectionString(string connectionString = "Default")
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = configBuilder.Build();
            return config.GetConnectionString(connectionString);
        }
    }
}