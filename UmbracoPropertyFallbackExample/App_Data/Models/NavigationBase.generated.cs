//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.10.1
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

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "navigationBase"
	/// <summary>Navigation Base</summary>
	public partial interface INavigationBase : IPublishedContent
	{
		/// <summary>Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		global::System.Collections.Generic.IEnumerable<string> Keywords { get; }

		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		string SeoMetaDescription { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		global::UmbracoPropertyFallbackExample.PropertyConverters.FallbackValue SeoMetaTitle { get; }

		/// <summary>Hide in Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		bool UmbracoNavihide { get; }
	}

	/// <summary>Navigation Base</summary>
	[PublishedModel("navigationBase")]
	public partial class NavigationBase : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "navigationBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NavigationBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public NavigationBase(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => GetKeywords(this);

		/// <summary>Static getter for Keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static global::System.Collections.Generic.IEnumerable<string> GetKeywords(INavigationBase that) => that.Value<global::System.Collections.Generic.IEnumerable<string>>("keywords");

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => GetSeoMetaDescription(this);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static string GetSeoMetaDescription(INavigationBase that) => that.Value<string>("seoMetaDescription");

		///<summary>
		/// Title: An example property that I added to demonstrate the textstring fallback field.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("seoMetaTitle")]
		public global::UmbracoPropertyFallbackExample.PropertyConverters.FallbackValue SeoMetaTitle => GetSeoMetaTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static global::UmbracoPropertyFallbackExample.PropertyConverters.FallbackValue GetSeoMetaTitle(INavigationBase that) => that.Value<global::UmbracoPropertyFallbackExample.PropertyConverters.FallbackValue>("seoMetaTitle");

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => GetUmbracoNavihide(this);

		/// <summary>Static getter for Hide in Navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static bool GetUmbracoNavihide(INavigationBase that) => that.Value<bool>("umbracoNavihide");
	}
}
