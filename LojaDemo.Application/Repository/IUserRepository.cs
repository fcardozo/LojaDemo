using PVPSolutions.Framework.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Application.Repository
{
    /// <summary>
    /// The user's repository interface
    /// </summary>
    public interface IUserRepository : IRepository<Domain.User>
    {
    }
}
