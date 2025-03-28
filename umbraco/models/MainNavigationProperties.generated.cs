//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.1.1+eb4fc97
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

namespace QuantumWebsite.Models
{
	// Mixin Content Type with alias "mainNavigationProperties"
	/// <summary>Main Navigation Properties</summary>
	public partial interface IMainNavigationProperties : IPublishedElement
	{
		/// <summary>EmailNavigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string EmailNavigation { get; }

		/// <summary>NavigationLogo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops NavigationLogo { get; }

		/// <summary>PhoneNum</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PhoneNum { get; }
	}

	/// <summary>Main Navigation Properties</summary>
	[PublishedModel("mainNavigationProperties")]
	public partial class MainNavigationProperties : PublishedElementModel, IMainNavigationProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		public new const string ModelTypeAlias = "mainNavigationProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<MainNavigationProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public MainNavigationProperties(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// EmailNavigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailNavigation")]
		public virtual string EmailNavigation => GetEmailNavigation(this, _publishedValueFallback);

		/// <summary>Static getter for EmailNavigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetEmailNavigation(IMainNavigationProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "emailNavigation");

		///<summary>
		/// NavigationLogo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("navigationLogo")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops NavigationLogo => GetNavigationLogo(this, _publishedValueFallback);

		/// <summary>Static getter for NavigationLogo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetNavigationLogo(IMainNavigationProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "navigationLogo");

		///<summary>
		/// PhoneNum
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("phoneNum")]
		public virtual string PhoneNum => GetPhoneNum(this, _publishedValueFallback);

		/// <summary>Static getter for PhoneNum</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.1.1+eb4fc97")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPhoneNum(IMainNavigationProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "phoneNum");
	}
}
