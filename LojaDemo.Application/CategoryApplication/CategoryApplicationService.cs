using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaDemo.Dto.Category;
using AutoMapper;
using LojaDemo.Domain;
using LojaDemo.Application.Repository;

namespace LojaDemo.Application.CategoryApplication
{
    /// <summary>
    /// Category application's service class
    /// </summary>
    public class CategoryApplicationService : ICategoryApplicationService
    {
        /// <summary>
        /// Variable of Category's repository 
        /// </summary>
        ICategoryRepository _categoryRepository;

        /// <summary>
        /// Variable of mapper
        /// </summary>
        IMapper _mapper;

        /// <summary>
        /// Initialize class with category's repository with dependency injection
        /// </summary>
        /// <param name="categoryRepository">>Category's repository injection</param>
        public CategoryApplicationService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryItemDto>();
                cfg.CreateMap<CategoryItemDto, Category>();
                cfg.CreateMap<Category, CategoryDto>();
                cfg.CreateMap<CategoryDto, Category>();

            });

            _mapper = config.CreateMapper();
        }

        #region Implements of ICategoryApplicationService

        /// <summary>
        /// <see cref="LojaDemo.Application.CategoryApplication.ICategoryApplicationService"/>
        /// </summary>
        /// <returns><see cref="LojaDemo.Application.CategoryApplication.ICategoryApplicationService"/></returns>
        public GetAllCategoryResponse GetAllCategoryForList()
        {
            GetAllCategoryResponse response = new GetAllCategoryResponse();
            response.ListOfCategoryItem = new List<CategoryItemDto>();

            List<Category> allOfCategory = _categoryRepository.GetAll().ToList();

            foreach (var item in allOfCategory)
                response.ListOfCategoryItem.Add(_mapper.Map<Category, CategoryItemDto>(item));

            return response;
        }

        #endregion

    }
}
