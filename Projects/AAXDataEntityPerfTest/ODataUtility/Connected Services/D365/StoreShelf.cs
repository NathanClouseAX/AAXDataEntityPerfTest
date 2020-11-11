﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/8/2020 8:07:52 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for StoreShelfSingle in the schema.
        /// </summary>
    public partial class StoreShelfSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<StoreShelf>
    {
        /// <summary>
        /// Initialize a new StoreShelfSingle object.
        /// </summary>
        public StoreShelfSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new StoreShelfSingle object.
        /// </summary>
        public StoreShelfSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new StoreShelfSingle object.
        /// </summary>
        public StoreShelfSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<StoreShelf> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStoreSingle RetailStore
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStore == null))
                {
                    this._RetailStore = new global::Microsoft.Dynamics.DataEntities.RetailStoreSingle(this.Context, GetPath("RetailStore"));
                }
                return this._RetailStore;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStoreSingle _RetailStore;
    }
        /// <summary>
        /// There are no comments for StoreShelf in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// StoreNumber
    /// SectionNumber
    /// ShelfNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "StoreNumber", "SectionNumber", "ShelfNumber")]
    [global::Microsoft.OData.Client.EntitySet("StoreShelves")]
    public partial class StoreShelf : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new StoreShelf object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="storeNumber">Initial value of StoreNumber.</param>
        /// <param name="sectionNumber">Initial value of SectionNumber.</param>
        /// <param name="shelfNumber">Initial value of ShelfNumber.</param>
        /// <param name="sectionPercent">Initial value of SectionPercent.</param>
        /// <param name="retailStore">Initial value of RetailStore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static StoreShelf CreateStoreShelf(string dataAreaId, 
                    string storeNumber, 
                    string sectionNumber, 
                    string shelfNumber, 
                    decimal sectionPercent, 
                    global::Microsoft.Dynamics.DataEntities.RetailStore retailStore)
        {
            StoreShelf storeShelf = new StoreShelf();
            storeShelf.dataAreaId = dataAreaId;
            storeShelf.StoreNumber = storeNumber;
            storeShelf.SectionNumber = sectionNumber;
            storeShelf.ShelfNumber = shelfNumber;
            storeShelf.SectionPercent = sectionPercent;
            if ((retailStore == null))
            {
                throw new global::System.ArgumentNullException("retailStore");
            }
            storeShelf.RetailStore = retailStore;
            return storeShelf;
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
        /// There are no comments for Property StoreNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StoreNumber
        {
            get
            {
                return this._StoreNumber;
            }
            set
            {
                this.OnStoreNumberChanging(value);
                this._StoreNumber = value;
                this.OnStoreNumberChanged();
                this.OnPropertyChanged("StoreNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreNumber;
        partial void OnStoreNumberChanging(string value);
        partial void OnStoreNumberChanged();
        /// <summary>
        /// There are no comments for Property SectionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string SectionNumber
        {
            get
            {
                return this._SectionNumber;
            }
            set
            {
                this.OnSectionNumberChanging(value);
                this._SectionNumber = value;
                this.OnSectionNumberChanged();
                this.OnPropertyChanged("SectionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SectionNumber;
        partial void OnSectionNumberChanging(string value);
        partial void OnSectionNumberChanged();
        /// <summary>
        /// There are no comments for Property ShelfNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ShelfNumber
        {
            get
            {
                return this._ShelfNumber;
            }
            set
            {
                this.OnShelfNumberChanging(value);
                this._ShelfNumber = value;
                this.OnShelfNumberChanged();
                this.OnPropertyChanged("ShelfNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShelfNumber;
        partial void OnShelfNumberChanging(string value);
        partial void OnShelfNumberChanged();
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
        /// There are no comments for Property SectionPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal SectionPercent
        {
            get
            {
                return this._SectionPercent;
            }
            set
            {
                this.OnSectionPercentChanging(value);
                this._SectionPercent = value;
                this.OnSectionPercentChanged();
                this.OnPropertyChanged("SectionPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _SectionPercent;
        partial void OnSectionPercentChanging(decimal value);
        partial void OnSectionPercentChanged();
        /// <summary>
        /// There are no comments for Property RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailStore RetailStore
        {
            get
            {
                return this._RetailStore;
            }
            set
            {
                this.OnRetailStoreChanging(value);
                this._RetailStore = value;
                this.OnRetailStoreChanged();
                this.OnPropertyChanged("RetailStore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailStore _RetailStore;
        partial void OnRetailStoreChanging(global::Microsoft.Dynamics.DataEntities.RetailStore value);
        partial void OnRetailStoreChanged();
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