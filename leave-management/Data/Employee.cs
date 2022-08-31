using Microsoft.AspNetCore.Identity;
using System;
namespace leave_management.Data
{
    public class Employee : IdentityUser
    {
        public string Firstame { get; set; }
        public string Lastname { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
