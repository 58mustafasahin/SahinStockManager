﻿using SM.AuthorizationMgmt.Domain.Concrete;
using SM.Core.DataAccess;

namespace SM.AuthorizationMgmt.DataAccess.Abstract
{
    public interface IUserRepository : IEntityDefaultRepository<User>
    {
    }
}
