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
    /// There are no comments for VoyageArrivalGroupSingle in the schema.
    /// </summary>
    public partial class VoyageArrivalGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VoyageArrivalGroup>
    {
        /// <summary>
        /// Initialize a new VoyageArrivalGroupSingle object.
        /// </summary>
        public VoyageArrivalGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VoyageArrivalGroupSingle object.
        /// </summary>
        public VoyageArrivalGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VoyageArrivalGroupSingle object.
        /// </summary>
        public VoyageArrivalGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VoyageArrivalGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for VoyageArrivalGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("VoyageArrivalGroups")]
    public partial class VoyageArrivalGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VoyageArrivalGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VoyageArrivalGroup CreateVoyageArrivalGroup(string dataAreaId, string groupId)
        {
            VoyageArrivalGroup voyageArrivalGroup = new VoyageArrivalGroup();
            voyageArrivalGroup.dataAreaId = dataAreaId;
            voyageArrivalGroup.GroupId = groupId;
            return voyageArrivalGroup;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "dataAreaId is required.")]
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
        /// There are no comments for Property GroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupId is required.")]
        public virtual string GroupId
        {
            get
            {
                return this._GroupId;
            }
            set
            {
                this.OnGroupIdChanging(value);
                this._GroupId = value;
                this.OnGroupIdChanged();
                this.OnPropertyChanged("GroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupId;
        partial void OnGroupIdChanging(string value);
        partial void OnGroupIdChanged();
        /// <summary>
        /// There are no comments for Property GroupDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string GroupDescription
        {
            get
            {
                return this._GroupDescription;
            }
            set
            {
                this.OnGroupDescriptionChanging(value);
                this._GroupDescription = value;
                this.OnGroupDescriptionChanged();
                this.OnPropertyChanged("GroupDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupDescription;
        partial void OnGroupDescriptionChanging(string value);
        partial void OnGroupDescriptionChanged();
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
