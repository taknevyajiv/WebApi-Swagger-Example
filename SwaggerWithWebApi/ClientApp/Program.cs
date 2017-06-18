using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Rest;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static ClientAppClient NewAPIClient()
        {
            var client = new ClientAppClient(new Uri(ConfigurationManager.AppSettings["API_URI"]));

        }
    }
}
