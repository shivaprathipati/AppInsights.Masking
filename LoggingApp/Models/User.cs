using System;
using Destructurama.Attributed;

namespace LoggingApp.Models
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotLogged]
        public DateTime DateOfBirth { get; set; }
        [LogMasked(ShowFirst = 3, PreserveLength = true)]
        public string PhoneNumber { get; set; }
        [LogMasked(ShowLast = 4, PreserveLength = true)]
        public string Ssn { get; set; }
    }
}