using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Domain._DTO
{
    public class UserSubmissionModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User ToEntity()
        {
            return new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                EmailConfirmed = true,
                UserName = Email
            };
        }
    }
}
