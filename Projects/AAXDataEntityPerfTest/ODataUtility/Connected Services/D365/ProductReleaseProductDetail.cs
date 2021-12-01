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
    /// There are no comments for ProductReleaseProductDetailSingle in the schema.
    /// </summary>
    public partial class ProductReleaseProductDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReleaseProductDetail>
    {
        /// <summary>
        /// Initialize a new ProductReleaseProductDetailSingle object.
        /// </summary>
        public ProductReleaseProductDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductReleaseProductDetailSingle object.
        /// </summary>
        public ProductReleaseProductDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductReleaseProductDetailSingle object.
        /// </summary>
        public ProductReleaseProductDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReleaseProductDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle EngineeringProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductVersion == null))
                {
                    this._EngineeringProductVersion = new global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle(this.Context, GetPath("EngineeringProductVersion"));
                }
                return this._EngineeringProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle _EngineeringProductVersion;
        /// <summary>
        /// There are no comments for SentProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine> SentProductReleaseLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SentProductReleaseLines == null))
                {
                    this._SentProductReleaseLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine>(GetPath("SentProductReleaseLines"));
                }
                return this._SentProductReleaseLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine> _SentProductReleaseLines;
        /// <summary>
        /// There are no comments for ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReceivedProductReleaseLines == null))
                {
                    this._ReceivedProductReleaseLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(GetPath("ReceivedProductReleaseLines"));
                }
                return this._ReceivedProductReleaseLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines;
    }
    /// <summary>
    /// There are no comments for ProductReleaseProductDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductNumber
    /// ProductVersionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductNumber", "ProductVersionId")]
    [global::Microsoft.OData.Client.EntitySet("ProductReleaseProductDetails")]
    public partial class ProductReleaseProductDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductReleaseProductDetail object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="engineeringProductVersion">Initial value of EngineeringProductVersion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductReleaseProductDetail CreateProductReleaseProductDetail(string dataAreaId, string productNumber, string productVersionId, global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion engineeringProductVersion)
        {
            ProductReleaseProductDetail productReleaseProductDetail = new ProductReleaseProductDetail();
            productReleaseProductDetail.dataAreaId = dataAreaId;
            productReleaseProductDetail.ProductNumber = productNumber;
            productReleaseProductDetail.ProductVersionId = productVersionId;
            if ((engineeringProductVersion == null))
            {
                throw new global::System.ArgumentNullException("engineeringProductVersion");
            }
            productReleaseProductDetail.EngineeringProductVersion = engineeringProductVersion;
            return productReleaseProductDetail;
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
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersionId is required.")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property TemplateBOMId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TemplateBOMId
        {
            get
            {
                return this._TemplateBOMId;
            }
            set
            {
                this.OnTemplateBOMIdChanging(value);
                this._TemplateBOMId = value;
                this.OnTemplateBOMIdChanged();
                this.OnPropertyChanged("TemplateBOMId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateBOMId;
        partial void OnTemplateBOMIdChanging(string value);
        partial void OnTemplateBOMIdChanged();
        /// <summary>
        /// There are no comments for Property TemplateItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TemplateItemNumber
        {
            get
            {
                return this._TemplateItemNumber;
            }
            set
            {
                this.OnTemplateItemNumberChanging(value);
                this._TemplateItemNumber = value;
                this.OnTemplateItemNumberChanged();
                this.OnPropertyChanged("TemplateItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateItemNumber;
        partial void OnTemplateItemNumberChanging(string value);
        partial void OnTemplateItemNumberChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseReleaseRoute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseReleaseRoute
        {
            get
            {
                return this._WillProductReleaseReleaseRoute;
            }
            set
            {
                this.OnWillProductReleaseReleaseRouteChanging(value);
                this._WillProductReleaseReleaseRoute = value;
                this.OnWillProductReleaseReleaseRouteChanged();
                this.OnPropertyChanged("WillProductReleaseReleaseRoute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseReleaseRoute;
        partial void OnWillProductReleaseReleaseRouteChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseReleaseRouteChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseCopyBillOfMaterialsApproval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseCopyBillOfMaterialsApproval
        {
            get
            {
                return this._WillProductReleaseCopyBillOfMaterialsApproval;
            }
            set
            {
                this.OnWillProductReleaseCopyBillOfMaterialsApprovalChanging(value);
                this._WillProductReleaseCopyBillOfMaterialsApproval = value;
                this.OnWillProductReleaseCopyBillOfMaterialsApprovalChanged();
                this.OnPropertyChanged("WillProductReleaseCopyBillOfMaterialsApproval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseCopyBillOfMaterialsApproval;
        partial void OnWillProductReleaseCopyBillOfMaterialsApprovalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseCopyBillOfMaterialsApprovalChanged();
        /// <summary>
        /// There are no comments for Property TemplateRouteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TemplateRouteId
        {
            get
            {
                return this._TemplateRouteId;
            }
            set
            {
                this.OnTemplateRouteIdChanging(value);
                this._TemplateRouteId = value;
                this.OnTemplateRouteIdChanged();
                this.OnPropertyChanged("TemplateRouteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateRouteId;
        partial void OnTemplateRouteIdChanging(string value);
        partial void OnTemplateRouteIdChanged();
        /// <summary>
        /// There are no comments for Property ReleaseStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseStatus> ReleaseStatus
        {
            get
            {
                return this._ReleaseStatus;
            }
            set
            {
                this.OnReleaseStatusChanging(value);
                this._ReleaseStatus = value;
                this.OnReleaseStatusChanged();
                this.OnPropertyChanged("ReleaseStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseStatus> _ReleaseStatus;
        partial void OnReleaseStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgProductReleaseStatus> value);
        partial void OnReleaseStatusChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseReleaseBillOfMaterials in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseReleaseBillOfMaterials
        {
            get
            {
                return this._WillProductReleaseReleaseBillOfMaterials;
            }
            set
            {
                this.OnWillProductReleaseReleaseBillOfMaterialsChanging(value);
                this._WillProductReleaseReleaseBillOfMaterials = value;
                this.OnWillProductReleaseReleaseBillOfMaterialsChanged();
                this.OnPropertyChanged("WillProductReleaseReleaseBillOfMaterials");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseReleaseBillOfMaterials;
        partial void OnWillProductReleaseReleaseBillOfMaterialsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseReleaseBillOfMaterialsChanged();
        /// <summary>
        /// There are no comments for Property WillProductReleaseCopyRouteApproval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductReleaseCopyRouteApproval
        {
            get
            {
                return this._WillProductReleaseCopyRouteApproval;
            }
            set
            {
                this.OnWillProductReleaseCopyRouteApprovalChanging(value);
                this._WillProductReleaseCopyRouteApproval = value;
                this.OnWillProductReleaseCopyRouteApprovalChanged();
                this.OnPropertyChanged("WillProductReleaseCopyRouteApproval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductReleaseCopyRouteApproval;
        partial void OnWillProductReleaseCopyRouteApprovalChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductReleaseCopyRouteApprovalChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringProductVersion is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion EngineeringProductVersion
        {
            get
            {
                return this._EngineeringProductVersion;
            }
            set
            {
                this.OnEngineeringProductVersionChanging(value);
                this._EngineeringProductVersion = value;
                this.OnEngineeringProductVersionChanged();
                this.OnPropertyChanged("EngineeringProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion _EngineeringProductVersion;
        partial void OnEngineeringProductVersionChanging(global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion value);
        partial void OnEngineeringProductVersionChanged();
        /// <summary>
        /// There are no comments for Property SentProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine> SentProductReleaseLines
        {
            get
            {
                return this._SentProductReleaseLines;
            }
            set
            {
                this.OnSentProductReleaseLinesChanging(value);
                this._SentProductReleaseLines = value;
                this.OnSentProductReleaseLinesChanged();
                this.OnPropertyChanged("SentProductReleaseLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine> _SentProductReleaseLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSentProductReleaseLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ChgSentProductReleaseLine> value);
        partial void OnSentProductReleaseLinesChanged();
        /// <summary>
        /// There are no comments for Property ReceivedProductReleaseLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> ReceivedProductReleaseLines
        {
            get
            {
                return this._ReceivedProductReleaseLines;
            }
            set
            {
                this.OnReceivedProductReleaseLinesChanging(value);
                this._ReceivedProductReleaseLines = value;
                this.OnReceivedProductReleaseLinesChanged();
                this.OnPropertyChanged("ReceivedProductReleaseLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> _ReceivedProductReleaseLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReceivedProductReleaseLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReceivedProductReleaseLine> value);
        partial void OnReceivedProductReleaseLinesChanged();
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
