using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Web.UmbracoProject.Infrastructure.Components.Models;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Components.View
{
    [ViewComponent(Name = "Localization")]
    public class LocalizationViewComponent : ViewComponent
    {
        private readonly IUmbracoHelperServeses _umbracoHelperServeses;

        public LocalizationViewComponent(
            IUmbracoHelperServeses umbracoHelperServeses)
        {
            _umbracoHelperServeses = umbracoHelperServeses;
        }

        public IViewComponentResult Invoke(IReadOnlyDictionary<string, PublishedCultureInfo> url, string currentCulture )
        {
            return View(_umbracoHelperServeses.Localization(url, currentCulture));
        }
    }
}

