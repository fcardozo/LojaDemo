using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository.Context
{
    /// <summary>
    /// The class to help initialize the context
    /// </summary>
    internal class Helper
    {
        private static LojaDemoContext _context = null;

        /// <summary>
        /// Create the static context
        /// </summary>
        /// <returns>Return the LojaDemo's context</returns>
        internal static LojaDemoContext GetLojaDemoContext()
        {
            if (_context == null)
                _context = new LojaDemoContext();

            _context.Configuration.LazyLoadingEnabled = false;
            return _context;
        }
    }
}
