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
        /// There are no comments for RetailStoreLocatorGroupOwnerSingle in the schema.
        /// </summary>
    public partial class RetailStoreLocatorGroupOwnerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreLocatorGroupOwner>
    {
        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupOwnerSingle object.
        /// </summary>
        public RetailStoreLocatorGroupOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupOwnerSingle object.
        /// </summary>
        public RetailStoreLocatorGroupOwnerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailStoreLocatorGroupOwnerSingle object.
        /// </summary>
        public RetailStoreLocatorGroupOwnerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailStoreLocatorGroupOwner> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle OnlineChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OnlineChannel == null))
                {
                    this._OnlineChannel = new global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle(this.Context, GetPath("OnlineChannel"));
                }
                return this._OnlineChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle _OnlineChannel;
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
        /// There are no comments for RetailStoreLocatorGroupOwner in the schema.
        /// </summary>
    /// <KeyProperties>
    /// StoreLocatorGroupName
    /// OMOperatingUnitNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("StoreLocatorGroupName", "OMOperatingUnitNumber")]
    [global::Microsoft.OData.Client.EntitySet("RetailStoreLocatorGroupOwners")]
    public partial class RetailStoreLocatorGroupOwner : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailStoreLocatorGroupOwner object.
        /// </summary>
        /// <param name="storeLocatorGroupName">Initial value of StoreLocatorGroupName.</param>
        /// <param name="oMOperatingUnitNumber">Initial value of OMOperatingUnitNumber.</param>
        /// <param name="onlineChannel">Initial value of OnlineChannel.</param>
        /// <param name="retailStore">Initial value of RetailStore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailStoreLocatorGroupOwner CreateRetailStoreLocatorGroupOwner(string storeLocatorGroupName, string oMOperatingUnitNumber, global::Microsoft.Dynamics.DataEntities.OnlineChannel onlineChannel, global::Microsoft.Dynamics.DataEntities.RetailStore retailStore)
        {
            RetailStoreLocatorGroupOwner retailStoreLocatorGroupOwner = new RetailStoreLocatorGroupOwner();
            retailStoreLocatorGroupOwner.StoreLocatorGroupName = storeLocatorGroupName;
            retailStoreLocatorGroupOwner.OMOperatingUnitNumber = oMOperatingUnitNumber;
            if ((onlineChannel == null))
            {
                throw new global::System.ArgumentNullException("onlineChannel");
            }
            retailStoreLocatorGroupOwner.OnlineChannel = onlineChannel;
            if ((retailStore == null))
            {
                throw new global::System.ArgumentNullException("retailStore");
            }
            retailStoreLocatorGroupOwner.RetailStore = retailStore;
            return retailStoreLocatorGroupOwner;
        }
        /// <summary>
        /// There are no comments for Property StoreLocatorGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StoreLocatorGroupName
        {
            get
            {
                return this._StoreLocatorGroupName;
            }
            set
            {
                this.OnStoreLocatorGroupNameChanging(value);
                this._StoreLocatorGroupName = value;
                this.OnStoreLocatorGroupNameChanged();
                this.OnPropertyChanged("StoreLocatorGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StoreLocatorGroupName;
        partial void OnStoreLocatorGroupNameChanging(string value);
        partial void OnStoreLocatorGroupNameChanged();
        /// <summary>
        /// There are no comments for Property OMOperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OMOperatingUnitNumber
        {
            get
            {
                return this._OMOperatingUnitNumber;
            }
            set
            {
                this.OnOMOperatingUnitNumberChanging(value);
                this._OMOperatingUnitNumber = value;
                this.OnOMOperatingUnitNumberChanged();
                this.OnPropertyChanged("OMOperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OMOperatingUnitNumber;
        partial void OnOMOperatingUnitNumberChanging(string value);
        partial void OnOMOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannel OnlineChannel
        {
            get
            {
                return this._OnlineChannel;
            }
            set
            {
                this.OnOnlineChannelChanging(value);
                this._OnlineChannel = value;
                this.OnOnlineChannelChanged();
                this.OnPropertyChanged("OnlineChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnlineChannel _OnlineChannel;
        partial void OnOnlineChannelChanging(global::Microsoft.Dynamics.DataEntities.OnlineChannel value);
        partial void OnOnlineChannelChanged();
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
