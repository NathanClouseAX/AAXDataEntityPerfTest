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
    /// There are no comments for CompensationPayPerformanceAllocationSingle in the schema.
    /// </summary>
    public partial class CompensationPayPerformanceAllocationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPayPerformanceAllocation>
    {
        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CompensationPayPerformanceAllocationSingle object.
        /// </summary>
        public CompensationPayPerformanceAllocationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CompensationPayPerformanceAllocation> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for CompensationPerformancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlanSingle CompensationPerformancePlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPerformancePlan == null))
                {
                    this._CompensationPerformancePlan = new global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlanSingle(this.Context, GetPath("CompensationPerformancePlan"));
                }
                return this._CompensationPerformancePlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlanSingle _CompensationPerformancePlan;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DepartmentSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Microsoft.Dynamics.DataEntities.DepartmentSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DepartmentSingle _Department;
        /// <summary>
        /// There are no comments for OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle OperatingUnit
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperatingUnit == null))
                {
                    this._OperatingUnit = new global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle(this.Context, GetPath("OperatingUnit"));
                }
                return this._OperatingUnit;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnitSingle _OperatingUnit;
        /// <summary>
        /// There are no comments for CompensationPayPerformanceAllocationLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> CompensationPayPerformanceAllocationLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CompensationPayPerformanceAllocationLine == null))
                {
                    this._CompensationPayPerformanceAllocationLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine>(GetPath("CompensationPayPerformanceAllocationLine"));
                }
                return this._CompensationPayPerformanceAllocationLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> _CompensationPayPerformanceAllocationLine;
    }
    /// <summary>
    /// There are no comments for CompensationPayPerformanceAllocation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DepartmentNumber
    /// Plan
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DepartmentNumber", "Plan")]
    [global::Microsoft.OData.Client.EntitySet("CompensationPayPerformanceAllocations")]
    public partial class CompensationPayPerformanceAllocation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CompensationPayPerformanceAllocation object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="departmentNumber">Initial value of DepartmentNumber.</param>
        /// <param name="plan">Initial value of Plan.</param>
        /// <param name="expiration">Initial value of Expiration.</param>
        /// <param name="effective">Initial value of Effective.</param>
        /// <param name="compensationPerformancePlan">Initial value of CompensationPerformancePlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CompensationPayPerformanceAllocation CreateCompensationPayPerformanceAllocation(string dataAreaId, 
                    string departmentNumber, 
                    string plan, 
                    global::System.DateTimeOffset expiration, 
                    global::System.DateTimeOffset effective, 
                    global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlan compensationPerformancePlan)
        {
            CompensationPayPerformanceAllocation compensationPayPerformanceAllocation = new CompensationPayPerformanceAllocation();
            compensationPayPerformanceAllocation.dataAreaId = dataAreaId;
            compensationPayPerformanceAllocation.DepartmentNumber = departmentNumber;
            compensationPayPerformanceAllocation.Plan = plan;
            compensationPayPerformanceAllocation.Expiration = expiration;
            compensationPayPerformanceAllocation.Effective = effective;
            if ((compensationPerformancePlan == null))
            {
                throw new global::System.ArgumentNullException("compensationPerformancePlan");
            }
            compensationPayPerformanceAllocation.CompensationPerformancePlan = compensationPerformancePlan;
            return compensationPayPerformanceAllocation;
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
        /// There are no comments for Property DepartmentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DepartmentNumber is required.")]
        public virtual string DepartmentNumber
        {
            get
            {
                return this._DepartmentNumber;
            }
            set
            {
                this.OnDepartmentNumberChanging(value);
                this._DepartmentNumber = value;
                this.OnDepartmentNumberChanged();
                this.OnPropertyChanged("DepartmentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepartmentNumber;
        partial void OnDepartmentNumberChanging(string value);
        partial void OnDepartmentNumberChanged();
        /// <summary>
        /// There are no comments for Property Plan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Plan is required.")]
        public virtual string Plan
        {
            get
            {
                return this._Plan;
            }
            set
            {
                this.OnPlanChanging(value);
                this._Plan = value;
                this.OnPlanChanged();
                this.OnPropertyChanged("Plan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Plan;
        partial void OnPlanChanging(string value);
        partial void OnPlanChanged();
        /// <summary>
        /// There are no comments for Property Allocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string Allocation
        {
            get
            {
                return this._Allocation;
            }
            set
            {
                this.OnAllocationChanging(value);
                this._Allocation = value;
                this.OnAllocationChanged();
                this.OnPropertyChanged("Allocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Allocation;
        partial void OnAllocationChanging(string value);
        partial void OnAllocationChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

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
        /// There are no comments for Property Expiration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Expiration is required.")]
        public virtual global::System.DateTimeOffset Expiration
        {
            get
            {
                return this._Expiration;
            }
            set
            {
                this.OnExpirationChanging(value);
                this._Expiration = value;
                this.OnExpirationChanged();
                this.OnPropertyChanged("Expiration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Expiration;
        partial void OnExpirationChanging(global::System.DateTimeOffset value);
        partial void OnExpirationChanged();
        /// <summary>
        /// There are no comments for Property Effective in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Effective is required.")]
        public virtual global::System.DateTimeOffset Effective
        {
            get
            {
                return this._Effective;
            }
            set
            {
                this.OnEffectiveChanging(value);
                this._Effective = value;
                this.OnEffectiveChanged();
                this.OnPropertyChanged("Effective");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _Effective;
        partial void OnEffectiveChanging(global::System.DateTimeOffset value);
        partial void OnEffectiveChanged();
        /// <summary>
        /// There are no comments for Property CompensationPerformancePlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CompensationPerformancePlan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlan CompensationPerformancePlan
        {
            get
            {
                return this._CompensationPerformancePlan;
            }
            set
            {
                this.OnCompensationPerformancePlanChanging(value);
                this._CompensationPerformancePlan = value;
                this.OnCompensationPerformancePlanChanged();
                this.OnPropertyChanged("CompensationPerformancePlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlan _CompensationPerformancePlan;
        partial void OnCompensationPerformancePlanChanging(global::Microsoft.Dynamics.DataEntities.CompensationPerformancePlan value);
        partial void OnCompensationPerformancePlanChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.Department Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Department _Department;
        partial void OnDepartmentChanging(global::Microsoft.Dynamics.DataEntities.Department value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property OperatingUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.OperatingUnit OperatingUnit
        {
            get
            {
                return this._OperatingUnit;
            }
            set
            {
                this.OnOperatingUnitChanging(value);
                this._OperatingUnit = value;
                this.OnOperatingUnitChanged();
                this.OnPropertyChanged("OperatingUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperatingUnit _OperatingUnit;
        partial void OnOperatingUnitChanging(global::Microsoft.Dynamics.DataEntities.OperatingUnit value);
        partial void OnOperatingUnitChanged();
        /// <summary>
        /// There are no comments for Property CompensationPayPerformanceAllocationLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> CompensationPayPerformanceAllocationLine
        {
            get
            {
                return this._CompensationPayPerformanceAllocationLine;
            }
            set
            {
                this.OnCompensationPayPerformanceAllocationLineChanging(value);
                this._CompensationPayPerformanceAllocationLine = value;
                this.OnCompensationPayPerformanceAllocationLineChanged();
                this.OnPropertyChanged("CompensationPayPerformanceAllocationLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> _CompensationPayPerformanceAllocationLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCompensationPayPerformanceAllocationLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.CompensationPayPerformanceAllocationLine> value);
        partial void OnCompensationPayPerformanceAllocationLineChanged();
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
