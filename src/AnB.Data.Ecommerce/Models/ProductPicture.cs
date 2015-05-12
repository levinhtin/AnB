using System;
using System.Collections.Generic;

namespace AnB.Data.Ecommerce.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductPicture
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
        public virtual Product  Product { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int  DisplayOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PicturePath { get; set; }
    }
}