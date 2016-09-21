using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDemo.Domain;
using LojaDemo.Infrastructure.CustomException.UserException;

namespace LojaDemo.Application.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void VerifyUserwithoutLogin()
        {
            User user = new User();

            try
            {
                user.VerifyUser();
            }
            catch (UserWithoutLoginException)
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
            User user = new User();
            user.Loign = "fcardozo";

            try
            {
                user.VerifyUser();
            }
            catch (UserWithoutPassException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void VerifyOuthLoginWhitError()
        {
            /// Precisa ser criado repositório;
            /// 
        }

        [TestMethod]
        public void VerifyOuthLoginWithoutError()
        {

        }
    }
}
