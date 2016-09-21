using LojaDemo.Infrastructure.Repository.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Infrastructure.Repository.Context
{
    /// <summary>
    /// The context about LojaDemo
    /// </summary>
    public class LojaDemoContext : DbContext
    {
        /// <summary>
        /// Initialize the LojaDemoContext
        /// </summary>
        public LojaDemoContext() : base("name=LojaDemoContext")
        { }

        /// <summary>
        /// Sobrescrevendo a criação do modelo para o code first
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
