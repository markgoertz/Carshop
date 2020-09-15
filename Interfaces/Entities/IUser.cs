using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    public interface IUser
    {
         string Firstname { get; set; }
         string Lastname { get; set; }
         string Street { get; set; }
         int Number { get; set; }
         string Postalcode { get; set; }
         string City { get; set; }
         DateTime Birthday { get; set; }
    }
}
