using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_WEB.Models
{
    public class ContentPage
    {
        public string Id { get; set; }
        public string PageTitle { get; set; }
        public string PageImage { get; set; }
        public string PageKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string PageContent { get; set; }
        public string PageURL { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int IsActive { get; set; }
        public string Message { get; set; }
        public int? EnumId { get; set; }
    }

}