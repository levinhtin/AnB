using System;
using System.Collections.Generic;

namespace AnB.Data.Ecommerce.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductCategoryMapping
    {

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public int? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Product Product { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int? ProductCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ProductCategory ProductCategory { get; set; }
    }
}