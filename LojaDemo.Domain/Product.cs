using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaDemo.Domain
{
    /// <summary>
    /// Product's class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product's Id
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// Category's Id
        /// </summary>
        public Guid IdCategory { get; set; }

        /// <summary>
        /// Product's category
        /// </summary>
        public Category  Category { get; set; }

        /// <summary>
        /// Product's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product's Full Price
        /// </summary>
        public decimal FullPrice { get; set; }

        /// <summary>
        /// Product's discount price
        /// </summary>
        public decimal DiscountPrice { get; set; }

        /// <summary>
        /// Indicator of promotion 
        /// </summary>
        public bool IsPromotion { get; set; }
    }
}
