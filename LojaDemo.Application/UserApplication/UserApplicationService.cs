using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDemo.Domain;
using LojaDemo.Application.Repository;
using LojaDemo.Infrastructure.CustomException.UserException;
using LojaDemo.Dto;
using AutoMapper;

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
        /// Variable of mapper
        /// </summary>
        IMapper _mapper;

        /// <summary>
        /// Initialize class with user's repository with dependency injection
        /// </summary>
        /// <param name="userRepository">User's repository injection</param>
        public UserApplicationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto, User>();
            });

            _mapper = config.CreateMapper();
        }

        #region Implement IUserApplicationService

        /// <summary>
        /// <see cref="IUserApplicationService.Login(User)"/>
        /// </summary>
        /// <param name="user"><see cref="IUserApplicationService.Login(User)"/></param>
        public UserDto Login(UserDto user)
        {
            if (string.IsNullOrEmpty(user.Loign) || string.IsNullOrEmpty(user.Password))
                throw new UserOrPassInstCorrectException();

            /// Get user from DataBase
            User userEntity = _userRepository.Get(p => p.Loign.ToLower().Equals(user.Loign.ToLower())).FirstOrDefault();

            /// Verify if exist or password is invalid.
            if (userEntity == null || !userEntity.Password.Equals(user.Password))
                throw new UserOrPassInstCorrectException();

            /// Map UserEntity to UserDto
            user = _mapper.Map<User, UserDto>(userEntity);

            /// Create access token 
            user.TokenValid = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(string.Concat(user.Loign, user.Password)));

            return user;
        }

        #endregion
    }
}
