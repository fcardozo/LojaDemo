using PVPSolutions.Framework.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Application.Repository
{
    /// <summary>
    /// Category's repository interface
    /// </summary>
    public interface ICategoryRepository : IRepository<Domain.Category>
    {
        /// <summary>
        /// Get category with all of products by Id
        /// </summary>
        /// <param name="idCategory">Category's ID</param>
        /// <returns>Return category with all of products</returns>
        Domain.Category GetCategoryByIdWithProducts(Guid idCategory);
    }
}
