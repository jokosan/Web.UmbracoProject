using System.Collections.Generic;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Web.UmbracoProject.Infrastructure.Components.Models;

namespace Web.UmbracoProject.Infrastructure.Components.Serveses.Contract
{
    public interface IUmbracoHelperServeses
    {
        List<IPublishedContent> GetAppConfig();
        IEnumerable<IPublishedElement> GetHero();
        IEnumerable<BlockListItem> GetTopNavigation();
        List<IPublishedContent> LogoSelection();
        IEnumerable<LocalizationModel> Localization(IReadOnlyDictionary<string, PublishedCultureInfo> url, string currentCulture);
    }
}