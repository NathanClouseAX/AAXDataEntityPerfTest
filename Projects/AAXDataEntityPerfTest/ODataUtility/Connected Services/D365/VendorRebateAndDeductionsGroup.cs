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
    /// There are no comments for VendorRebateAndDeductionsGroupSingle in the schema.
    /// </summary>
    public partial class VendorRebateAndDeductionsGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRebateAndDeductionsGroup>
    {
        /// <summary>
        /// Initialize a new VendorRebateAndDeductionsGroupSingle object.
        /// </summary>
        public VendorRebateAndDeductionsGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VendorRebateAndDeductionsGroupSingle object.
        /// </summary>
        public VendorRebateAndDeductionsGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VendorRebateAndDeductionsGroupSingle object.
        /// </summary>
        public VendorRebateAndDeductionsGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VendorRebateAndDeductionsGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RebateAndDeductionsAgreementHeaders == null))
                {
                    this._RebateAndDeductionsAgreementHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(GetPath("RebateAndDeductionsAgreementHeaders"));
                }
                return this._RebateAndDeductionsAgreementHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders;
        /// <summary>
        /// There are no comments for VendorRebateAndDeductionsGroupAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment> VendorRebateAndDeductionsGroupAssignments
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._VendorRebateAndDeductionsGroupAssignments == null))
                {
                    this._VendorRebateAndDeductionsGroupAssignments = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment>(GetPath("VendorRebateAndDeductionsGroupAssignments"));
                }
                return this._VendorRebateAndDeductionsGroupAssignments;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment> _VendorRebateAndDeductionsGroupAssignments;
    }
    /// <summary>
    /// There are no comments for VendorRebateAndDeductionsGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// GroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "GroupId")]
    [global::Microsoft.OData.Client.EntitySet("VendorRebateAndDeductionsGroups")]
    public partial class VendorRebateAndDeductionsGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VendorRebateAndDeductionsGroup object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="groupId">Initial value of GroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VendorRebateAndDeductionsGroup CreateVendorRebateAndDeductionsGroup(string dataAreaId, string groupId)
        {
            VendorRebateAndDeductionsGroup vendorRebateAndDeductionsGroup = new VendorRebateAndDeductionsGroup();
            vendorRebateAndDeductionsGroup.dataAreaId = dataAreaId;
            vendorRebateAndDeductionsGroup.GroupId = groupId;
            return vendorRebateAndDeductionsGroup;
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
        /// There are no comments for Property RebateAndDeductionsAgreementHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> RebateAndDeductionsAgreementHeaders
        {
            get
            {
                return this._RebateAndDeductionsAgreementHeaders;
            }
            set
            {
                this.OnRebateAndDeductionsAgreementHeadersChanging(value);
                this._RebateAndDeductionsAgreementHeaders = value;
                this.OnRebateAndDeductionsAgreementHeadersChanged();
                this.OnPropertyChanged("RebateAndDeductionsAgreementHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> _RebateAndDeductionsAgreementHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRebateAndDeductionsAgreementHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RebateAndDeductionAgreementHeader> value);
        partial void OnRebateAndDeductionsAgreementHeadersChanged();
        /// <summary>
        /// There are no comments for Property VendorRebateAndDeductionsGroupAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment> VendorRebateAndDeductionsGroupAssignments
        {
            get
            {
                return this._VendorRebateAndDeductionsGroupAssignments;
            }
            set
            {
                this.OnVendorRebateAndDeductionsGroupAssignmentsChanging(value);
                this._VendorRebateAndDeductionsGroupAssignments = value;
                this.OnVendorRebateAndDeductionsGroupAssignmentsChanged();
                this.OnPropertyChanged("VendorRebateAndDeductionsGroupAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment> _VendorRebateAndDeductionsGroupAssignments = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnVendorRebateAndDeductionsGroupAssignmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.VendorRebateAndDeductionsGroupAssignment> value);
        partial void OnVendorRebateAndDeductionsGroupAssignmentsChanged();
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
