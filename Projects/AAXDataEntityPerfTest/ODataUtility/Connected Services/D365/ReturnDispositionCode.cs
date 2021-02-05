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
        /// There are no comments for ReturnDispositionCodeSingle in the schema.
        /// </summary>
    public partial class ReturnDispositionCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReturnDispositionCode>
    {
        /// <summary>
        /// Initialize a new ReturnDispositionCodeSingle object.
        /// </summary>
        public ReturnDispositionCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReturnDispositionCodeSingle object.
        /// </summary>
        public ReturnDispositionCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReturnDispositionCodeSingle object.
        /// </summary>
        public ReturnDispositionCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReturnDispositionCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ItemArrivalJournalLinesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2> ItemArrivalJournalLinesV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ItemArrivalJournalLinesV2 == null))
                {
                    this._ItemArrivalJournalLinesV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2>(GetPath("ItemArrivalJournalLinesV2"));
                }
                return this._ItemArrivalJournalLinesV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2> _ItemArrivalJournalLinesV2;
        /// <summary>
        /// There are no comments for ItemArrivalJournalHeadersV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2> ItemArrivalJournalHeadersV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ItemArrivalJournalHeadersV2 == null))
                {
                    this._ItemArrivalJournalHeadersV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2>(GetPath("ItemArrivalJournalHeadersV2"));
                }
                return this._ItemArrivalJournalHeadersV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2> _ItemArrivalJournalHeadersV2;
    }
        /// <summary>
        /// There are no comments for ReturnDispositionCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DispositionCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DispositionCode")]
    [global::Microsoft.OData.Client.EntitySet("ReturnDispositionCodes")]
    public partial class ReturnDispositionCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReturnDispositionCode object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="dispositionCode">Initial value of DispositionCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReturnDispositionCode CreateReturnDispositionCode(string dataAreaId, string dispositionCode)
        {
            ReturnDispositionCode returnDispositionCode = new ReturnDispositionCode();
            returnDispositionCode.dataAreaId = dataAreaId;
            returnDispositionCode.DispositionCode = dispositionCode;
            return returnDispositionCode;
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
        /// There are no comments for Property DispositionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DispositionCode
        {
            get
            {
                return this._DispositionCode;
            }
            set
            {
                this.OnDispositionCodeChanging(value);
                this._DispositionCode = value;
                this.OnDispositionCodeChanged();
                this.OnPropertyChanged("DispositionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispositionCode;
        partial void OnDispositionCodeChanging(string value);
        partial void OnDispositionCodeChanged();
        /// <summary>
        /// There are no comments for Property DispositionDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DispositionDescription
        {
            get
            {
                return this._DispositionDescription;
            }
            set
            {
                this.OnDispositionDescriptionChanging(value);
                this._DispositionDescription = value;
                this.OnDispositionDescriptionChanged();
                this.OnPropertyChanged("DispositionDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispositionDescription;
        partial void OnDispositionDescriptionChanging(string value);
        partial void OnDispositionDescriptionChanged();
        /// <summary>
        /// There are no comments for Property DispositionAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DispositionAction> DispositionAction
        {
            get
            {
                return this._DispositionAction;
            }
            set
            {
                this.OnDispositionActionChanging(value);
                this._DispositionAction = value;
                this.OnDispositionActionChanged();
                this.OnPropertyChanged("DispositionAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DispositionAction> _DispositionAction;
        partial void OnDispositionActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DispositionAction> value);
        partial void OnDispositionActionChanged();
        /// <summary>
        /// There are no comments for Property ItemArrivalJournalLinesV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2> ItemArrivalJournalLinesV2
        {
            get
            {
                return this._ItemArrivalJournalLinesV2;
            }
            set
            {
                this.OnItemArrivalJournalLinesV2Changing(value);
                this._ItemArrivalJournalLinesV2 = value;
                this.OnItemArrivalJournalLinesV2Changed();
                this.OnPropertyChanged("ItemArrivalJournalLinesV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2> _ItemArrivalJournalLinesV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnItemArrivalJournalLinesV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalLineV2> value);
        partial void OnItemArrivalJournalLinesV2Changed();
        /// <summary>
        /// There are no comments for Property ItemArrivalJournalHeadersV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2> ItemArrivalJournalHeadersV2
        {
            get
            {
                return this._ItemArrivalJournalHeadersV2;
            }
            set
            {
                this.OnItemArrivalJournalHeadersV2Changing(value);
                this._ItemArrivalJournalHeadersV2 = value;
                this.OnItemArrivalJournalHeadersV2Changed();
                this.OnPropertyChanged("ItemArrivalJournalHeadersV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2> _ItemArrivalJournalHeadersV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnItemArrivalJournalHeadersV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemArrivalJournalHeaderV2> value);
        partial void OnItemArrivalJournalHeadersV2Changed();
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
