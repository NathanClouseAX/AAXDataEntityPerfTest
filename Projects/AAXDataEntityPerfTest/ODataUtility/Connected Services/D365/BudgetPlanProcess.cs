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
    /// There are no comments for BudgetPlanProcessSingle in the schema.
    /// </summary>
    public partial class BudgetPlanProcessSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetPlanProcess>
    {
        /// <summary>
        /// Initialize a new BudgetPlanProcessSingle object.
        /// </summary>
        public BudgetPlanProcessSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetPlanProcessSingle object.
        /// </summary>
        public BudgetPlanProcessSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetPlanProcessSingle object.
        /// </summary>
        public BudgetPlanProcessSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BudgetPlanProcess> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetTrackingWorkspaceParametersBudgetPlanProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetPlanProcess
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetTrackingWorkspaceParametersBudgetPlanProcess == null))
                {
                    this._BudgetTrackingWorkspaceParametersBudgetPlanProcess = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(GetPath("BudgetTrackingWorkspaceParametersBudgetPlanProcess"));
                }
                return this._BudgetTrackingWorkspaceParametersBudgetPlanProcess;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetPlanProcess;
    }
    /// <summary>
    /// There are no comments for BudgetPlanProcess in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("BudgetPlanProcesses")]
    public partial class BudgetPlanProcess : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BudgetPlanProcess object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BudgetPlanProcess CreateBudgetPlanProcess(string name)
        {
            BudgetPlanProcess budgetPlanProcess = new BudgetPlanProcess();
            budgetPlanProcess.Name = name;
            return budgetPlanProcess;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property AccountStructure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string AccountStructure
        {
            get
            {
                return this._AccountStructure;
            }
            set
            {
                this.OnAccountStructureChanging(value);
                this._AccountStructure = value;
                this.OnAccountStructureChanged();
                this.OnPropertyChanged("AccountStructure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountStructure;
        partial void OnAccountStructureChanging(string value);
        partial void OnAccountStructureChanged();
        /// <summary>
        /// There are no comments for Property OrganizationtHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string OrganizationtHierarchyType
        {
            get
            {
                return this._OrganizationtHierarchyType;
            }
            set
            {
                this.OnOrganizationtHierarchyTypeChanging(value);
                this._OrganizationtHierarchyType = value;
                this.OnOrganizationtHierarchyTypeChanged();
                this.OnPropertyChanged("OrganizationtHierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationtHierarchyType;
        partial void OnOrganizationtHierarchyTypeChanging(string value);
        partial void OnOrganizationtHierarchyTypeChanged();
        /// <summary>
        /// There are no comments for Property ApprovalProcessState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetPlanningApprovalProcessState> ApprovalProcessState
        {
            get
            {
                return this._ApprovalProcessState;
            }
            set
            {
                this.OnApprovalProcessStateChanging(value);
                this._ApprovalProcessState = value;
                this.OnApprovalProcessStateChanged();
                this.OnPropertyChanged("ApprovalProcessState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetPlanningApprovalProcessState> _ApprovalProcessState;
        partial void OnApprovalProcessStateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.BudgetPlanningApprovalProcessState> value);
        partial void OnApprovalProcessStateChanged();
        /// <summary>
        /// There are no comments for Property FiscalCalendarId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string FiscalCalendarId
        {
            get
            {
                return this._FiscalCalendarId;
            }
            set
            {
                this.OnFiscalCalendarIdChanging(value);
                this._FiscalCalendarId = value;
                this.OnFiscalCalendarIdChanged();
                this.OnPropertyChanged("FiscalCalendarId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalCalendarId;
        partial void OnFiscalCalendarIdChanging(string value);
        partial void OnFiscalCalendarIdChanged();
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
        /// There are no comments for Property BudgetCycle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string BudgetCycle
        {
            get
            {
                return this._BudgetCycle;
            }
            set
            {
                this.OnBudgetCycleChanging(value);
                this._BudgetCycle = value;
                this.OnBudgetCycleChanged();
                this.OnPropertyChanged("BudgetCycle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycle;
        partial void OnBudgetCycleChanging(string value);
        partial void OnBudgetCycleChanged();
        /// <summary>
        /// There are no comments for Property BudgetCycleTimeSpan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string BudgetCycleTimeSpan
        {
            get
            {
                return this._BudgetCycleTimeSpan;
            }
            set
            {
                this.OnBudgetCycleTimeSpanChanging(value);
                this._BudgetCycleTimeSpan = value;
                this.OnBudgetCycleTimeSpanChanged();
                this.OnPropertyChanged("BudgetCycleTimeSpan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BudgetCycleTimeSpan;
        partial void OnBudgetCycleTimeSpanChanging(string value);
        partial void OnBudgetCycleTimeSpanChanged();
        /// <summary>
        /// There are no comments for Property Ledger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Ledger
        {
            get
            {
                return this._Ledger;
            }
            set
            {
                this.OnLedgerChanging(value);
                this._Ledger = value;
                this.OnLedgerChanged();
                this.OnPropertyChanged("Ledger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Ledger;
        partial void OnLedgerChanging(string value);
        partial void OnLedgerChanged();
        /// <summary>
        /// There are no comments for Property BudgetTrackingWorkspaceParametersBudgetPlanProcess in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> BudgetTrackingWorkspaceParametersBudgetPlanProcess
        {
            get
            {
                return this._BudgetTrackingWorkspaceParametersBudgetPlanProcess;
            }
            set
            {
                this.OnBudgetTrackingWorkspaceParametersBudgetPlanProcessChanging(value);
                this._BudgetTrackingWorkspaceParametersBudgetPlanProcess = value;
                this.OnBudgetTrackingWorkspaceParametersBudgetPlanProcessChanged();
                this.OnPropertyChanged("BudgetTrackingWorkspaceParametersBudgetPlanProcess");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> _BudgetTrackingWorkspaceParametersBudgetPlanProcess = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBudgetTrackingWorkspaceParametersBudgetPlanProcessChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.BudgetTrackingWorkspaceParameters> value);
        partial void OnBudgetTrackingWorkspaceParametersBudgetPlanProcessChanged();
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
