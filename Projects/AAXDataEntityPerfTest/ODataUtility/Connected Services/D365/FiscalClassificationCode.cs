﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for FiscalClassificationCodeSingle in the schema.
        /// </summary>
    public partial class FiscalClassificationCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalClassificationCode>
    {
        /// <summary>
        /// Initialize a new FiscalClassificationCodeSingle object.
        /// </summary>
        public FiscalClassificationCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalClassificationCodeSingle object.
        /// </summary>
        public FiscalClassificationCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalClassificationCodeSingle object.
        /// </summary>
        public FiscalClassificationCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalClassificationCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
    }
        /// <summary>
        /// There are no comments for FiscalClassificationCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FiscalClassificationCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FiscalClassificationCode")]
    [global::Microsoft.OData.Client.EntitySet("FiscalClassificationCodes")]
    public partial class FiscalClassificationCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalClassificationCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="fiscalClassificationCode1">Initial value of FiscalClassificationCode1.</param>
        /// <param name="approximateTaxRateForImportedProducts">Initial value of ApproximateTaxRateForImportedProducts.</param>
        /// <param name="approximateTaxRateForNationalProducts">Initial value of ApproximateTaxRateForNationalProducts.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalClassificationCode CreateFiscalClassificationCode(string dataAreaId, string fiscalClassificationCode1, decimal approximateTaxRateForImportedProducts, decimal approximateTaxRateForNationalProducts)
        {
            FiscalClassificationCode fiscalClassificationCode = new FiscalClassificationCode();
            fiscalClassificationCode.dataAreaId = dataAreaId;
            fiscalClassificationCode.FiscalClassificationCode1 = fiscalClassificationCode1;
            fiscalClassificationCode.ApproximateTaxRateForImportedProducts = approximateTaxRateForImportedProducts;
            fiscalClassificationCode.ApproximateTaxRateForNationalProducts = approximateTaxRateForNationalProducts;
            return fiscalClassificationCode;
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
        /// There are no comments for Property FiscalClassificationCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalClassificationCode")]
        public virtual string FiscalClassificationCode1
        {
            get
            {
                return this._FiscalClassificationCode1;
            }
            set
            {
                this.OnFiscalClassificationCode1Changing(value);
                this._FiscalClassificationCode1 = value;
                this.OnFiscalClassificationCode1Changed();
                this.OnPropertyChanged("FiscalClassificationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalClassificationCode1;
        partial void OnFiscalClassificationCode1Changing(string value);
        partial void OnFiscalClassificationCode1Changed();
        /// <summary>
        /// There are no comments for Property FiscalClassificationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FiscalClassificationName
        {
            get
            {
                return this._FiscalClassificationName;
            }
            set
            {
                this.OnFiscalClassificationNameChanging(value);
                this._FiscalClassificationName = value;
                this.OnFiscalClassificationNameChanged();
                this.OnPropertyChanged("FiscalClassificationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalClassificationName;
        partial void OnFiscalClassificationNameChanging(string value);
        partial void OnFiscalClassificationNameChanged();
        /// <summary>
        /// There are no comments for Property ApproximateTaxRateForImportedProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ApproximateTaxRateForImportedProducts
        {
            get
            {
                return this._ApproximateTaxRateForImportedProducts;
            }
            set
            {
                this.OnApproximateTaxRateForImportedProductsChanging(value);
                this._ApproximateTaxRateForImportedProducts = value;
                this.OnApproximateTaxRateForImportedProductsChanged();
                this.OnPropertyChanged("ApproximateTaxRateForImportedProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ApproximateTaxRateForImportedProducts;
        partial void OnApproximateTaxRateForImportedProductsChanging(decimal value);
        partial void OnApproximateTaxRateForImportedProductsChanged();
        /// <summary>
        /// There are no comments for Property ApproximateTaxRateForNationalProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal ApproximateTaxRateForNationalProducts
        {
            get
            {
                return this._ApproximateTaxRateForNationalProducts;
            }
            set
            {
                this.OnApproximateTaxRateForNationalProductsChanging(value);
                this._ApproximateTaxRateForNationalProducts = value;
                this.OnApproximateTaxRateForNationalProductsChanged();
                this.OnPropertyChanged("ApproximateTaxRateForNationalProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _ApproximateTaxRateForNationalProducts;
        partial void OnApproximateTaxRateForNationalProductsChanging(decimal value);
        partial void OnApproximateTaxRateForNationalProductsChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
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
