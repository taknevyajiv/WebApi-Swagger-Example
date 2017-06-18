﻿using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Rest;
using TestApp.Models;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets try calling the API we just created
            TestAppClient client = new TestAppClient(new Uri("http://localhost:53873/"), AnonymousCredential.Instance);
            List<Vendor> vendorsList = client.Vendors.GetVendors().ToList();
            Console.WriteLine("The total count of vendors for AdventureWorks at present is " + vendorsList.Count);
            Console.ReadKey();
        }
    }

    // Since there is no straightforward way to call a REST service generated by AutoRest using Anonymous authentication 
    // See https://github.com/Azure/autorest/issues/930
    class AnonymousCredential : ServiceClientCredentials
    {
        public static ServiceClientCredentials Instance { get; } = new AnonymousCredential();

        private AnonymousCredential()
        {

        }
    }
}
