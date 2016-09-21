﻿using Infrastructure.CrossCutting.IoC.Core;
using LojaDemo.Application.UserApplication;
using LojaDemo.Infrastructure.Ioc.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Ioc
{
    public static class IocFactory
    {
        static IocFactory()
        {
            IoCFactory.Instance = new IoCFactory(new RootContainer());
        }

        #region Instancias de application

        /// <summary>
        /// Create instance of UserApplicationService
        /// </summary>
        /// <returns>User's Application service</returns>
        public static IUserApplicationService GetInstanceIUserRepository()
        {
            return IoCFactory.Instance.CurrentContainer.Resolve<IUserApplicationService>();
        }

        #endregion
    }
}
