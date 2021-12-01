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
    /// There are no comments for EngineeringOrganizationSingle in the schema.
    /// </summary>
    public partial class EngineeringOrganizationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringOrganization>
    {
        /// <summary>
        /// Initialize a new EngineeringOrganizationSingle object.
        /// </summary>
        public EngineeringOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringOrganizationSingle object.
        /// </summary>
        public EngineeringOrganizationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringOrganizationSingle object.
        /// </summary>
        public EngineeringOrganizationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringOrganization> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductCategoryDetails == null))
                {
                    this._EngineeringProductCategoryDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(GetPath("EngineeringProductCategoryDetails"));
                }
                return this._EngineeringProductCategoryDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails;
    }
    /// <summary>
    /// There are no comments for EngineeringOrganization in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EngineeringOrganizationId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EngineeringOrganizationId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringOrganizations")]
    public partial class EngineeringOrganization : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringOrganization object.
        /// </summary>
        /// <param name="engineeringOrganizationId">Initial value of EngineeringOrganizationId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringOrganization CreateEngineeringOrganization(string engineeringOrganizationId)
        {
            EngineeringOrganization engineeringOrganization = new EngineeringOrganization();
            engineeringOrganization.EngineeringOrganizationId = engineeringOrganizationId;
            return engineeringOrganization;
        }
        /// <summary>
        /// There are no comments for Property EngineeringOrganizationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringOrganizationId is required.")]
        public virtual string EngineeringOrganizationId
        {
            get
            {
                return this._EngineeringOrganizationId;
            }
            set
            {
                this.OnEngineeringOrganizationIdChanging(value);
                this._EngineeringOrganizationId = value;
                this.OnEngineeringOrganizationIdChanged();
                this.OnPropertyChanged("EngineeringOrganizationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringOrganizationId;
        partial void OnEngineeringOrganizationIdChanging(string value);
        partial void OnEngineeringOrganizationIdChanged();
        /// <summary>
        /// There are no comments for Property OrganizationPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string OrganizationPartyNumber
        {
            get
            {
                return this._OrganizationPartyNumber;
            }
            set
            {
                this.OnOrganizationPartyNumberChanging(value);
                this._OrganizationPartyNumber = value;
                this.OnOrganizationPartyNumberChanged();
                this.OnPropertyChanged("OrganizationPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationPartyNumber;
        partial void OnOrganizationPartyNumberChanging(string value);
        partial void OnOrganizationPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductCategoryDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> EngineeringProductCategoryDetails
        {
            get
            {
                return this._EngineeringProductCategoryDetails;
            }
            set
            {
                this.OnEngineeringProductCategoryDetailsChanging(value);
                this._EngineeringProductCategoryDetails = value;
                this.OnEngineeringProductCategoryDetailsChanged();
                this.OnPropertyChanged("EngineeringProductCategoryDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> _EngineeringProductCategoryDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringProductCategoryDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringProductCategoryDetails> value);
        partial void OnEngineeringProductCategoryDetailsChanged();
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
