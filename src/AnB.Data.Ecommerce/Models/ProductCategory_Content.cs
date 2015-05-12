using System;

namespace AnB.Data.Ecommerce.Models
{
    public class ProductCategory_Content
    {
        public string CultureCode { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedByUserId { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
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