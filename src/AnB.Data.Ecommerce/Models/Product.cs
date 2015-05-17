using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnB.Data.Ecommerce.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId")]
        public int ProductId { get; set; }
        public double Price { get; set; }
        public double? PriceOld { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }
        [StringLength(200)]
        public string ImageUrlSmall { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public virtual ICollection<Product_Content> Contents { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowComment { get; set; }
        public int OrderNumber { get; set; }

        #region SEO
        /// <summary>
        /// 
        /// </summary>
        [StringLength(200)]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(200)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(200)]
        public string MetaTitle { get; set; }
        #endregion
    }
}