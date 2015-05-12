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
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public ICollection<Product_Content> Contents { get; set; }
        public ICollection<ProductPicture> ProductPictures { get; set; }
        public ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowComment { get; set; }
        public int OrderNumber { get; set; }

        #region SEO
        /// <summary>
        /// 
        /// </summary>
        public string MetaKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MetaTitle { get; set; }
        #endregion
    }
}