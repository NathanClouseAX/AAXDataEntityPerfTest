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
        /// There are no comments for RetailChannelAttributeGroupSingle in the schema.
        /// </summary>
    public partial class RetailChannelAttributeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelAttributeGroup>
    {
        /// <summary>
        /// Initialize a new RetailChannelAttributeGroupSingle object.
        /// </summary>
        public RetailChannelAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailChannelAttributeGroupSingle object.
        /// </summary>
        public RetailChannelAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailChannelAttributeGroupSingle object.
        /// </summary>
        public RetailChannelAttributeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelAttributeGroup> query)
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
    }
        /// <summary>
        /// There are no comments for RetailChannelAttributeGroup in the schema.
        /// </summary>
    /// <KeyProperties>
    /// OMOperatingUnitNumber
    /// AttributeGroupName
    /// AttributeModifier
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("OMOperatingUnitNumber", "AttributeGroupName", "AttributeModifier")]
    [global::Microsoft.OData.Client.EntitySet("RetailChannelAttributeGroups")]
    public partial class RetailChannelAttributeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailChannelAttributeGroup object.
        /// </summary>
        /// <param name="oMOperatingUnitNumber">Initial value of OMOperatingUnitNumber.</param>
        /// <param name="attributeGroupName">Initial value of AttributeGroupName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailChannelAttributeGroup CreateRetailChannelAttributeGroup(string oMOperatingUnitNumber, string attributeGroupName)
        {
            RetailChannelAttributeGroup retailChannelAttributeGroup = new RetailChannelAttributeGroup();
            retailChannelAttributeGroup.OMOperatingUnitNumber = oMOperatingUnitNumber;
            retailChannelAttributeGroup.AttributeGroupName = attributeGroupName;
            return retailChannelAttributeGroup;
        }
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
        /// There are no comments for Property AttributeGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AttributeGroupName
        {
            get
            {
                return this._AttributeGroupName;
            }
            set
            {
                this.OnAttributeGroupNameChanging(value);
                this._AttributeGroupName = value;
                this.OnAttributeGroupNameChanged();
                this.OnPropertyChanged("AttributeGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeGroupName;
        partial void OnAttributeGroupNameChanging(string value);
        partial void OnAttributeGroupNameChanged();
        /// <summary>
        /// There are no comments for Property AttributeModifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelAttributeModifier> AttributeModifier
        {
            get
            {
                return this._AttributeModifier;
            }
            set
            {
                this.OnAttributeModifierChanging(value);
                this._AttributeModifier = value;
                this.OnAttributeModifierChanged();
                this.OnPropertyChanged("AttributeModifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelAttributeModifier> _AttributeModifier;
        partial void OnAttributeModifierChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailChannelAttributeModifier> value);
        partial void OnAttributeModifierChanged();
        /// <summary>
        /// There are no comments for Property AttributeAppliesToModifier in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAttributeAppliesToModifier> AttributeAppliesToModifier
        {
            get
            {
                return this._AttributeAppliesToModifier;
            }
            set
            {
                this.OnAttributeAppliesToModifierChanging(value);
                this._AttributeAppliesToModifier = value;
                this.OnAttributeAppliesToModifierChanged();
                this.OnPropertyChanged("AttributeAppliesToModifier");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAttributeAppliesToModifier> _AttributeAppliesToModifier;
        partial void OnAttributeAppliesToModifierChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailAttributeAppliesToModifier> value);
        partial void OnAttributeAppliesToModifierChanged();
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
