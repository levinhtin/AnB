using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnB.Data.Ecommerce.Models
{
    public class Product_Content
    {
        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [Required]
        public string CultureCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Content { get; set; }
        public int CreatedByUserId { get; set; }
        public int LastModifiedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public virtual Product Product { get; set; }
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