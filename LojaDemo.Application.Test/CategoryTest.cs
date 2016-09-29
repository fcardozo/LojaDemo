using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LojaDemo.Application.CategoryApplication;
using LojaDemo.Infrastructure.Ioc;

namespace LojaDemo.Application.Test
{
    [TestClass]
    public class CategoryTest
    {
        ICategoryApplicationService _categoryApplicationService = IocFactory.GetInstanceICategoryApplicationServie();

        [TestMethod]
        public void GetAllCategory()
        {
            try
            {
                var response = _categoryApplicationService.GetAllCategoryForList();
                Assert.IsNotNull(response);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
