using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UmbracoProject.Infrastructure.Components.Models;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Components.View
{
    [ViewComponent(Name = "TopNavigation")]
    public class TopNavigationViewComponent : ViewComponent
    {
        private readonly IUmbracoHelperServeses _umbracoHelperServeses;

        public TopNavigationViewComponent(
            IUmbracoHelperServeses umbracoHelperServeses)
        {
            _umbracoHelperServeses = umbracoHelperServeses;
        }

        public IViewComponentResult Invoke(bool position = true)
        {
            return View(new ViewComponentModel
            {
                Position = position, 
                BlocksList = _umbracoHelperServeses.GetTopNavigation()
            });
        }
    }
}
