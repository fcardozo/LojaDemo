using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.CustomException.UserException
{
    /// <summary>
    /// The exception that represent user without login.
    /// </summary>
    public class UserOrPassInstCorrectException : ArgumentNullException
    {
        /// <summary>
        /// Load the exception that represent user without login.
        /// </summary>
        public UserOrPassInstCorrectException() : base(FactoryExceptionMessage.GetMessageByKey("UserOrPassInstCorrectException"))
        { }
    }
}
