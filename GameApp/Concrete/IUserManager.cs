using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public interface IUserManager
    {
         void Save(IUser user);
         void Update(IUser user);
         void Delete(IUser user);
    }
}
