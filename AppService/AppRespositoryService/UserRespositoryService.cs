using AppRespository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppService
{
    public class UserRespositoryService : IUserRespositoryService
    {
        readonly IUserRepository<UserEntity> _userRepository;
        public UserRespositoryService(IUserRepository<UserEntity> userRepository)
        {
            _userRepository = userRepository;
        }
        public UserEntity GetUserById(int id)
        {
            return _userRepository.GetEntityById(id);
        }
    }
}
