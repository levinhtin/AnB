using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnB.Data.Ecommerce.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductCategoryId")]
        public int ProductCategoryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        [StringLength(200)]
        public string ImageUrl { get; set; }
        [StringLength(200)]
        public string ImageUrlSmall { get; set; }        
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderNumber { get; set; }
        public virtual ICollection<ProductCategory_Content> Contents { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ProductCategory ParentProductCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
    }
}