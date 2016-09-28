using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Dto.User
{
    /// <summary>
    /// Login's response
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// User informations
        /// </summary>
        public UserDto UserAuth { get; set; }

        /// <summary>
        /// Flag if user is authenticated 
        /// </summary>
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// Message of error cause ocurrer
        /// </summary>
        public string MessageError { get; set; }
    }
}
