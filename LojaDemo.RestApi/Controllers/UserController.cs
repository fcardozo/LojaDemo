using LojaDemo.Application.UserApplication;
using LojaDemo.Dto;
using LojaDemo.Dto.User;
using LojaDemo.Infrastructure.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaDemo.RestApi.Controllers
{
    /// <summary>
    /// User's API
    /// </summary>
    public class UserController : ApiController
    {
        /// <summary>
        /// Variable of user's application service
        /// </summary>
        IUserApplicationService userApplicationService;

        /// <summary>
        /// Execute login of user.
        /// </summary>
        /// <param name="loginRequest">Request to execute login.</param>
        /// <returns>Authenticated user</returns>
        [HttpPost()]
        public LoginResponse Login(LoginRequest loginRequest)
        {
            userApplicationService = IocFactory.GetInstanceIUserRepository();
            return userApplicationService.Login(loginRequest);
        }
    }
}
