﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ResourceCategorySingle in the schema.
        /// </summary>
    public partial class ResourceCategorySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCategory>
    {
        /// <summary>
        /// Initialize a new ResourceCategorySingle object.
        /// </summary>
        public ResourceCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ResourceCategorySingle object.
        /// </summary>
        public ResourceCategorySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ResourceCategorySingle object.
        /// </summary>
        public ResourceCategorySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCategory> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProjectQuotationWbsTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> ProjectQuotationWbsTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectQuotationWbsTask == null))
                {
                    this._ProjectQuotationWbsTask = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask>(GetPath("ProjectQuotationWbsTask"));
                }
                return this._ProjectQuotationWbsTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> _ProjectQuotationWbsTask;
        /// <summary>
        /// There are no comments for ProjectEmplForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectEmplForecastSingle ProjectEmplForecast
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectEmplForecast == null))
                {
                    this._ProjectEmplForecast = new global::Microsoft.Dynamics.DataEntities.ProjectEmplForecastSingle(this.Context, GetPath("ProjectEmplForecast"));
                }
                return this._ProjectEmplForecast;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectEmplForecastSingle _ProjectEmplForecast;
        /// <summary>
        /// There are no comments for ProjectExpenseForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecastSingle ProjectExpenseForecast
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectExpenseForecast == null))
                {
                    this._ProjectExpenseForecast = new global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecastSingle(this.Context, GetPath("ProjectExpenseForecast"));
                }
                return this._ProjectExpenseForecast;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecastSingle _ProjectExpenseForecast;
        /// <summary>
        /// There are no comments for WBS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> WBS
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WBS == null))
                {
                    this._WBS = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft>(GetPath("WBS"));
                }
                return this._WBS;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> _WBS;
        /// <summary>
        /// There are no comments for TransferPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TransferPrice> TransferPrice
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TransferPrice == null))
                {
                    this._TransferPrice = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TransferPrice>(GetPath("TransferPrice"));
                }
                return this._TransferPrice;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TransferPrice> _TransferPrice;
        /// <summary>
        /// There are no comments for ProjectFeeForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectFeeForecastSingle ProjectFeeForecast
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjectFeeForecast == null))
                {
                    this._ProjectFeeForecast = new global::Microsoft.Dynamics.DataEntities.ProjectFeeForecastSingle(this.Context, GetPath("ProjectFeeForecast"));
                }
                return this._ProjectFeeForecast;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectFeeForecastSingle _ProjectFeeForecast;
        /// <summary>
        /// There are no comments for JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTransSingle JournalTrans
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JournalTrans == null))
                {
                    this._JournalTrans = new global::Microsoft.Dynamics.DataEntities.JournalTransSingle(this.Context, GetPath("JournalTrans"));
                }
                return this._JournalTrans;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTransSingle _JournalTrans;
        /// <summary>
        /// There are no comments for ProjWBSTemplateTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> ProjWBSTemplateTask
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProjWBSTemplateTask == null))
                {
                    this._ProjWBSTemplateTask = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask>(GetPath("ProjWBSTemplateTask"));
                }
                return this._ProjWBSTemplateTask;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> _ProjWBSTemplateTask;
    }
        /// <summary>
        /// There are no comments for ResourceCategory in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// RoleId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "RoleId")]
    [global::Microsoft.OData.Client.EntitySet("ResourceCategories")]
    public partial class ResourceCategory : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ResourceCategory object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="roleId">Initial value of RoleId.</param>
        /// <param name="projectEmplForecast">Initial value of ProjectEmplForecast.</param>
        /// <param name="projectExpenseForecast">Initial value of ProjectExpenseForecast.</param>
        /// <param name="projectFeeForecast">Initial value of ProjectFeeForecast.</param>
        /// <param name="journalTrans">Initial value of JournalTrans.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ResourceCategory CreateResourceCategory(string dataAreaId, 
                    string roleId, 
                    global::Microsoft.Dynamics.DataEntities.ProjectEmplForecast projectEmplForecast, 
                    global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecast projectExpenseForecast, 
                    global::Microsoft.Dynamics.DataEntities.ProjectFeeForecast projectFeeForecast, 
                    global::Microsoft.Dynamics.DataEntities.JournalTrans journalTrans)
        {
            ResourceCategory resourceCategory = new ResourceCategory();
            resourceCategory.dataAreaId = dataAreaId;
            resourceCategory.RoleId = roleId;
            if ((projectEmplForecast == null))
            {
                throw new global::System.ArgumentNullException("projectEmplForecast");
            }
            resourceCategory.ProjectEmplForecast = projectEmplForecast;
            if ((projectExpenseForecast == null))
            {
                throw new global::System.ArgumentNullException("projectExpenseForecast");
            }
            resourceCategory.ProjectExpenseForecast = projectExpenseForecast;
            if ((projectFeeForecast == null))
            {
                throw new global::System.ArgumentNullException("projectFeeForecast");
            }
            resourceCategory.ProjectFeeForecast = projectFeeForecast;
            if ((journalTrans == null))
            {
                throw new global::System.ArgumentNullException("journalTrans");
            }
            resourceCategory.JournalTrans = journalTrans;
            return resourceCategory;
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
        /// There are no comments for Property RoleId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RoleId
        {
            get
            {
                return this._RoleId;
            }
            set
            {
                this.OnRoleIdChanging(value);
                this._RoleId = value;
                this.OnRoleIdChanged();
                this.OnPropertyChanged("RoleId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoleId;
        partial void OnRoleIdChanging(string value);
        partial void OnRoleIdChanged();
        /// <summary>
        /// There are no comments for Property IsCategoryDisabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> IsCategoryDisabled
        {
            get
            {
                return this._IsCategoryDisabled;
            }
            set
            {
                this.OnIsCategoryDisabledChanging(value);
                this._IsCategoryDisabled = value;
                this.OnIsCategoryDisabledChanged();
                this.OnPropertyChanged("IsCategoryDisabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> _IsCategoryDisabled;
        partial void OnIsCategoryDisabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> value);
        partial void OnIsCategoryDisabledChanged();
        /// <summary>
        /// There are no comments for Property DefaultResourceCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> DefaultResourceCategory
        {
            get
            {
                return this._DefaultResourceCategory;
            }
            set
            {
                this.OnDefaultResourceCategoryChanging(value);
                this._DefaultResourceCategory = value;
                this.OnDefaultResourceCategoryChanged();
                this.OnPropertyChanged("DefaultResourceCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> _DefaultResourceCategory;
        partial void OnDefaultResourceCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.FalseTrue> value);
        partial void OnDefaultResourceCategoryChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ProjectQuotationWbsTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> ProjectQuotationWbsTask
        {
            get
            {
                return this._ProjectQuotationWbsTask;
            }
            set
            {
                this.OnProjectQuotationWbsTaskChanging(value);
                this._ProjectQuotationWbsTask = value;
                this.OnProjectQuotationWbsTaskChanged();
                this.OnPropertyChanged("ProjectQuotationWbsTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> _ProjectQuotationWbsTask = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProjectQuotationWbsTaskChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectQuotationWbsTask> value);
        partial void OnProjectQuotationWbsTaskChanged();
        /// <summary>
        /// There are no comments for Property ProjectEmplForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectEmplForecast ProjectEmplForecast
        {
            get
            {
                return this._ProjectEmplForecast;
            }
            set
            {
                this.OnProjectEmplForecastChanging(value);
                this._ProjectEmplForecast = value;
                this.OnProjectEmplForecastChanged();
                this.OnPropertyChanged("ProjectEmplForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectEmplForecast _ProjectEmplForecast;
        partial void OnProjectEmplForecastChanging(global::Microsoft.Dynamics.DataEntities.ProjectEmplForecast value);
        partial void OnProjectEmplForecastChanged();
        /// <summary>
        /// There are no comments for Property ProjectExpenseForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecast ProjectExpenseForecast
        {
            get
            {
                return this._ProjectExpenseForecast;
            }
            set
            {
                this.OnProjectExpenseForecastChanging(value);
                this._ProjectExpenseForecast = value;
                this.OnProjectExpenseForecastChanged();
                this.OnPropertyChanged("ProjectExpenseForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecast _ProjectExpenseForecast;
        partial void OnProjectExpenseForecastChanging(global::Microsoft.Dynamics.DataEntities.ProjectExpenseForecast value);
        partial void OnProjectExpenseForecastChanged();
        /// <summary>
        /// There are no comments for Property WBS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> WBS
        {
            get
            {
                return this._WBS;
            }
            set
            {
                this.OnWBSChanging(value);
                this._WBS = value;
                this.OnWBSChanged();
                this.OnPropertyChanged("WBS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> _WBS = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWBSChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjectWBSDraft> value);
        partial void OnWBSChanged();
        /// <summary>
        /// There are no comments for Property TransferPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TransferPrice> TransferPrice
        {
            get
            {
                return this._TransferPrice;
            }
            set
            {
                this.OnTransferPriceChanging(value);
                this._TransferPrice = value;
                this.OnTransferPriceChanged();
                this.OnPropertyChanged("TransferPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TransferPrice> _TransferPrice = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TransferPrice>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTransferPriceChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TransferPrice> value);
        partial void OnTransferPriceChanged();
        /// <summary>
        /// There are no comments for Property ProjectFeeForecast in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProjectFeeForecast ProjectFeeForecast
        {
            get
            {
                return this._ProjectFeeForecast;
            }
            set
            {
                this.OnProjectFeeForecastChanging(value);
                this._ProjectFeeForecast = value;
                this.OnProjectFeeForecastChanged();
                this.OnPropertyChanged("ProjectFeeForecast");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProjectFeeForecast _ProjectFeeForecast;
        partial void OnProjectFeeForecastChanging(global::Microsoft.Dynamics.DataEntities.ProjectFeeForecast value);
        partial void OnProjectFeeForecastChanged();
        /// <summary>
        /// There are no comments for Property JournalTrans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.JournalTrans JournalTrans
        {
            get
            {
                return this._JournalTrans;
            }
            set
            {
                this.OnJournalTransChanging(value);
                this._JournalTrans = value;
                this.OnJournalTransChanged();
                this.OnPropertyChanged("JournalTrans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.JournalTrans _JournalTrans;
        partial void OnJournalTransChanging(global::Microsoft.Dynamics.DataEntities.JournalTrans value);
        partial void OnJournalTransChanged();
        /// <summary>
        /// There are no comments for Property ProjWBSTemplateTask in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> ProjWBSTemplateTask
        {
            get
            {
                return this._ProjWBSTemplateTask;
            }
            set
            {
                this.OnProjWBSTemplateTaskChanging(value);
                this._ProjWBSTemplateTask = value;
                this.OnProjWBSTemplateTaskChanged();
                this.OnPropertyChanged("ProjWBSTemplateTask");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> _ProjWBSTemplateTask = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProjWBSTemplateTaskChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ProjWBSTemplateTask> value);
        partial void OnProjWBSTemplateTaskChanged();
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
