﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5466
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class Price
	{

		private string articleNumberField;
		
		private string dateField;

		private string fromQuantityField;

		private string percentField;

		private string priceValueField;

		private string priceListField;

		private string urlField;

		/// <remarks/>
		public string ArticleNumber
		{
			get
			{
				return this.articleNumberField;
			}
			set
			{
				this.articleNumberField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
			}
		}

		/// <remarks/>
		public string FromQuantity
		{
			get
			{
				return this.fromQuantityField;
			}
			set
			{
				this.fromQuantityField = value;
			}
		}

		/// <remarks/>
		public string Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("Price")]
		public string PriceValue
		{
			get
			{
				return this.priceValueField;
			}
			set
			{
				this.priceValueField = value;
			}
		}

		/// <remarks/>
		public string PriceList
		{
			get
			{
				return this.priceListField;
			}
			set
			{
				this.priceListField = value;
			}
		}

		/// <summary>This field is Read-Only in Fortnox</summary>
		[System.ComponentModel.ReadOnly(true)]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}