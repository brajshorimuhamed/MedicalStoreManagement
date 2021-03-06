using MedicalStoreManagement.Domain._DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Users
{
    public interface IUserService
    {
        Task AddUser(UserSubmissionModel model);
    }
}
