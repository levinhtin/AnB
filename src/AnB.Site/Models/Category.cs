using System;

namespace AnB.Site.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public int ParentID { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime LastModifiedOnDate { get; set; }       
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public int OrderNumber { get; set; }
    }
}