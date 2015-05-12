using System;
using System.ComponentModel.DataAnnotations;

namespace AnB.Data.Articles.Models
{
    public class Articles
    {
        //[Display(Name = "Model_Display_Articles", ResourceType = typeof(AnB.Resources.Global))]
        public int ArticlesID { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        //[Required(ErrorMessageResourceType = typeof(AnB.Resources.Global), ErrorMessageResourceName = "Model_Required_Title")]
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public string Tags { get; set; }
        public bool IsSticky { get; set; }
        public bool IsVisible { get; set; }
        public bool IsDeleted { get; set; }
        public bool AllowComment { get; set; }
        public int OrderNumber { get; set; }
    }
}