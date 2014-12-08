﻿using System.Xml.Serialization;

namespace EPiServer.Business.Commerce.Payment.PayEx.Models.Result
{
    internal class AddressDetail
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("address1")]
        public string Address { get; set; }

        [XmlElement("postNumber")]
        public string PostNumber { get; set; }

        [XmlElement("city")]
        public string City { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        public string CustomerName { get { return string.Join(" ", FirstName, LastName); } }
    }
}
