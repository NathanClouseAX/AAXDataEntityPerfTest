﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailKitOrderSingle in the schema.
        /// </summary>
    public partial class RetailKitOrderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitOrder>
    {
        /// <summary>
        /// Initialize a new RetailKitOrderSingle object.
        /// </summary>
        public RetailKitOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailKitOrderSingle object.
        /// </summary>
        public RetailKitOrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailKitOrderSingle object.
        /// </summary>
        public RetailKitOrderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitOrder> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailKitOrderJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal> RetailKitOrderJournal
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitOrderJournal == null))
                {
                    this._RetailKitOrderJournal = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal>(GetPath("RetailKitOrderJournal"));
                }
                return this._RetailKitOrderJournal;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal> _RetailKitOrderJournal;
        /// <summary>
        /// There are no comments for RetailKit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitSingle RetailKit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKit == null))
                {
                    this._RetailKit = new global::Microsoft.Dynamics.DataEntities.RetailKitSingle(this.Context, GetPath("RetailKit"));
                }
                return this._RetailKit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitSingle _RetailKit;
    }
        /// <summary>
        /// There are no comments for RetailKitOrder in the schema.
        /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("RetailKitOrders")]
    public partial class RetailKitOrder : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailKitOrder object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="kit">Initial value of Kit.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="retailKit">Initial value of RetailKit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailKitOrder CreateRetailKitOrder(string name, long kit, decimal quantity, global::Microsoft.Dynamics.DataEntities.RetailKit retailKit)
        {
            RetailKitOrder retailKitOrder = new RetailKitOrder();
            retailKitOrder.Name = name;
            retailKitOrder.Kit = kit;
            retailKitOrder.Quantity = quantity;
            if ((retailKit == null))
            {
                throw new global::System.ArgumentNullException("retailKit");
            }
            retailKitOrder.RetailKit = retailKit;
            return retailKitOrder;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property OrderSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderSource> OrderSource
        {
            get
            {
                return this._OrderSource;
            }
            set
            {
                this.OnOrderSourceChanging(value);
                this._OrderSource = value;
                this.OnOrderSourceChanged();
                this.OnPropertyChanged("OrderSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderSource> _OrderSource;
        partial void OnOrderSourceChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderSource> value);
        partial void OnOrderSourceChanged();
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
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property Kit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long Kit
        {
            get
            {
                return this._Kit;
            }
            set
            {
                this.OnKitChanging(value);
                this._Kit = value;
                this.OnKitChanged();
                this.OnPropertyChanged("Kit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Kit;
        partial void OnKitChanging(long value);
        partial void OnKitChanged();
        /// <summary>
        /// There are no comments for Property Warehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Warehouse
        {
            get
            {
                return this._Warehouse;
            }
            set
            {
                this.OnWarehouseChanging(value);
                this._Warehouse = value;
                this.OnWarehouseChanged();
                this.OnPropertyChanged("Warehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Warehouse;
        partial void OnWarehouseChanging(string value);
        partial void OnWarehouseChanged();
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
        /// There are no comments for Property IsAssembly in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAssembly
        {
            get
            {
                return this._IsAssembly;
            }
            set
            {
                this.OnIsAssemblyChanging(value);
                this._IsAssembly = value;
                this.OnIsAssemblyChanged();
                this.OnPropertyChanged("IsAssembly");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAssembly;
        partial void OnIsAssemblyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAssemblyChanged();
        /// <summary>
        /// There are no comments for Property OrderType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderType> OrderType
        {
            get
            {
                return this._OrderType;
            }
            set
            {
                this.OnOrderTypeChanging(value);
                this._OrderType = value;
                this.OnOrderTypeChanged();
                this.OnPropertyChanged("OrderType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderType> _OrderType;
        partial void OnOrderTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailKitOrderType> value);
        partial void OnOrderTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailKitOrderJournal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal> RetailKitOrderJournal
        {
            get
            {
                return this._RetailKitOrderJournal;
            }
            set
            {
                this.OnRetailKitOrderJournalChanging(value);
                this._RetailKitOrderJournal = value;
                this.OnRetailKitOrderJournalChanged();
                this.OnPropertyChanged("RetailKitOrderJournal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal> _RetailKitOrderJournal = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailKitOrderJournalChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailKitOrderJournal> value);
        partial void OnRetailKitOrderJournalChanged();
        /// <summary>
        /// There are no comments for Property RetailKit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKit RetailKit
        {
            get
            {
                return this._RetailKit;
            }
            set
            {
                this.OnRetailKitChanging(value);
                this._RetailKit = value;
                this.OnRetailKitChanged();
                this.OnPropertyChanged("RetailKit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKit _RetailKit;
        partial void OnRetailKitChanging(global::Microsoft.Dynamics.DataEntities.RetailKit value);
        partial void OnRetailKitChanged();
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
