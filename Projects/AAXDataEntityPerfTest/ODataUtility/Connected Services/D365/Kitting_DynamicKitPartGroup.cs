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
    /// There are no comments for Kitting_DynamicKitPartGroupSingle in the schema.
    /// </summary>
    public partial class Kitting_DynamicKitPartGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKitPartGroup>
    {
        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartGroupSingle object.
        /// </summary>
        public Kitting_DynamicKitPartGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartGroupSingle object.
        /// </summary>
        public Kitting_DynamicKitPartGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new Kitting_DynamicKitPartGroupSingle object.
        /// </summary>
        public Kitting_DynamicKitPartGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_DynamicKitPartGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Kitting_DynamicKitPartGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DynamicKitId
    /// DynamicPartGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DynamicKitId", "DynamicPartGroup")]
    [global::Microsoft.OData.Client.EntitySet("Kitting_DynamicKitPartGroups")]
    public partial class Kitting_DynamicKitPartGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Kitting_DynamicKitPartGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="dynamicKitId">Initial value of DynamicKitId.</param>
        /// <param name="dynamicPartGroup">Initial value of DynamicPartGroup.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Kitting_DynamicKitPartGroup CreateKitting_DynamicKitPartGroup(string dataAreaId, string dynamicKitId, string dynamicPartGroup)
        {
            Kitting_DynamicKitPartGroup kitting_DynamicKitPartGroup = new Kitting_DynamicKitPartGroup();
            kitting_DynamicKitPartGroup.dataAreaId = dataAreaId;
            kitting_DynamicKitPartGroup.DynamicKitId = dynamicKitId;
            kitting_DynamicKitPartGroup.DynamicPartGroup = dynamicPartGroup;
            return kitting_DynamicKitPartGroup;
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
        /// There are no comments for Property DynamicKitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DynamicKitId is required.")]
        public virtual string DynamicKitId
        {
            get
            {
                return this._DynamicKitId;
            }
            set
            {
                this.OnDynamicKitIdChanging(value);
                this._DynamicKitId = value;
                this.OnDynamicKitIdChanged();
                this.OnPropertyChanged("DynamicKitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicKitId;
        partial void OnDynamicKitIdChanging(string value);
        partial void OnDynamicKitIdChanged();
        /// <summary>
        /// There are no comments for Property DynamicPartGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DynamicPartGroup is required.")]
        public virtual string DynamicPartGroup
        {
            get
            {
                return this._DynamicPartGroup;
            }
            set
            {
                this.OnDynamicPartGroupChanging(value);
                this._DynamicPartGroup = value;
                this.OnDynamicPartGroupChanged();
                this.OnPropertyChanged("DynamicPartGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DynamicPartGroup;
        partial void OnDynamicPartGroupChanging(string value);
        partial void OnDynamicPartGroupChanged();
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
