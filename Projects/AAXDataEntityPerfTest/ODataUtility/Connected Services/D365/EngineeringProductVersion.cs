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
    /// There are no comments for EngineeringProductVersionSingle in the schema.
    /// </summary>
    public partial class EngineeringProductVersionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringProductVersion>
    {
        /// <summary>
        /// Initialize a new EngineeringProductVersionSingle object.
        /// </summary>
        public EngineeringProductVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringProductVersionSingle object.
        /// </summary>
        public EngineeringProductVersionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringProductVersionSingle object.
        /// </summary>
        public EngineeringProductVersionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringProductVersion> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ReceivedProductReleaseHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader> ReceivedProductReleaseHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivedProductReleaseHeaders == null))
                {
                    this._ReceivedProductReleaseHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader>(GetPath("ReceivedProductReleaseHeaders"));
                }
                return this._ReceivedProductReleaseHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader> _ReceivedProductReleaseHeaders;
        /// <summary>
        /// There are no comments for ReleasedEngineeringProductVersions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion> ReleasedEngineeringProductVersions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedEngineeringProductVersions == null))
                {
                    this._ReleasedEngineeringProductVersions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion>(GetPath("ReleasedEngineeringProductVersions"));
                }
                return this._ReleasedEngineeringProductVersions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion> _ReleasedEngineeringProductVersions;
        /// <summary>
        /// There are no comments for SentProductReleaseHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader> SentProductReleaseHeaders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SentProductReleaseHeaders == null))
                {
                    this._SentProductReleaseHeaders = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader>(GetPath("SentProductReleaseHeaders"));
                }
                return this._SentProductReleaseHeaders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader> _SentProductReleaseHeaders;
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductReleases in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease> EngineeringChangeOrderProductReleases
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProductReleases == null))
                {
                    this._EngineeringChangeOrderProductReleases = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease>(GetPath("EngineeringChangeOrderProductReleases"));
                }
                return this._EngineeringChangeOrderProductReleases;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease> _EngineeringChangeOrderProductReleases;
        /// <summary>
        /// There are no comments for ProductReleaseProductDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail> ProductReleaseProductDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductReleaseProductDetails == null))
                {
                    this._ProductReleaseProductDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail>(GetPath("ProductReleaseProductDetails"));
                }
                return this._ProductReleaseProductDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail> _ProductReleaseProductDetails;
        /// <summary>
        /// There are no comments for ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single ProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductV2 == null))
                {
                    this._ProductV2 = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("ProductV2"));
                }
                return this._ProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _ProductV2;
    }
    /// <summary>
    /// There are no comments for EngineeringProductVersion in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductNumber
    /// EngineeringVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProductNumber", "EngineeringVersionId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringProductVersions")]
    public partial class EngineeringProductVersion : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringProductVersion object.
        /// </summary>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="engineeringVersionId">Initial value of EngineeringVersionId.</param>
        /// <param name="versionNumber">Initial value of VersionNumber.</param>
        /// <param name="productV2">Initial value of ProductV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringProductVersion CreateEngineeringProductVersion(string productNumber, string engineeringVersionId, decimal versionNumber, global::Microsoft.Dynamics.DataEntities.ProductV2 productV2)
        {
            EngineeringProductVersion engineeringProductVersion = new EngineeringProductVersion();
            engineeringProductVersion.ProductNumber = productNumber;
            engineeringProductVersion.EngineeringVersionId = engineeringVersionId;
            engineeringProductVersion.VersionNumber = versionNumber;
            if ((productV2 == null))
            {
                throw new global::System.ArgumentNullException("productV2");
            }
            engineeringProductVersion.ProductV2 = productV2;
            return engineeringProductVersion;
        }
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductNumber is required.")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringVersionId is required.")]
        public virtual string EngineeringVersionId
        {
            get
            {
                return this._EngineeringVersionId;
            }
            set
            {
                this.OnEngineeringVersionIdChanging(value);
                this._EngineeringVersionId = value;
                this.OnEngineeringVersionIdChanged();
                this.OnPropertyChanged("EngineeringVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringVersionId;
        partial void OnEngineeringVersionIdChanging(string value);
        partial void OnEngineeringVersionIdChanged();
        /// <summary>
        /// There are no comments for Property PreviousEngineeringVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string PreviousEngineeringVersionId
        {
            get
            {
                return this._PreviousEngineeringVersionId;
            }
            set
            {
                this.OnPreviousEngineeringVersionIdChanging(value);
                this._PreviousEngineeringVersionId = value;
                this.OnPreviousEngineeringVersionIdChanged();
                this.OnPropertyChanged("PreviousEngineeringVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PreviousEngineeringVersionId;
        partial void OnPreviousEngineeringVersionIdChanging(string value);
        partial void OnPreviousEngineeringVersionIdChanged();
        /// <summary>
        /// There are no comments for Property VersionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VersionNumber is required.")]
        public virtual decimal VersionNumber
        {
            get
            {
                return this._VersionNumber;
            }
            set
            {
                this.OnVersionNumberChanging(value);
                this._VersionNumber = value;
                this.OnVersionNumberChanged();
                this.OnPropertyChanged("VersionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VersionNumber;
        partial void OnVersionNumberChanging(decimal value);
        partial void OnVersionNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringOrganizationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

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
        /// There are no comments for Property ReceivedProductReleaseHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader> ReceivedProductReleaseHeaders
        {
            get
            {
                return this._ReceivedProductReleaseHeaders;
            }
            set
            {
                this.OnReceivedProductReleaseHeadersChanging(value);
                this._ReceivedProductReleaseHeaders = value;
                this.OnReceivedProductReleaseHeadersChanged();
                this.OnPropertyChanged("ReceivedProductReleaseHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader> _ReceivedProductReleaseHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReceivedProductReleaseHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseHeader> value);
        partial void OnReceivedProductReleaseHeadersChanged();
        /// <summary>
        /// There are no comments for Property ReleasedEngineeringProductVersions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion> ReleasedEngineeringProductVersions
        {
            get
            {
                return this._ReleasedEngineeringProductVersions;
            }
            set
            {
                this.OnReleasedEngineeringProductVersionsChanging(value);
                this._ReleasedEngineeringProductVersions = value;
                this.OnReleasedEngineeringProductVersionsChanged();
                this.OnPropertyChanged("ReleasedEngineeringProductVersions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion> _ReleasedEngineeringProductVersions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedEngineeringProductVersionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedEngineeringProductVersion> value);
        partial void OnReleasedEngineeringProductVersionsChanged();
        /// <summary>
        /// There are no comments for Property SentProductReleaseHeaders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader> SentProductReleaseHeaders
        {
            get
            {
                return this._SentProductReleaseHeaders;
            }
            set
            {
                this.OnSentProductReleaseHeadersChanging(value);
                this._SentProductReleaseHeaders = value;
                this.OnSentProductReleaseHeadersChanged();
                this.OnPropertyChanged("SentProductReleaseHeaders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader> _SentProductReleaseHeaders = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSentProductReleaseHeadersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.SentProductReleaseHeader> value);
        partial void OnSentProductReleaseHeadersChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductReleases in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease> EngineeringChangeOrderProductReleases
        {
            get
            {
                return this._EngineeringChangeOrderProductReleases;
            }
            set
            {
                this.OnEngineeringChangeOrderProductReleasesChanging(value);
                this._EngineeringChangeOrderProductReleases = value;
                this.OnEngineeringChangeOrderProductReleasesChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductReleases");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease> _EngineeringChangeOrderProductReleases = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEngineeringChangeOrderProductReleasesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductRelease> value);
        partial void OnEngineeringChangeOrderProductReleasesChanged();
        /// <summary>
        /// There are no comments for Property ProductReleaseProductDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail> ProductReleaseProductDetails
        {
            get
            {
                return this._ProductReleaseProductDetails;
            }
            set
            {
                this.OnProductReleaseProductDetailsChanging(value);
                this._ProductReleaseProductDetails = value;
                this.OnProductReleaseProductDetailsChanged();
                this.OnPropertyChanged("ProductReleaseProductDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail> _ProductReleaseProductDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProductReleaseProductDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProductReleaseProductDetail> value);
        partial void OnProductReleaseProductDetailsChanged();
        /// <summary>
        /// There are no comments for Property ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductV2 is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 ProductV2
        {
            get
            {
                return this._ProductV2;
            }
            set
            {
                this.OnProductV2Changing(value);
                this._ProductV2 = value;
                this.OnProductV2Changed();
                this.OnPropertyChanged("ProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _ProductV2;
        partial void OnProductV2Changing(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnProductV2Changed();
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
