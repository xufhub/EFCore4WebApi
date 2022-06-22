using AppRespository;
using MongoRespository.IMongoRespository;
using MongoRespository.MongoDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppService
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        readonly IUserMongoRepository _userMongoRepository;
        public UserService(IUserRepository userRepository, IUserMongoRepository userMongoRepository)
        {
            _userRepository = userRepository;
            _userMongoRepository = userMongoRepository;
        }

        public UserEntity GetUserById(int id)
        {
           return _userRepository.GetEntityById(id);
        }
        public async Task<UserMgEntity> GetUserByName(string uname)
        {
            return await _userMongoRepository.GetByUserName(uname);
        }

        public async Task BatchInsertUser()
        {
            List<UserEntity> userEntities = new List<UserEntity>();
            for (int i = 0; i < 100; i++)
            {
                UserEntity userEntity = new UserEntity();
                userEntity.UserName = $"uname{i}";
                userEntity.NickName = $"unikename{i}";
                userEntity.State = 0;
                userEntities.Add(userEntity);
            }
            await _userRepository.BatchInsertAsync(userEntities);
        }
        public async Task BatchUpdateUser()
        {
            List<UserEntity> userEntities = await _userRepository.GetAll();
            foreach (var item in userEntities)
            {
                if(item.Id % 2 == 1)
                {
                    item.State = 3;
                }
                else
                {
                    item.UserName = "testname";
                }
                
            }

            await _userRepository.BatchUpdateAsync(userEntities);
        }

    }
}
