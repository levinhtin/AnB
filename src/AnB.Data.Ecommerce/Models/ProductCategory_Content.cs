using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnB.Data.Ecommerce.Models
{
    public class ProductCategory_Content
    {
        [Key]
        [Column(Order = 0)]
        public int ProductCategoryId { get; set; }
        [Key]
        [Column(Order = 1)]
        public string CultureCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
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