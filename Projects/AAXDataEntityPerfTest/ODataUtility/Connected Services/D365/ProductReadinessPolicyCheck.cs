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
        /// There are no comments for ProductReadinessPolicyCheckSingle in the schema.
        /// </summary>
    public partial class ProductReadinessPolicyCheckSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReadinessPolicyCheck>
    {
        /// <summary>
        /// Initialize a new ProductReadinessPolicyCheckSingle object.
        /// </summary>
        public ProductReadinessPolicyCheckSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProductReadinessPolicyCheckSingle object.
        /// </summary>
        public ProductReadinessPolicyCheckSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProductReadinessPolicyCheckSingle object.
        /// </summary>
        public ProductReadinessPolicyCheckSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProductReadinessPolicyCheck> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductReadinessPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicySingle ProductReadinessPolicy
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductReadinessPolicy == null))
                {
                    this._ProductReadinessPolicy = new global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicySingle(this.Context, GetPath("ProductReadinessPolicy"));
                }
                return this._ProductReadinessPolicy;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicySingle _ProductReadinessPolicy;
        /// <summary>
        /// There are no comments for OwningPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle OwningPerson
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OwningPerson == null))
                {
                    this._OwningPerson = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("OwningPerson"));
                }
                return this._OwningPerson;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _OwningPerson;
        /// <summary>
        /// There are no comments for OwningTeamV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamV2Single OwningTeamV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OwningTeamV2 == null))
                {
                    this._OwningTeamV2 = new global::Microsoft.Dynamics.DataEntities.TeamV2Single(this.Context, GetPath("OwningTeamV2"));
                }
                return this._OwningTeamV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamV2Single _OwningTeamV2;
        /// <summary>
        /// There are no comments for ReleasedProductReadinessChecks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck> ReleasedProductReadinessChecks
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductReadinessChecks == null))
                {
                    this._ReleasedProductReadinessChecks = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck>(GetPath("ReleasedProductReadinessChecks"));
                }
                return this._ReleasedProductReadinessChecks;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck> _ReleasedProductReadinessChecks;
    }
        /// <summary>
        /// There are no comments for ProductReadinessPolicyCheck in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// ProductReadinessPolicyName
    /// CheckName
    /// LegalEntityId
    /// ProcessArea
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "ProductReadinessPolicyName", "CheckName", "LegalEntityId", "ProcessArea")]
    [global::Microsoft.OData.Client.EntitySet("ProductReadinessPolicyChecks")]
    public partial class ProductReadinessPolicyCheck : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductReadinessPolicyCheck object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="productReadinessPolicyName">Initial value of ProductReadinessPolicyName.</param>
        /// <param name="checkName">Initial value of CheckName.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="productReadinessPolicy">Initial value of ProductReadinessPolicy.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProductReadinessPolicyCheck CreateProductReadinessPolicyCheck(string dataAreaId, string productReadinessPolicyName, string checkName, string legalEntityId, global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicy productReadinessPolicy)
        {
            ProductReadinessPolicyCheck productReadinessPolicyCheck = new ProductReadinessPolicyCheck();
            productReadinessPolicyCheck.dataAreaId = dataAreaId;
            productReadinessPolicyCheck.ProductReadinessPolicyName = productReadinessPolicyName;
            productReadinessPolicyCheck.CheckName = checkName;
            productReadinessPolicyCheck.LegalEntityId = legalEntityId;
            if ((productReadinessPolicy == null))
            {
                throw new global::System.ArgumentNullException("productReadinessPolicy");
            }
            productReadinessPolicyCheck.ProductReadinessPolicy = productReadinessPolicy;
            return productReadinessPolicyCheck;
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
        /// There are no comments for Property ProductReadinessPolicyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductReadinessPolicyName
        {
            get
            {
                return this._ProductReadinessPolicyName;
            }
            set
            {
                this.OnProductReadinessPolicyNameChanging(value);
                this._ProductReadinessPolicyName = value;
                this.OnProductReadinessPolicyNameChanged();
                this.OnPropertyChanged("ProductReadinessPolicyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductReadinessPolicyName;
        partial void OnProductReadinessPolicyNameChanging(string value);
        partial void OnProductReadinessPolicyNameChanged();
        /// <summary>
        /// There are no comments for Property CheckName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CheckName
        {
            get
            {
                return this._CheckName;
            }
            set
            {
                this.OnCheckNameChanging(value);
                this._CheckName = value;
                this.OnCheckNameChanged();
                this.OnPropertyChanged("CheckName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckName;
        partial void OnCheckNameChanging(string value);
        partial void OnCheckNameChanged();
        /// <summary>
        /// There are no comments for Property LegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LegalEntityId
        {
            get
            {
                return this._LegalEntityId;
            }
            set
            {
                this.OnLegalEntityIdChanging(value);
                this._LegalEntityId = value;
                this.OnLegalEntityIdChanged();
                this.OnPropertyChanged("LegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntityId;
        partial void OnLegalEntityIdChanging(string value);
        partial void OnLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property ProcessArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessModule> ProcessArea
        {
            get
            {
                return this._ProcessArea;
            }
            set
            {
                this.OnProcessAreaChanging(value);
                this._ProcessArea = value;
                this.OnProcessAreaChanged();
                this.OnPropertyChanged("ProcessArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessModule> _ProcessArea;
        partial void OnProcessAreaChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessModule> value);
        partial void OnProcessAreaChanged();
        /// <summary>
        /// There are no comments for Property CheckType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessType> CheckType
        {
            get
            {
                return this._CheckType;
            }
            set
            {
                this.OnCheckTypeChanging(value);
                this._CheckType = value;
                this.OnCheckTypeChanged();
                this.OnPropertyChanged("CheckType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessType> _CheckType;
        partial void OnCheckTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessType> value);
        partial void OnCheckTypeChanged();
        /// <summary>
        /// There are no comments for Property OwningTeamName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OwningTeamName
        {
            get
            {
                return this._OwningTeamName;
            }
            set
            {
                this.OnOwningTeamNameChanging(value);
                this._OwningTeamName = value;
                this.OnOwningTeamNameChanged();
                this.OnPropertyChanged("OwningTeamName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OwningTeamName;
        partial void OnOwningTeamNameChanging(string value);
        partial void OnOwningTeamNameChanged();
        /// <summary>
        /// There are no comments for Property CheckListQuestionnaireId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CheckListQuestionnaireId
        {
            get
            {
                return this._CheckListQuestionnaireId;
            }
            set
            {
                this.OnCheckListQuestionnaireIdChanging(value);
                this._CheckListQuestionnaireId = value;
                this.OnCheckListQuestionnaireIdChanged();
                this.OnPropertyChanged("CheckListQuestionnaireId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckListQuestionnaireId;
        partial void OnCheckListQuestionnaireIdChanging(string value);
        partial void OnCheckListQuestionnaireIdChanged();
        /// <summary>
        /// There are no comments for Property CheckDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CheckDescription
        {
            get
            {
                return this._CheckDescription;
            }
            set
            {
                this.OnCheckDescriptionChanging(value);
                this._CheckDescription = value;
                this.OnCheckDescriptionChanged();
                this.OnPropertyChanged("CheckDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckDescription;
        partial void OnCheckDescriptionChanging(string value);
        partial void OnCheckDescriptionChanged();
        /// <summary>
        /// There are no comments for Property IsCheckMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsCheckMandatory
        {
            get
            {
                return this._IsCheckMandatory;
            }
            set
            {
                this.OnIsCheckMandatoryChanging(value);
                this._IsCheckMandatory = value;
                this.OnIsCheckMandatoryChanged();
                this.OnPropertyChanged("IsCheckMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsCheckMandatory;
        partial void OnIsCheckMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsCheckMandatoryChanged();
        /// <summary>
        /// There are no comments for Property CheckReleaseCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessCheckType> CheckReleaseCategory
        {
            get
            {
                return this._CheckReleaseCategory;
            }
            set
            {
                this.OnCheckReleaseCategoryChanging(value);
                this._CheckReleaseCategory = value;
                this.OnCheckReleaseCategoryChanged();
                this.OnPropertyChanged("CheckReleaseCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessCheckType> _CheckReleaseCategory;
        partial void OnCheckReleaseCategoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessCheckType> value);
        partial void OnCheckReleaseCategoryChanged();
        /// <summary>
        /// There are no comments for Property WillCheckAutomaticallyApproveResult in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillCheckAutomaticallyApproveResult
        {
            get
            {
                return this._WillCheckAutomaticallyApproveResult;
            }
            set
            {
                this.OnWillCheckAutomaticallyApproveResultChanging(value);
                this._WillCheckAutomaticallyApproveResult = value;
                this.OnWillCheckAutomaticallyApproveResultChanged();
                this.OnPropertyChanged("WillCheckAutomaticallyApproveResult");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillCheckAutomaticallyApproveResult;
        partial void OnWillCheckAutomaticallyApproveResultChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillCheckAutomaticallyApproveResultChanged();
        /// <summary>
        /// There are no comments for Property CheckClassName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CheckClassName
        {
            get
            {
                return this._CheckClassName;
            }
            set
            {
                this.OnCheckClassNameChanging(value);
                this._CheckClassName = value;
                this.OnCheckClassNameChanged();
                this.OnPropertyChanged("CheckClassName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckClassName;
        partial void OnCheckClassNameChanging(string value);
        partial void OnCheckClassNameChanged();
        /// <summary>
        /// There are no comments for Property ExecutionScope in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessExecute> ExecutionScope
        {
            get
            {
                return this._ExecutionScope;
            }
            set
            {
                this.OnExecutionScopeChanging(value);
                this._ExecutionScope = value;
                this.OnExecutionScopeChanged();
                this.OnPropertyChanged("ExecutionScope");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessExecute> _ExecutionScope;
        partial void OnExecutionScopeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.EngChgReadinessExecute> value);
        partial void OnExecutionScopeChanged();
        /// <summary>
        /// There are no comments for Property OwningPersonPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OwningPersonPartyNumber
        {
            get
            {
                return this._OwningPersonPartyNumber;
            }
            set
            {
                this.OnOwningPersonPartyNumberChanging(value);
                this._OwningPersonPartyNumber = value;
                this.OnOwningPersonPartyNumberChanged();
                this.OnPropertyChanged("OwningPersonPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OwningPersonPartyNumber;
        partial void OnOwningPersonPartyNumberChanging(string value);
        partial void OnOwningPersonPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductReadinessPolicy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicy ProductReadinessPolicy
        {
            get
            {
                return this._ProductReadinessPolicy;
            }
            set
            {
                this.OnProductReadinessPolicyChanging(value);
                this._ProductReadinessPolicy = value;
                this.OnProductReadinessPolicyChanged();
                this.OnPropertyChanged("ProductReadinessPolicy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicy _ProductReadinessPolicy;
        partial void OnProductReadinessPolicyChanging(global::Microsoft.Dynamics.DataEntities.ProductReadinessPolicy value);
        partial void OnProductReadinessPolicyChanged();
        /// <summary>
        /// There are no comments for Property OwningPerson in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person OwningPerson
        {
            get
            {
                return this._OwningPerson;
            }
            set
            {
                this.OnOwningPersonChanging(value);
                this._OwningPerson = value;
                this.OnOwningPersonChanged();
                this.OnPropertyChanged("OwningPerson");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _OwningPerson;
        partial void OnOwningPersonChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnOwningPersonChanged();
        /// <summary>
        /// There are no comments for Property OwningTeamV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamV2 OwningTeamV2
        {
            get
            {
                return this._OwningTeamV2;
            }
            set
            {
                this.OnOwningTeamV2Changing(value);
                this._OwningTeamV2 = value;
                this.OnOwningTeamV2Changed();
                this.OnPropertyChanged("OwningTeamV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamV2 _OwningTeamV2;
        partial void OnOwningTeamV2Changing(global::Microsoft.Dynamics.DataEntities.TeamV2 value);
        partial void OnOwningTeamV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductReadinessChecks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck> ReleasedProductReadinessChecks
        {
            get
            {
                return this._ReleasedProductReadinessChecks;
            }
            set
            {
                this.OnReleasedProductReadinessChecksChanging(value);
                this._ReleasedProductReadinessChecks = value;
                this.OnReleasedProductReadinessChecksChanged();
                this.OnPropertyChanged("ReleasedProductReadinessChecks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck> _ReleasedProductReadinessChecks = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductReadinessChecksChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductReadinessCheck> value);
        partial void OnReleasedProductReadinessChecksChanged();
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
