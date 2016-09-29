using AutoMapper;
using LojaDemo.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Application.CategoryApplication
{
    /// <summary>
    /// Category's application interface
    /// </summary>
    public interface ICategoryApplicationService
    {
        /// <summary>
        /// Get all of category id and name to display in list
        /// </summary>
        /// <returns>Return list of category</returns>
        GetAllCategoryResponse GetAllCategoryForList();
    }
}
