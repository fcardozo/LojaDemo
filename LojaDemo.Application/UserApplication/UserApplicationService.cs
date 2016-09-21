using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDemo.Domain;
using LojaDemo.Application.Repository;

namespace LojaDemo.Application.UserApplication
{
    /// <summary>
    /// User application's service class
    /// </summary>
    public class UserApplicationService : IUserApplicationService
    {
        /// <summary>
        /// Variable of User's repository 
        /// </summary>
        IUserRepository _userRepository;

        /// <summary>
        /// Initialize class with user's repository with dependency injection
        /// </summary>
        /// <param name="userRepository">User's repository injection</param>
        public UserApplicationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Implement IUserApplicationService

        /// <summary>
        /// <see cref="IUserApplicationService.Login(User)"/>
        /// </summary>
        /// <param name="user"><see cref="IUserApplicationService.Login(User)"/></param>
        public void Login(User user)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
