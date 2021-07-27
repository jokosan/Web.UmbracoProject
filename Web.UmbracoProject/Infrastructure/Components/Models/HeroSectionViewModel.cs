using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Web.UmbracoProject.Infrastructure.Components.Models
{
    public class HeroSectionViewModel
    {
        public IEnumerable<IPublishedElement> HeroTest { get; set; }
    }
}
