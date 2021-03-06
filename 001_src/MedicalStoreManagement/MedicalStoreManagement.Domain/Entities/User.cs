using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
