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
    /// There are no comments for RetailLoyaltySingle in the schema.
    /// </summary>
    public partial class RetailLoyaltySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailLoyalty>
    {
        /// <summary>
        /// Initialize a new RetailLoyaltySingle object.
        /// </summary>
        public RetailLoyaltySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailLoyaltySingle object.
        /// </summary>
        public RetailLoyaltySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailLoyaltySingle object.
        /// </summary>
        public RetailLoyaltySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailLoyalty> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailLoyaltyPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> RetailLoyaltyPriceGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailLoyaltyPriceGroup == null))
                {
                    this._RetailLoyaltyPriceGroup = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup>(GetPath("RetailLoyaltyPriceGroup"));
                }
                return this._RetailLoyaltyPriceGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> _RetailLoyaltyPriceGroup;
    }
    /// <summary>
    /// There are no comments for RetailLoyalty in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("RetailLoyalties")]
    public partial class RetailLoyalty : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailLoyalty object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailLoyalty CreateRetailLoyalty(string name)
        {
            RetailLoyalty retailLoyalty = new RetailLoyalty();
            retailLoyalty.Name = name;
            return retailLoyalty;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property PoolRelatedCards in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> PoolRelatedCards
        {
            get
            {
                return this._PoolRelatedCards;
            }
            set
            {
                this.OnPoolRelatedCardsChanging(value);
                this._PoolRelatedCards = value;
                this.OnPoolRelatedCardsChanged();
                this.OnPropertyChanged("PoolRelatedCards");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _PoolRelatedCards;
        partial void OnPoolRelatedCardsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPoolRelatedCardsChanged();
        /// <summary>
        /// There are no comments for Property RetailLoyaltyPriceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> RetailLoyaltyPriceGroup
        {
            get
            {
                return this._RetailLoyaltyPriceGroup;
            }
            set
            {
                this.OnRetailLoyaltyPriceGroupChanging(value);
                this._RetailLoyaltyPriceGroup = value;
                this.OnRetailLoyaltyPriceGroupChanged();
                this.OnPropertyChanged("RetailLoyaltyPriceGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> _RetailLoyaltyPriceGroup = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailLoyaltyPriceGroupChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailLoyaltyPriceGroup> value);
        partial void OnRetailLoyaltyPriceGroupChanged();
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
