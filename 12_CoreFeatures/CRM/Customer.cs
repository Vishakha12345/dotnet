using System;
using System.Xml.Serialization;

namespace CRM
{
    [Serializable]
    public class Customer
    {

        [XmlElementAttribute("FirstName")]
        public string FirstName { get; set; }

        [XmlElementAttribute("LastName")]
        public string LastName { get; set; }
        [XmlElementAttribute("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }

        [XmlElementAttribute("Location")]
        public string Location { get; set; }

        [XmlElementAttribute("TurnOver")]
        public double TurnOver { get; set; }
    }
}
