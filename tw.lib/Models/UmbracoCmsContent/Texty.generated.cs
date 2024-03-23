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
	/// <summary>Texty</summary>
	[PublishedModel("texty")]
	public partial class Texty : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new const string ModelTypeAlias = "texty";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Texty, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Texty(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// TvorbaWebuEmail: Email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("tvorbaWebuEmail")]
		public virtual string TvorbaWebuEmail => this.Value<string>("tvorbaWebuEmail");

		///<summary>
		/// TvorbaWebuPhone: Telefón
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.11")]
		[ImplementPropertyType("tvorbaWebuPhone")]
		public virtual string TvorbaWebuPhone => this.Value<string>("tvorbaWebuPhone");
	}
}
