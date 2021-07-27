using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.UmbracoProject.Infrastructure.Components.Models;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Components.View
{
    [ViewComponent(Name = "Hero")]
    public class HeroSectionViewComponent : ViewComponent
    {
        private readonly IUmbracoHelperServeses _umbracoHelperServeses;

        public HeroSectionViewComponent(
            IUmbracoHelperServeses umbracoHelperServeses)
        {
            _umbracoHelperServeses = umbracoHelperServeses;
        }

        public IViewComponentResult Invoke()
        {
            return View(new ViewComponentModel
            {
                publishedElementsList = _umbracoHelperServeses.GetHero()
            });
        }
    }
}
