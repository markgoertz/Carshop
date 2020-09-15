using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Data_access_layer.Entities
{
    public class User: IUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public DateTime Birthday { get; set; }

    }
}
