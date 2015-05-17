using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [Column(Order = 0)]
        public int? ProductCategoryId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public int? ProductId { get; set; }

        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Product Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ProductCategory ProductCategory { get; set; }
    }
}