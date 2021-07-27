using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UmbracoProject.Infrastructure.Components.Models;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Components.View
{
    [ViewComponent(Name = "AppConfig")]
    public class AppConfigViewComponent : ViewComponent
    {
        private readonly IUmbracoHelperServeses _umbracoHelperServeses;

        public AppConfigViewComponent(
            IUmbracoHelperServeses umbracoHelperServeses)
        {
            _umbracoHelperServeses = umbracoHelperServeses;
        }

        public IViewComponentResult Invoke()
        {
            return View(new ViewComponentModel
            {
                PublishedContentList = _umbracoHelperServeses.GetAppConfig().AsEnumerable()
            });
        }
    }
}
