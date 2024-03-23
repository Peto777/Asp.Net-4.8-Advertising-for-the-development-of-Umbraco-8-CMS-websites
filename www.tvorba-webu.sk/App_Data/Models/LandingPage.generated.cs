//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.11
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace tw.lib.Models.UmbracoCmsContent
{
	/// <summary>LandingPage</summary>
	[PublishedModel("landingPage")]
	public partial class LandingPage : PublishedContentModel, ICmsContent, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new const string ModelTypeAlias = "landingPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public LandingPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// GridContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("gridContent")]
		public virtual global::Newtonsoft.Json.Linq.JToken GridContent => global::tw.lib.Models.UmbracoCmsContent.CmsContent.GetGridContent(this);

		///<summary>
		/// Menu Title: Názov stránky pre menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("menuTitle")]
		public virtual string MenuTitle => global::tw.lib.Models.UmbracoCmsContent.SEO.GetMenuTitle(this);

		///<summary>
		/// Meta Description: Popis stránky
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::tw.lib.Models.UmbracoCmsContent.SEO.GetMetaDescription(this);

		///<summary>
		/// Page Title: Názov stránky
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => global::tw.lib.Models.UmbracoCmsContent.SEO.GetPageTitle(this);

		///<summary>
		/// UmbracoNaviHide: Ak je táto voľba zaškrtnutá, potom daná stránka nebude súčasťou menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => global::tw.lib.Models.UmbracoCmsContent.SEO.GetUmbracoNaviHide(this);
	}
}
