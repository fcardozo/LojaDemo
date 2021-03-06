﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Dto.User
{
    /// <summary>
    /// User's Data transfer object
    /// </summary>
    public class UserDto
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
        /// Token for user Authenticated
        /// </summary>
        public string TokenValid { get; set; }
    }
}
