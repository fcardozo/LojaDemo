using LojaDemo.Infrastructure.Repository.Context;
using PVPSolutions.Framework.Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository
{
    /// <summary>
    /// The User's repository class
    /// </summary>
    public class UserRepository : PVPSolutions.Framework.Infrastructure.Repository.EF.Repository<Domain.User>, Application.Repository.IUserRepository
    {
        /// <summary>
        /// Initialize the repository with LojaDemo's context 
        /// </summary>
        public UserRepository() : base(Helper.GetLojaDemoContext())
        { }
    }
}
