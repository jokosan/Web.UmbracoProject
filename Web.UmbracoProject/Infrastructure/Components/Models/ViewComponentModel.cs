using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Web.UmbracoProject.Infrastructure.Components.Models
{
    public class ViewComponentModel
    {
        public bool Position { get; set; }
        public IPublishedElement PublishedElement { get; set; }
        public IEnumerable<IPublishedContent> PublishedContentList { get; set; }
        public IEnumerable<BlockListItem> BlocksList { get; set; }     
        public IEnumerable<IPublishedElement> publishedElementsList { get; set; }
    }
}
