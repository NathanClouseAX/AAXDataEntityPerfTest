﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailKitComponentSubstituteSingle in the schema.
        /// </summary>
    public partial class RetailKitComponentSubstituteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitComponentSubstitute>
    {
        /// <summary>
        /// Initialize a new RetailKitComponentSubstituteSingle object.
        /// </summary>
        public RetailKitComponentSubstituteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailKitComponentSubstituteSingle object.
        /// </summary>
        public RetailKitComponentSubstituteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailKitComponentSubstituteSingle object.
        /// </summary>
        public RetailKitComponentSubstituteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitComponentSubstitute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailKitComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitComponentSingle RetailKitComponent
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitComponent == null))
                {
                    this._RetailKitComponent = new global::Microsoft.Dynamics.DataEntities.RetailKitComponentSingle(this.Context, GetPath("RetailKitComponent"));
                }
                return this._RetailKitComponent;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitComponentSingle _RetailKitComponent;
        /// <summary>
        /// There are no comments for RetailKitReleasedSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute> RetailKitReleasedSubstitute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitReleasedSubstitute == null))
                {
                    this._RetailKitReleasedSubstitute = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute>(GetPath("RetailKitReleasedSubstitute"));
                }
                return this._RetailKitReleasedSubstitute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute> _RetailKitReleasedSubstitute;
    }
        /// <summary>
        /// There are no comments for RetailKitComponentSubstitute in the schema.
        /// </summary>
    /// <KeyProperties>
    /// KitProductNumber
    /// KitComponentLineNumber
    /// SubstituteProductNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KitProductNumber", "KitComponentLineNumber", "SubstituteProductNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailKitComponentSubstitutes")]
    public partial class RetailKitComponentSubstitute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailKitComponentSubstitute object.
        /// </summary>
        /// <param name="kitProductNumber">Initial value of KitProductNumber.</param>
        /// <param name="kitComponentLineNumber">Initial value of KitComponentLineNumber.</param>
        /// <param name="substituteProductNumber">Initial value of SubstituteProductNumber.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="retailKitComponent">Initial value of RetailKitComponent.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailKitComponentSubstitute CreateRetailKitComponentSubstitute(string kitProductNumber, decimal kitComponentLineNumber, string substituteProductNumber, decimal quantity, global::Microsoft.Dynamics.DataEntities.RetailKitComponent retailKitComponent)
        {
            RetailKitComponentSubstitute retailKitComponentSubstitute = new RetailKitComponentSubstitute();
            retailKitComponentSubstitute.KitProductNumber = kitProductNumber;
            retailKitComponentSubstitute.KitComponentLineNumber = kitComponentLineNumber;
            retailKitComponentSubstitute.SubstituteProductNumber = substituteProductNumber;
            retailKitComponentSubstitute.Quantity = quantity;
            if ((retailKitComponent == null))
            {
                throw new global::System.ArgumentNullException("retailKitComponent");
            }
            retailKitComponentSubstitute.RetailKitComponent = retailKitComponent;
            return retailKitComponentSubstitute;
        }
        /// <summary>
        /// There are no comments for Property KitProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KitProductNumber
        {
            get
            {
                return this._KitProductNumber;
            }
            set
            {
                this.OnKitProductNumberChanging(value);
                this._KitProductNumber = value;
                this.OnKitProductNumberChanged();
                this.OnPropertyChanged("KitProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitProductNumber;
        partial void OnKitProductNumberChanging(string value);
        partial void OnKitProductNumberChanged();
        /// <summary>
        /// There are no comments for Property KitComponentLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal KitComponentLineNumber
        {
            get
            {
                return this._KitComponentLineNumber;
            }
            set
            {
                this.OnKitComponentLineNumberChanging(value);
                this._KitComponentLineNumber = value;
                this.OnKitComponentLineNumberChanged();
                this.OnPropertyChanged("KitComponentLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _KitComponentLineNumber;
        partial void OnKitComponentLineNumberChanging(decimal value);
        partial void OnKitComponentLineNumberChanged();
        /// <summary>
        /// There are no comments for Property SubstituteProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SubstituteProductNumber
        {
            get
            {
                return this._SubstituteProductNumber;
            }
            set
            {
                this.OnSubstituteProductNumberChanging(value);
                this._SubstituteProductNumber = value;
                this.OnSubstituteProductNumberChanged();
                this.OnPropertyChanged("SubstituteProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubstituteProductNumber;
        partial void OnSubstituteProductNumberChanging(string value);
        partial void OnSubstituteProductNumberChanged();
        /// <summary>
        /// There are no comments for Property UnitOfMeasureSymbol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnitOfMeasureSymbol
        {
            get
            {
                return this._UnitOfMeasureSymbol;
            }
            set
            {
                this.OnUnitOfMeasureSymbolChanging(value);
                this._UnitOfMeasureSymbol = value;
                this.OnUnitOfMeasureSymbolChanged();
                this.OnPropertyChanged("UnitOfMeasureSymbol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitOfMeasureSymbol;
        partial void OnUnitOfMeasureSymbolChanging(string value);
        partial void OnUnitOfMeasureSymbolChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Quantity;
        partial void OnQuantityChanging(decimal value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property RetailKitComponent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitComponent RetailKitComponent
        {
            get
            {
                return this._RetailKitComponent;
            }
            set
            {
                this.OnRetailKitComponentChanging(value);
                this._RetailKitComponent = value;
                this.OnRetailKitComponentChanged();
                this.OnPropertyChanged("RetailKitComponent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitComponent _RetailKitComponent;
        partial void OnRetailKitComponentChanging(global::Microsoft.Dynamics.DataEntities.RetailKitComponent value);
        partial void OnRetailKitComponentChanged();
        /// <summary>
        /// There are no comments for Property RetailKitReleasedSubstitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute> RetailKitReleasedSubstitute
        {
            get
            {
                return this._RetailKitReleasedSubstitute;
            }
            set
            {
                this.OnRetailKitReleasedSubstituteChanging(value);
                this._RetailKitReleasedSubstitute = value;
                this.OnRetailKitReleasedSubstituteChanged();
                this.OnPropertyChanged("RetailKitReleasedSubstitute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute> _RetailKitReleasedSubstitute = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailKitReleasedSubstituteChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitReleasedSubstitute> value);
        partial void OnRetailKitReleasedSubstituteChanged();
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
