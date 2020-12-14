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
        /// There are no comments for DeliveryModeChannelLineSingle in the schema.
        /// </summary>
    public partial class DeliveryModeChannelLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryModeChannelLine>
    {
        /// <summary>
        /// Initialize a new DeliveryModeChannelLineSingle object.
        /// </summary>
        public DeliveryModeChannelLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeliveryModeChannelLineSingle object.
        /// </summary>
        public DeliveryModeChannelLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeliveryModeChannelLineSingle object.
        /// </summary>
        public DeliveryModeChannelLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeliveryModeChannelLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DeliveryModeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DeliveryModeV2Single DeliveryModeV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DeliveryModeV2 == null))
                {
                    this._DeliveryModeV2 = new global::Microsoft.Dynamics.DataEntities.DeliveryModeV2Single(this.Context, GetPath("DeliveryModeV2"));
                }
                return this._DeliveryModeV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DeliveryModeV2Single _DeliveryModeV2;
    }
        /// <summary>
        /// There are no comments for DeliveryModeChannelLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ModeOfDeliveryCode
    /// PartyNumber
    /// OrganizationHierarchyType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ModeOfDeliveryCode", "PartyNumber", "OrganizationHierarchyType")]
    [global::Microsoft.OData.Client.EntitySet("DeliveryModeChannelLines")]
    public partial class DeliveryModeChannelLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeliveryModeChannelLine object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="modeOfDeliveryCode">Initial value of ModeOfDeliveryCode.</param>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="organizationHierarchyType">Initial value of OrganizationHierarchyType.</param>
        /// <param name="deliveryModeV2">Initial value of DeliveryModeV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeliveryModeChannelLine CreateDeliveryModeChannelLine(string dataAreaId, string modeOfDeliveryCode, string partyNumber, string organizationHierarchyType, global::Microsoft.Dynamics.DataEntities.DeliveryModeV2 deliveryModeV2)
        {
            DeliveryModeChannelLine deliveryModeChannelLine = new DeliveryModeChannelLine();
            deliveryModeChannelLine.dataAreaId = dataAreaId;
            deliveryModeChannelLine.ModeOfDeliveryCode = modeOfDeliveryCode;
            deliveryModeChannelLine.PartyNumber = partyNumber;
            deliveryModeChannelLine.OrganizationHierarchyType = organizationHierarchyType;
            if ((deliveryModeV2 == null))
            {
                throw new global::System.ArgumentNullException("deliveryModeV2");
            }
            deliveryModeChannelLine.DeliveryModeV2 = deliveryModeV2;
            return deliveryModeChannelLine;
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
        /// There are no comments for Property ModeOfDeliveryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ModeOfDeliveryCode
        {
            get
            {
                return this._ModeOfDeliveryCode;
            }
            set
            {
                this.OnModeOfDeliveryCodeChanging(value);
                this._ModeOfDeliveryCode = value;
                this.OnModeOfDeliveryCodeChanged();
                this.OnPropertyChanged("ModeOfDeliveryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModeOfDeliveryCode;
        partial void OnModeOfDeliveryCodeChanging(string value);
        partial void OnModeOfDeliveryCodeChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property OrganizationHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationHierarchyType
        {
            get
            {
                return this._OrganizationHierarchyType;
            }
            set
            {
                this.OnOrganizationHierarchyTypeChanging(value);
                this._OrganizationHierarchyType = value;
                this.OnOrganizationHierarchyTypeChanged();
                this.OnPropertyChanged("OrganizationHierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationHierarchyType;
        partial void OnOrganizationHierarchyTypeChanging(string value);
        partial void OnOrganizationHierarchyTypeChanged();
        /// <summary>
        /// There are no comments for Property OrganizationName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OrganizationName
        {
            get
            {
                return this._OrganizationName;
            }
            set
            {
                this.OnOrganizationNameChanging(value);
                this._OrganizationName = value;
                this.OnOrganizationNameChanged();
                this.OnPropertyChanged("OrganizationName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationName;
        partial void OnOrganizationNameChanging(string value);
        partial void OnOrganizationNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryModeV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DeliveryModeV2 DeliveryModeV2
        {
            get
            {
                return this._DeliveryModeV2;
            }
            set
            {
                this.OnDeliveryModeV2Changing(value);
                this._DeliveryModeV2 = value;
                this.OnDeliveryModeV2Changed();
                this.OnPropertyChanged("DeliveryModeV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DeliveryModeV2 _DeliveryModeV2;
        partial void OnDeliveryModeV2Changing(global::Microsoft.Dynamics.DataEntities.DeliveryModeV2 value);
        partial void OnDeliveryModeV2Changed();
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
