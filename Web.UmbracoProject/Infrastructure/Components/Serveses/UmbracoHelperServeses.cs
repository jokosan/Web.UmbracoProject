using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;
using Web.UmbracoProject.Infrastructure.Components.Models;
using Web.UmbracoProject.Infrastructure.Components.Serveses.Contract;

namespace Web.UmbracoProject.Infrastructure.Components.Serveses
{
    public class UmbracoHelperServeses : IUmbracoHelperServeses
    {
        private readonly UmbracoHelper _umbracoHelper;
        private readonly ILocalizationService _localizationService;

        public UmbracoHelperServeses(
            UmbracoHelper umbracoHelper,
            ILocalizationService localizationService)
        {
            _umbracoHelper = umbracoHelper;
            _localizationService = localizationService;
        }

        // ??????? name
        private IPublishedContent RootUmraco(string propertyAlias)
             => _umbracoHelper.ContentAtXPath($"//{propertyAlias}")?.FirstOrDefault();

        public List<IPublishedContent> GetAppConfig()
        {
            var resultRoot = RootUmraco(AppConfig.ModelTypeAlias);
            var items = new List<IPublishedContent>() { resultRoot };
            items.AddRange(resultRoot.Children);

            return items;
        }

        public IEnumerable<IPublishedElement> GetHero()
        {
            var demo = _umbracoHelper.ContentAtRoot().DescendantsOrSelfOfType(TopBar.ModelTypeAlias).FirstOrDefault();

            //------------------------------------------------------------------------------------
            var resultRoot = RootUmraco("imagesSlider");
            return resultRoot.Value<IEnumerable<IPublishedElement>>("imagesSlider");
        }

        public List<IPublishedContent> LogoSelection()
        {
            var root = RootUmraco(Logo.ModelTypeAlias);
            var items = new List<IPublishedContent>() { root };
            items.AddRange(root.Children);

            return items;
        }

        public IEnumerable<BlockListItem> GetTopNavigation()
        {
            var root = RootUmraco(Nav.ModelTypeAlias);
            var block = root.Value<IEnumerable<BlockListItem>>("startBlocks");

            return block;
        }

        public IEnumerable<LocalizationModel> Localization(IReadOnlyDictionary<string, PublishedCultureInfo> url, string currentCulture)
        {
            var localizationList = new List<LocalizationModel>();
            var localization = GetLanguages();

            foreach (var item in url)
            {
                if (item.Key.ToLower() != currentCulture.ToLower())
                {
                    if (item.Value.Name == "Home")
                    {
                        localizationList.Add(new LocalizationModel
                        {
                            Name = LocalizationName(item.Key),
                            Url = $"/{TwoLetterISO(item.Value.Culture)}/"
                        });
                    }
                    else
                    {
                        localizationList.Add(new LocalizationModel
                        {
                            Name = LocalizationName(item.Key),
                            Url = $"/{TwoLetterISO(item.Value.Culture)}{item.Value.UrlSegment}/"
                        });
                    }
                }
            }

            if (localization.Count() != url.Count)
            {
                localizationList = PageWithoutCulture(currentCulture, localizationList);
            }

            return localizationList.AsEnumerable();
        }

        private List<LocalizationModel> PageWithoutCulture(string currentCulture, List<LocalizationModel> localizationList)
        {
            foreach (var item in GetLanguages())
            {
                if (item.CultureInfo.Name.ToLower() != currentCulture.ToLower())
                {
                    var test = item.CultureInfo.TwoLetterISOLanguageName;
                    if (!localizationList.Any(x => x.Url.Contains(item.CultureInfo.TwoLetterISOLanguageName)))
                    {
                        localizationList.Add(new LocalizationModel
                        {
                            Name = item.CultureName,
                            Url = $"/{item.CultureInfo.TwoLetterISOLanguageName}/"
                        });
                    }
                }
            }

            return localizationList;
        }

        private IEnumerable<ILanguage> GetLanguages()
            => _localizationService.GetAllLanguages();

        private string TwoLetterISO(string localization)
        {
            var localizationTest = GetLanguages();
            var result = localizationTest.FirstOrDefault(x => x.CultureInfo.Name.ToLower() == localization);

            if (result.CultureInfo.TwoLetterISOLanguageName == "en")
            {
                return "";
            }
            else
            {
                return result.CultureInfo.TwoLetterISOLanguageName + "/";
            }
        }

        private string LocalizationName(string NameCulture)
        {
            var local = GetLanguages();

            foreach (var item in local)
            {
                if (NameCulture == item.IsoCode.ToLower())
                {
                    return item.CultureName;
                }
            }

            return "N/A";
        }
    }
}
