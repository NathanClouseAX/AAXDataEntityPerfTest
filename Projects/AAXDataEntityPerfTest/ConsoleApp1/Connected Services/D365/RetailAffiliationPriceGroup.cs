﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:24:13 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for RetailAffiliationPriceGroupSingle in the schema.
    /// </summary>
    public partial class RetailAffiliationPriceGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailAffiliationPriceGroup>
    {
        /// <summary>
        /// Initialize a new RetailAffiliationPriceGroupSingle object.
        /// </summary>
        public RetailAffiliationPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailAffiliationPriceGroupSingle object.
        /// </summary>
        public RetailAffiliationPriceGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailAffiliationPriceGroupSingle object.
        /// </summary>
        public RetailAffiliationPriceGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailAffiliationPriceGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PriceCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle PriceCustomerGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PriceCustomerGroup == null))
                {
                    this._PriceCustomerGroup = new global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle(this.Context, GetPath("PriceCustomerGroup"));
                }
                return this._PriceCustomerGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PriceCustomerGroupSingle _PriceCustomerGroup;
        /// <summary>
        /// There are no comments for RetailAffiliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle RetailAffiliation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailAffiliation == null))
                {
                    this._RetailAffiliation = new global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle(this.Context, GetPath("RetailAffiliation"));
                }
                return this._RetailAffiliation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailAffiliationSingle _RetailAffiliation;
    }
    /// <summary>
    /// There are no comments for RetailAffiliationPriceGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AffiliationName
    /// PriceCustomerGroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AffiliationName", "PriceCustomerGroupCode")]
    [global::Microsoft.OData.Client.EntitySet("RetailAffiliationPriceGroups")]
    public partial class RetailAffiliationPriceGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailAffiliationPriceGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="affiliationName">Initial value of AffiliationName.</param>
        /// <param name="priceCustomerGroupCode">Initial value of PriceCustomerGroupCode.</param>
        /// <param name="priceCustomerGroup">Initial value of PriceCustomerGroup.</param>
        /// <param name="retailAffiliation">Initial value of RetailAffiliation.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailAffiliationPriceGroup CreateRetailAffiliationPriceGroup(string dataAreaId, string affiliationName, string priceCustomerGroupCode, global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup priceCustomerGroup, global::Microsoft.Dynamics.DataEntities.RetailAffiliation retailAffiliation)
        {
            RetailAffiliationPriceGroup retailAffiliationPriceGroup = new RetailAffiliationPriceGroup();
            retailAffiliationPriceGroup.dataAreaId = dataAreaId;
            retailAffiliationPriceGroup.AffiliationName = affiliationName;
            retailAffiliationPriceGroup.PriceCustomerGroupCode = priceCustomerGroupCode;
            if ((priceCustomerGroup == null))
            {
                throw new global::System.ArgumentNullException("priceCustomerGroup");
            }
            retailAffiliationPriceGroup.PriceCustomerGroup = priceCustomerGroup;
            if ((retailAffiliation == null))
            {
                throw new global::System.ArgumentNullException("retailAffiliation");
            }
            retailAffiliationPriceGroup.RetailAffiliation = retailAffiliation;
            return retailAffiliationPriceGroup;
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
        /// There are no comments for Property AffiliationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AffiliationName
        {
            get
            {
                return this._AffiliationName;
            }
            set
            {
                this.OnAffiliationNameChanging(value);
                this._AffiliationName = value;
                this.OnAffiliationNameChanged();
                this.OnPropertyChanged("AffiliationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AffiliationName;
        partial void OnAffiliationNameChanging(string value);
        partial void OnAffiliationNameChanged();
        /// <summary>
        /// There are no comments for Property PriceCustomerGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PriceCustomerGroupCode
        {
            get
            {
                return this._PriceCustomerGroupCode;
            }
            set
            {
                this.OnPriceCustomerGroupCodeChanging(value);
                this._PriceCustomerGroupCode = value;
                this.OnPriceCustomerGroupCodeChanged();
                this.OnPropertyChanged("PriceCustomerGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceCustomerGroupCode;
        partial void OnPriceCustomerGroupCodeChanging(string value);
        partial void OnPriceCustomerGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property PriceCustomerGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup PriceCustomerGroup
        {
            get
            {
                return this._PriceCustomerGroup;
            }
            set
            {
                this.OnPriceCustomerGroupChanging(value);
                this._PriceCustomerGroup = value;
                this.OnPriceCustomerGroupChanged();
                this.OnPropertyChanged("PriceCustomerGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup _PriceCustomerGroup;
        partial void OnPriceCustomerGroupChanging(global::Microsoft.Dynamics.DataEntities.PriceCustomerGroup value);
        partial void OnPriceCustomerGroupChanged();
        /// <summary>
        /// There are no comments for Property RetailAffiliation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailAffiliation RetailAffiliation
        {
            get
            {
                return this._RetailAffiliation;
            }
            set
            {
                this.OnRetailAffiliationChanging(value);
                this._RetailAffiliation = value;
                this.OnRetailAffiliationChanged();
                this.OnPropertyChanged("RetailAffiliation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailAffiliation _RetailAffiliation;
        partial void OnRetailAffiliationChanging(global::Microsoft.Dynamics.DataEntities.RetailAffiliation value);
        partial void OnRetailAffiliationChanged();
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
