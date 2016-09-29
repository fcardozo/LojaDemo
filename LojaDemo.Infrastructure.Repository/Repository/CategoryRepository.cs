using LojaDemo.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDemo.Domain;
using LojaDemo.Infrastructure.Repository.Context;

namespace LojaDemo.Infrastructure.Repository
{
    /// <summary>
    /// The category's repository class
    /// </summary>
    public class CategoryRepository : PVPSolutions.Framework.Infrastructure.Repository.EF.Repository<Domain.Category>, ICategoryRepository
    {
        /// <summary>
        /// Initialize the repository with LojaDemo's context 
        /// </summary>
        public CategoryRepository() : base(Helper.GetLojaDemoContext())
        { }

        /// <summary>
        /// <see cref="LojaDemo.Application.Repository.ICategoryRepository"/>
        /// </summary>
        /// <param name="idCategory"><see cref="LojaDemo.Application.Repository.ICategoryRepository"/></param>
        /// <returns><see cref="LojaDemo.Application.Repository.ICategoryRepository"/></returns>
        public Category GetCategoryByIdWithProducts(Guid idCategory)
        {
            throw new NotImplementedException();
        }
    }
}
