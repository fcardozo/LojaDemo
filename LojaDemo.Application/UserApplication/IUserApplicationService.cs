using LojaDemo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Application.UserApplication
{
    public interface IUserApplicationService
    {
        /// <summary>
        /// Execute login of the user
        /// </summary>
        /// <param name="user">User to login</param>
        void Login(User user);
    }
}
