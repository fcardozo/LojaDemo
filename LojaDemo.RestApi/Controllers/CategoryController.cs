using LojaDemo.Application.CategoryApplication;
using LojaDemo.Dto.Category;
using LojaDemo.Infrastructure.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LojaDemo.RestApi.Controllers
{
    /// <summary>
    /// Category's API
    /// </summary>
    public class CategoryController : ApiController
    {
        /// <summary>
        /// Variable of category's application service
        /// </summary>
        ICategoryApplicationService _categoryApplicationService;

        /// <summary>
        /// Get all of category for build a list
        /// </summary>
        /// <returns>Return Response with List of category </returns>
        [HttpGet()]
        public GetAllCategoryResponse GetAllCategoryForList()
        {
            _categoryApplicationService = IocFactory.GetInstanceICategoryApplicationServie();
            return _categoryApplicationService.GetAllCategoryForList();
        }
    }
}
