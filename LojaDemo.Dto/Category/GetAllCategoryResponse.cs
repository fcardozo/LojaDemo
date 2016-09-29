using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Dto.Category
{
    /// <summary>
    /// GetAllCategory's response
    /// </summary>
    public class GetAllCategoryResponse
    {
        /// <summary>
        /// List of category item
        /// </summary>
        public List<CategoryItemDto> ListOfCategoryItem { get; set; }
    }
}
