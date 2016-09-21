using LojaDemo.Infrastructure.CustomException.UserException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Domain
{
    /// <summary>
    /// The user of the store
    /// </summary>
    public class User
    {
        /// <summary>
        /// Nem of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Login of the user
        /// </summary>
        public string Loign { get; set; }

        /// <summary>
        /// Password of the user
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Method to verifed user's valid 
        /// </summary>
        public void VerifyUser()
        {
            /// verife login
            if (string.IsNullOrEmpty(this.Loign))
                throw new UserWithoutLoginException();

            if (string.IsNullOrEmpty(this.Password))
                throw new UserWithoutPassException(); 
        }
    }
}
