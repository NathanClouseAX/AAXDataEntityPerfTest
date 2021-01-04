﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ItemMaterialCodeShipTxtTranslationSingle in the schema.
        /// </summary>
    public partial class ItemMaterialCodeShipTxtTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemMaterialCodeShipTxtTranslation>
    {
        /// <summary>
        /// Initialize a new ItemMaterialCodeShipTxtTranslationSingle object.
        /// </summary>
        public ItemMaterialCodeShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemMaterialCodeShipTxtTranslationSingle object.
        /// </summary>
        public ItemMaterialCodeShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemMaterialCodeShipTxtTranslationSingle object.
        /// </summary>
        public ItemMaterialCodeShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemMaterialCodeShipTxtTranslation> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ItemMaterialCodeShipTxtTranslation in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LanguageId
    /// Material
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LanguageId", "Material")]
    [global::Microsoft.OData.Client.EntitySet("ItemMaterialCodeShipTxtTranslations")]
    public partial class ItemMaterialCodeShipTxtTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemMaterialCodeShipTxtTranslation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="material">Initial value of Material.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemMaterialCodeShipTxtTranslation CreateItemMaterialCodeShipTxtTranslation(string dataAreaId, string languageId, long material)
        {
            ItemMaterialCodeShipTxtTranslation itemMaterialCodeShipTxtTranslation = new ItemMaterialCodeShipTxtTranslation();
            itemMaterialCodeShipTxtTranslation.dataAreaId = dataAreaId;
            itemMaterialCodeShipTxtTranslation.LanguageId = languageId;
            itemMaterialCodeShipTxtTranslation.Material = material;
            return itemMaterialCodeShipTxtTranslation;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string dataAreaId
        {
            get
            {
                return this._dataAreaId;
            }
            set
            {
                this.OndataAreaIdChanging(value);
                this._dataAreaId = value;
                this.OndataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _dataAreaId;
        partial void OndataAreaIdChanging(string value);
        partial void OndataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>
        /// There are no comments for Property Material in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long Material
        {
            get
            {
                return this._Material;
            }
            set
            {
                this.OnMaterialChanging(value);
                this._Material = value;
                this.OnMaterialChanged();
                this.OnPropertyChanged("Material");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Material;
        partial void OnMaterialChanging(long value);
        partial void OnMaterialChanged();
        /// <summary>
        /// There are no comments for Property MaterialCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaterialCode
        {
            get
            {
                return this._MaterialCode;
            }
            set
            {
                this.OnMaterialCodeChanging(value);
                this._MaterialCode = value;
                this.OnMaterialCodeChanged();
                this.OnPropertyChanged("MaterialCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialCode;
        partial void OnMaterialCodeChanging(string value);
        partial void OnMaterialCodeChanged();
        /// <summary>
        /// There are no comments for Property ShippingPrintText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ShippingPrintText
        {
            get
            {
                return this._ShippingPrintText;
            }
            set
            {
                this.OnShippingPrintTextChanging(value);
                this._ShippingPrintText = value;
                this.OnShippingPrintTextChanged();
                this.OnPropertyChanged("ShippingPrintText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShippingPrintText;
        partial void OnShippingPrintTextChanging(string value);
        partial void OnShippingPrintTextChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
