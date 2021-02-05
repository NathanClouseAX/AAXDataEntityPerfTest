﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for SalesBookVATProcessParameterSingle in the schema.
        /// </summary>
    public partial class SalesBookVATProcessParameterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesBookVATProcessParameter>
    {
        /// <summary>
        /// Initialize a new SalesBookVATProcessParameterSingle object.
        /// </summary>
        public SalesBookVATProcessParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesBookVATProcessParameterSingle object.
        /// </summary>
        public SalesBookVATProcessParameterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesBookVATProcessParameterSingle object.
        /// </summary>
        public SalesBookVATProcessParameterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesBookVATProcessParameter> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for SalesBookVATProcessParameter in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// VATOperationCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "VATOperationCode")]
    [global::Microsoft.OData.Client.EntitySet("SalesBookVATProcessParameters")]
    public partial class SalesBookVATProcessParameter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesBookVATProcessParameter object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="vATOperationCode">Initial value of VATOperationCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesBookVATProcessParameter CreateSalesBookVATProcessParameter(string dataAreaId, string vATOperationCode)
        {
            SalesBookVATProcessParameter salesBookVATProcessParameter = new SalesBookVATProcessParameter();
            salesBookVATProcessParameter.dataAreaId = dataAreaId;
            salesBookVATProcessParameter.VATOperationCode = vATOperationCode;
            return salesBookVATProcessParameter;
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
        /// There are no comments for Property VATOperationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string VATOperationCode
        {
            get
            {
                return this._VATOperationCode;
            }
            set
            {
                this.OnVATOperationCodeChanging(value);
                this._VATOperationCode = value;
                this.OnVATOperationCodeChanged();
                this.OnPropertyChanged("VATOperationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VATOperationCode;
        partial void OnVATOperationCodeChanging(string value);
        partial void OnVATOperationCodeChanged();
        /// <summary>
        /// There are no comments for Property OperationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookProcessingType_RU> OperationType
        {
            get
            {
                return this._OperationType;
            }
            set
            {
                this.OnOperationTypeChanging(value);
                this._OperationType = value;
                this.OnOperationTypeChanged();
                this.OnPropertyChanged("OperationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookProcessingType_RU> _OperationType;
        partial void OnOperationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookProcessingType_RU> value);
        partial void OnOperationTypeChanged();
        /// <summary>
        /// There are no comments for Property IncludeInBook in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IncludeInBook
        {
            get
            {
                return this._IncludeInBook;
            }
            set
            {
                this.OnIncludeInBookChanging(value);
                this._IncludeInBook = value;
                this.OnIncludeInBookChanged();
                this.OnPropertyChanged("IncludeInBook");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IncludeInBook;
        partial void OnIncludeInBookChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIncludeInBookChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> DefaultDimensionEnabled
        {
            get
            {
                return this._DefaultDimensionEnabled;
            }
            set
            {
                this.OnDefaultDimensionEnabledChanging(value);
                this._DefaultDimensionEnabled = value;
                this.OnDefaultDimensionEnabledChanged();
                this.OnPropertyChanged("DefaultDimensionEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _DefaultDimensionEnabled;
        partial void OnDefaultDimensionEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnDefaultDimensionEnabledChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsDefault
        {
            get
            {
                return this._IsDefault;
            }
            set
            {
                this.OnIsDefaultChanging(value);
                this._IsDefault = value;
                this.OnIsDefaultChanged();
                this.OnPropertyChanged("IsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsDefault;
        partial void OnIsDefaultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsDefaultChanged();
        /// <summary>
        /// There are no comments for Property RestorationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookVATRestoringType_RU> RestorationType
        {
            get
            {
                return this._RestorationType;
            }
            set
            {
                this.OnRestorationTypeChanging(value);
                this._RestorationType = value;
                this.OnRestorationTypeChanged();
                this.OnPropertyChanged("RestorationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookVATRestoringType_RU> _RestorationType;
        partial void OnRestorationTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.SalesBookVATRestoringType_RU> value);
        partial void OnRestorationTypeChanged();
        /// <summary>
        /// There are no comments for Property FactureOperationTypeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FactureOperationTypeCode
        {
            get
            {
                return this._FactureOperationTypeCode;
            }
            set
            {
                this.OnFactureOperationTypeCodeChanging(value);
                this._FactureOperationTypeCode = value;
                this.OnFactureOperationTypeCodeChanged();
                this.OnPropertyChanged("FactureOperationTypeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FactureOperationTypeCode;
        partial void OnFactureOperationTypeCodeChanging(string value);
        partial void OnFactureOperationTypeCodeChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
