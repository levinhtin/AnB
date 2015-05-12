using System;
using System.ComponentModel.DataAnnotations;

namespace AnB.Data.Articles.Models
{
    public class Articles_Content
    {        
        //[Required(ErrorMessageResourceType = typeof(AnB.Resources.Global), ErrorMessageResourceName = "Model_Required_CultureCode")]
        public string CultureCode { get; set; }
        public int ArticlesID { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int CreatedByUserID { get; set; }
        public int LastModifiedByUserID { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastModifiedOnDate { get; set; }
        public int Version { get; set; }
    }
}