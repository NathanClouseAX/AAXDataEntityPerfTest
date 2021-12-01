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
    /// There are no comments for RetailKitOrderJournalSingle in the schema.
    /// </summary>
    public partial class RetailKitOrderJournalSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitOrderJournal>
    {
        /// <summary>
        /// Initialize a new RetailKitOrderJournalSingle object.
        /// </summary>
        public RetailKitOrderJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailKitOrderJournalSingle object.
        /// </summary>
        public RetailKitOrderJournalSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailKitOrderJournalSingle object.
        /// </summary>
        public RetailKitOrderJournalSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailKitOrderJournal> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailKitOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitOrderSingle RetailKitOrder
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailKitOrder == null))
                {
                    this._RetailKitOrder = new global::Microsoft.Dynamics.DataEntities.RetailKitOrderSingle(this.Context, GetPath("RetailKitOrder"));
                }
                return this._RetailKitOrder;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitOrderSingle _RetailKitOrder;
    }
    /// <summary>
    /// There are no comments for RetailKitOrderJournal in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KitProductNumber
    /// KitConfigId
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KitProductNumber", "KitConfigId", "Name")]
    [global::Microsoft.OData.Client.EntitySet("RetailKitOrderJournals")]
    public partial class RetailKitOrderJournal : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailKitOrderJournal object.
        /// </summary>
        /// <param name="kitProductNumber">Initial value of KitProductNumber.</param>
        /// <param name="kitConfigId">Initial value of KitConfigId.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        /// <param name="kitOrder">Initial value of KitOrder.</param>
        /// <param name="retailKitOrder">Initial value of RetailKitOrder.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailKitOrderJournal CreateRetailKitOrderJournal(string kitProductNumber, 
                    string kitConfigId, 
                    string name, 
                    decimal quantity, 
                    long kitOrder, 
                    global::Microsoft.Dynamics.DataEntities.RetailKitOrder retailKitOrder)
        {
            RetailKitOrderJournal retailKitOrderJournal = new RetailKitOrderJournal();
            retailKitOrderJournal.KitProductNumber = kitProductNumber;
            retailKitOrderJournal.KitConfigId = kitConfigId;
            retailKitOrderJournal.Name = name;
            retailKitOrderJournal.Quantity = quantity;
            retailKitOrderJournal.KitOrder = kitOrder;
            if ((retailKitOrder == null))
            {
                throw new global::System.ArgumentNullException("retailKitOrder");
            }
            retailKitOrderJournal.RetailKitOrder = retailKitOrder;
            return retailKitOrderJournal;
        }
        /// <summary>
        /// There are no comments for Property KitProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "KitProductNumber is required.")]
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
        /// There are no comments for Property KitConfigId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "KitConfigId is required.")]
        public virtual string KitConfigId
        {
            get
            {
                return this._KitConfigId;
            }
            set
            {
                this.OnKitConfigIdChanging(value);
                this._KitConfigId = value;
                this.OnKitConfigIdChanged();
                this.OnPropertyChanged("KitConfigId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitConfigId;
        partial void OnKitConfigIdChanging(string value);
        partial void OnKitConfigIdChanged();
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
        /// There are no comments for Property JournalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string JournalId
        {
            get
            {
                return this._JournalId;
            }
            set
            {
                this.OnJournalIdChanging(value);
                this._JournalId = value;
                this.OnJournalIdChanged();
                this.OnPropertyChanged("JournalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalId;
        partial void OnJournalIdChanging(string value);
        partial void OnJournalIdChanged();
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
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Quantity is required.")]
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
        /// There are no comments for Property KitOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "KitOrder is required.")]
        public virtual long KitOrder
        {
            get
            {
                return this._KitOrder;
            }
            set
            {
                this.OnKitOrderChanging(value);
                this._KitOrder = value;
                this.OnKitOrderChanged();
                this.OnPropertyChanged("KitOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _KitOrder;
        partial void OnKitOrderChanging(long value);
        partial void OnKitOrderChanged();
        /// <summary>
        /// There are no comments for Property RetailKitOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RetailKitOrder is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailKitOrder RetailKitOrder
        {
            get
            {
                return this._RetailKitOrder;
            }
            set
            {
                this.OnRetailKitOrderChanging(value);
                this._RetailKitOrder = value;
                this.OnRetailKitOrderChanged();
                this.OnPropertyChanged("RetailKitOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailKitOrder _RetailKitOrder;
        partial void OnRetailKitOrderChanging(global::Microsoft.Dynamics.DataEntities.RetailKitOrder value);
        partial void OnRetailKitOrderChanged();
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
