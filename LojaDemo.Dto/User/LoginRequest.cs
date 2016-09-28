using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Dto.User
{
    /// <summary>
    /// The object to request login on application
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Login of the user
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Password of the user
        /// </summary>
        public string Password { get; set; }
    }
}
