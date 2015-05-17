using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnB.Data.Ecommerce.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductImage
    {
        /// <summary>
        /// 
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductImageId")]
        public int ProductImageId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int ProductId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int  DisplayOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(200)]
        public string PicturePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        public int CreatedByUserId { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime LastModifiedOnDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Product Product { get; set; }
    }
}