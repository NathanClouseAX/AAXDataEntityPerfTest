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
        /// There are no comments for RetailStoreAddressBookSingle in the schema.
        /// </summary>
    public partial class RetailStoreAddressBookSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreAddressBook>
    {
        /// <summary>
        /// Initialize a new RetailStoreAddressBookSingle object.
        /// </summary>
        public RetailStoreAddressBookSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreAddressBookSingle object.
        /// </summary>
        public RetailStoreAddressBookSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreAddressBookSingle object.
        /// </summary>
        public RetailStoreAddressBookSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreAddressBook> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannelSingle RetailChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailChannel == null))
                {
                    this._RetailChannel = new global::Microsoft.Dynamics.DataEntities.RetailChannelSingle(this.Context, GetPath("RetailChannel"));
                }
                return this._RetailChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannelSingle _RetailChannel;
        /// <summary>
        /// There are no comments for AddressBooks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressBooksSingle AddressBooks
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AddressBooks == null))
                {
                    this._AddressBooks = new global::Microsoft.Dynamics.DataEntities.AddressBooksSingle(this.Context, GetPath("AddressBooks"));
                }
                return this._AddressBooks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressBooksSingle _AddressBooks;
    }
        /// <summary>
        /// There are no comments for RetailStoreAddressBook in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RetailChannelId
    /// AddressBookName
    /// AddressBookType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RetailChannelId", "AddressBookName", "AddressBookType")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreAddressBooks")]
    public partial class RetailStoreAddressBook : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreAddressBook object.
        /// </summary>
        /// <param name="retailChannelId">Initial value of RetailChannelId.</param>
        /// <param name="addressBookName">Initial value of AddressBookName.</param>
        /// <param name="retailChannel">Initial value of RetailChannel.</param>
        /// <param name="addressBooks">Initial value of AddressBooks.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreAddressBook CreateRetailStoreAddressBook(string retailChannelId, string addressBookName, global::Microsoft.Dynamics.DataEntities.RetailChannel retailChannel, global::Microsoft.Dynamics.DataEntities.AddressBooks addressBooks)
        {
            RetailStoreAddressBook retailStoreAddressBook = new RetailStoreAddressBook();
            retailStoreAddressBook.RetailChannelId = retailChannelId;
            retailStoreAddressBook.AddressBookName = addressBookName;
            if ((retailChannel == null))
            {
                throw new global::System.ArgumentNullException("retailChannel");
            }
            retailStoreAddressBook.RetailChannel = retailChannel;
            if ((addressBooks == null))
            {
                throw new global::System.ArgumentNullException("addressBooks");
            }
            retailStoreAddressBook.AddressBooks = addressBooks;
            return retailStoreAddressBook;
        }
        /// <summary>
        /// There are no comments for Property RetailChannelId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailChannelId
        {
            get
            {
                return this._RetailChannelId;
            }
            set
            {
                this.OnRetailChannelIdChanging(value);
                this._RetailChannelId = value;
                this.OnRetailChannelIdChanged();
                this.OnPropertyChanged("RetailChannelId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailChannelId;
        partial void OnRetailChannelIdChanging(string value);
        partial void OnRetailChannelIdChanged();
        /// <summary>
        /// There are no comments for Property AddressBookName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AddressBookName
        {
            get
            {
                return this._AddressBookName;
            }
            set
            {
                this.OnAddressBookNameChanging(value);
                this._AddressBookName = value;
                this.OnAddressBookNameChanged();
                this.OnPropertyChanged("AddressBookName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AddressBookName;
        partial void OnAddressBookNameChanging(string value);
        partial void OnAddressBookNameChanged();
        /// <summary>
        /// There are no comments for Property AddressBookType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAddressBookType> AddressBookType
        {
            get
            {
                return this._AddressBookType;
            }
            set
            {
                this.OnAddressBookTypeChanging(value);
                this._AddressBookType = value;
                this.OnAddressBookTypeChanged();
                this.OnPropertyChanged("AddressBookType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAddressBookType> _AddressBookType;
        partial void OnAddressBookTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAddressBookType> value);
        partial void OnAddressBookTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RetailChannel RetailChannel
        {
            get
            {
                return this._RetailChannel;
            }
            set
            {
                this.OnRetailChannelChanging(value);
                this._RetailChannel = value;
                this.OnRetailChannelChanged();
                this.OnPropertyChanged("RetailChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RetailChannel _RetailChannel;
        partial void OnRetailChannelChanging(global::Microsoft.Dynamics.DataEntities.RetailChannel value);
        partial void OnRetailChannelChanged();
        /// <summary>
        /// There are no comments for Property AddressBooks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressBooks AddressBooks
        {
            get
            {
                return this._AddressBooks;
            }
            set
            {
                this.OnAddressBooksChanging(value);
                this._AddressBooks = value;
                this.OnAddressBooksChanged();
                this.OnPropertyChanged("AddressBooks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressBooks _AddressBooks;
        partial void OnAddressBooksChanging(global::Microsoft.Dynamics.DataEntities.AddressBooks value);
        partial void OnAddressBooksChanged();
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