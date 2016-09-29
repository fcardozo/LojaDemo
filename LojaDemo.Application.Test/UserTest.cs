using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDemo.Infrastructure.CustomException.UserException;
using LojaDemo.Application.UserApplication;
using LojaDemo.Infrastructure.Ioc;
using LojaDemo.Dto;
using LojaDemo.Dto.User;

namespace LojaDemo.Application.Test
{
    [TestClass]
    public class UserTest
    {
        IUserApplicationService userApplicationService = IocFactory.GetInstanceIUserApplicationServie();

        [TestMethod]
        public void VerifyUserwithoutLogin()
        {
            LoginRequest loginRequest = new LoginRequest();

            try
            {
                var response = userApplicationService.Login(loginRequest);
                Assert.IsTrue(!response.IsAuthenticated && response.MessageError.Equals(new UserOrPassInstCorrectException().Message));
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyUserwithoutPass()
        {
            LoginRequest loginRequest = new LoginRequest();
            loginRequest.Login = "fcardozo";

            try
            {
                var response = userApplicationService.Login(loginRequest);
                Assert.IsTrue(!response.IsAuthenticated && response.MessageError.Equals(new UserOrPassInstCorrectException().Message));
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
                LoginRequest loginRequest = new LoginRequest() { Login = "userNoExist", Password = "errorPass" };
                var response = userApplicationService.Login(loginRequest);
                Assert.IsTrue(!response.IsAuthenticated && response.MessageError.Equals(new UserOrPassInstCorrectException().Message));
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
                LoginRequest loginRequest = new LoginRequest() { Login = "fcardozo", Password = "errorPass" };
                var response = userApplicationService.Login(loginRequest);
                Assert.IsTrue(!response.IsAuthenticated && response.MessageError.Equals(new UserOrPassInstCorrectException().Message));
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
                LoginRequest loginRequest = new LoginRequest() { Login = "fcardozo", Password = "loja@123" };

                var response = userApplicationService.Login(loginRequest);

                Assert.IsTrue(!string.IsNullOrEmpty(response.UserAuth.TokenValid) && response.IsAuthenticated);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
