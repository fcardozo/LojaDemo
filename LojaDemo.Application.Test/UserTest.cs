using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDemo.Infrastructure.CustomException.UserException;
using LojaDemo.Application.UserApplication;
using LojaDemo.Infrastructure.Ioc;
using LojaDemo.Dto;

namespace LojaDemo.Application.Test
{
    [TestClass]
    public class UserTest
    {
        IUserApplicationService userApplicationService = IocFactory.GetInstanceIUserRepository();

        [TestMethod]
        public void VerifyUserwithoutLogin()
        {
            UserDto user = new UserDto();

            try
            {
                userApplicationService.Login(user);
            }
            catch (UserOrPassInstCorrectException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyUserwithoutPass()
        {
            UserDto user = new UserDto();
            user.Loign = "fcardozo";

            try
            {
                userApplicationService.Login(user);
            }
            catch (UserOrPassInstCorrectException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyAuthLoginWhenUserNotExist()
        {
            try
            {
                UserDto user = new UserDto() { Loign = "userNoExist", Password = "errorPass" };
                userApplicationService.Login(user);
            }
            catch (UserOrPassInstCorrectException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyAuthLoginWhenUserExistAndPassWrong()
        {
            try
            {
                UserDto user = new UserDto() { Loign = "fcardozo", Password = "errorPass" };
                userApplicationService.Login(user);
            }
            catch (UserOrPassInstCorrectException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyAuthLoginWhenUserExistAndPassCorrect()
        {
            try
            {
                UserDto user = new UserDto() { Loign = "fcardozo", Password = "loja@123" };
                user = userApplicationService.Login(user);

                Assert.IsTrue(!string.IsNullOrEmpty(user.TokenValid));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
