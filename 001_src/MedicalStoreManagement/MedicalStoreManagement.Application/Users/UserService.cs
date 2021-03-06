using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userStore;

        public UserService(IUserStore<User> userStore, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<User> passwordHasher, IEnumerable<IUserValidator<User>> userValidators,
            IEnumerable<IPasswordValidator<User>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<User>> logger)
        {
            _userStore = new UserManager<User>(userStore, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger);
        }

        public async Task AddUser(UserSubmissionModel model)
        {
            var result = await _userStore.CreateAsync(model.ToEntity(), model.Password);
        }
    }
}
