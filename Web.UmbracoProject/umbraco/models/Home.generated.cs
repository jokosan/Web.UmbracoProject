//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IAbout, IClientsSection, IFeaturedSections, ISeo, ISliders
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Home(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Image About
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("imageAbout")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops ImageAbout => global::Umbraco.Cms.Web.Common.PublishedModels.About.GetImageAbout(this, _publishedValueFallback);

		///<summary>
		/// Text About
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("textAbout")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString TextAbout => global::Umbraco.Cms.Web.Common.PublishedModels.About.GetTextAbout(this, _publishedValueFallback);

		///<summary>
		/// Title About
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("titleAbout")]
		public virtual string TitleAbout => global::Umbraco.Cms.Web.Common.PublishedModels.About.GetTitleAbout(this, _publishedValueFallback);

		///<summary>
		/// Img Clients
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("imgClients")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Core.Models.MediaWithCrops> ImgClients => global::Umbraco.Cms.Web.Common.PublishedModels.ClientsSection.GetImgClients(this, _publishedValueFallback);

		///<summary>
		/// Text Clients
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("textClients")]
		public virtual string TextClients => global::Umbraco.Cms.Web.Common.PublishedModels.ClientsSection.GetTextClients(this, _publishedValueFallback);

		///<summary>
		/// Title Clients
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("titleClients")]
		public virtual string TitleClients => global::Umbraco.Cms.Web.Common.PublishedModels.ClientsSection.GetTitleClients(this, _publishedValueFallback);

		///<summary>
		/// Content Featured
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("contentFeatured")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.FeaturedSection> ContentFeatured => global::Umbraco.Cms.Web.Common.PublishedModels.FeaturedSections.GetContentFeatured(this, _publishedValueFallback);

		///<summary>
		/// Hide Footer: Hide the footer.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("hideFooter")]
		public virtual bool HideFooter => global::Umbraco.Cms.Web.Common.PublishedModels.Seo.GetHideFooter(this, _publishedValueFallback);

		///<summary>
		/// Hide Main Nav
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("hideMainNav")]
		public virtual bool HideMainNav => global::Umbraco.Cms.Web.Common.PublishedModels.Seo.GetHideMainNav(this, _publishedValueFallback);

		///<summary>
		/// keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("keywords")]
		public virtual string Keywords => global::Umbraco.Cms.Web.Common.PublishedModels.Seo.GetKeywords(this, _publishedValueFallback);

		///<summary>
		/// Page title: The page title will be displayed in the browser tab and in the navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.Seo.GetPageTitle(this, _publishedValueFallback);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("seoMetaDescription")]
		public virtual string SeoMetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.Seo.GetSeoMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Images Slider
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-beta004+c41d05f6a67e1d217d565d055a85231792520f88")]
		[ImplementPropertyType("imagesSlider")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Web.Common.PublishedModels.Slider> ImagesSlider => global::Umbraco.Cms.Web.Common.PublishedModels.Sliders.GetImagesSlider(this, _publishedValueFallback);
	}
}