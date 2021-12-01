﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for ItemShipTxtTranslationSingle in the schema.
    /// </summary>
    public partial class ItemShipTxtTranslationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemShipTxtTranslation>
    {
        /// <summary>
        /// Initialize a new ItemShipTxtTranslationSingle object.
        /// </summary>
        public ItemShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemShipTxtTranslationSingle object.
        /// </summary>
        public ItemShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemShipTxtTranslationSingle object.
        /// </summary>
        public ItemShipTxtTranslationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemShipTxtTranslation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ItemShipTxtTranslation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// LanguageId
    /// Material
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "LanguageId", "Material")]
    [global::Microsoft.OData.Client.EntitySet("ItemShipTxtTranslations")]
    public partial class ItemShipTxtTranslation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemShipTxtTranslation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="languageId">Initial value of LanguageId.</param>
        /// <param name="material">Initial value of Material.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemShipTxtTranslation CreateItemShipTxtTranslation(string dataAreaId, string languageId, long material)
        {
            ItemShipTxtTranslation itemShipTxtTranslation = new ItemShipTxtTranslation();
            itemShipTxtTranslation.dataAreaId = dataAreaId;
            itemShipTxtTranslation.LanguageId = languageId;
            itemShipTxtTranslation.Material = material;
            return itemShipTxtTranslation;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LanguageId is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Material is required.")]
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
        /// There are no comments for Property RegCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string RegCode
        {
            get
            {
                return this._RegCode;
            }
            set
            {
                this.OnRegCodeChanging(value);
                this._RegCode = value;
                this.OnRegCodeChanged();
                this.OnPropertyChanged("RegCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegCode;
        partial void OnRegCodeChanging(string value);
        partial void OnRegCodeChanged();
        /// <summary>
        /// There are no comments for Property ItemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ItemId
        {
            get
            {
                return this._ItemId;
            }
            set
            {
                this.OnItemIdChanging(value);
                this._ItemId = value;
                this.OnItemIdChanged();
                this.OnPropertyChanged("ItemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemId;
        partial void OnItemIdChanging(string value);
        partial void OnItemIdChanged();
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
