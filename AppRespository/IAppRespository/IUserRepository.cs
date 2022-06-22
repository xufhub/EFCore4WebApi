using AppDenpendency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRespository
{
    public interface IUserRepository: IAppBaseRespository<UserEntity>, IAppDenpendency
    {
    }
}
