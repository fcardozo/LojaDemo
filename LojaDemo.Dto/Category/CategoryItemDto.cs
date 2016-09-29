using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Dto.Category
{
    /// <summary>
    /// Object of category represents ComboBox
    /// </summary>
    public class CategoryItemDto
    {
        /// <summary>
        /// Category's ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Category's name
        /// </summary>
        public string Name { get; set; }
    }
}
