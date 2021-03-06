﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ClientApp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Vendor
    {
        /// <summary>
        /// Initializes a new instance of the Vendor class.
        /// </summary>
        public Vendor() { }

        /// <summary>
        /// Initializes a new instance of the Vendor class.
        /// </summary>
        public Vendor(int? businessEntityID = default(int?), string accountNumber = default(string), string name = default(string), int? creditRating = default(int?), bool? preferredVendorStatus = default(bool?), bool? activeFlag = default(bool?), string purchasingWebServiceURL = default(string), DateTime? modifiedDate = default(DateTime?))
        {
            BusinessEntityID = businessEntityID;
            AccountNumber = accountNumber;
            Name = name;
            CreditRating = creditRating;
            PreferredVendorStatus = preferredVendorStatus;
            ActiveFlag = activeFlag;
            PurchasingWebServiceURL = purchasingWebServiceURL;
            ModifiedDate = modifiedDate;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BusinessEntityID")]
        public int? BusinessEntityID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountNumber")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreditRating")]
        public int? CreditRating { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PreferredVendorStatus")]
        public bool? PreferredVendorStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ActiveFlag")]
        public bool? ActiveFlag { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PurchasingWebServiceURL")]
        public string PurchasingWebServiceURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

    }
}
