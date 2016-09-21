using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.CustomException.UserException
{
    /// <summary>
    /// The exception that represent user without password.
    /// </summary>
    public class UserWithoutPassException : ArgumentException
    {
        /// <summary>
        /// The exception that represent user without password.
        /// </summary>
        public UserWithoutPassException() : base(FactoryExceptionMessage.GetMessageByKey("UserWithoutPassException"))
        { }
    }
}
