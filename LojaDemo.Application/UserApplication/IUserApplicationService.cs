using LojaDemo.Domain;
using LojaDemo.Dto;
using LojaDemo.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Application.UserApplication
{
    /// <summary>
    /// User's application service
    /// </summary>
    public interface IUserApplicationService
    {
        /// <summary>
        /// Execute login of the user
        /// </summary>
        /// <param name="loginRequest">Request to login</param>
        LoginResponse Login(LoginRequest loginRequest);
    }
}
