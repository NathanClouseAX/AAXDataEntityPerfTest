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
    /// There are no comments for VeteranStatusSingle in the schema.
    /// </summary>
    public partial class VeteranStatusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<VeteranStatus>
    {
        /// <summary>
        /// Initialize a new VeteranStatusSingle object.
        /// </summary>
        public VeteranStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new VeteranStatusSingle object.
        /// </summary>
        public VeteranStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new VeteranStatusSingle object.
        /// </summary>
        public VeteranStatusSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<VeteranStatus> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Contractors == null))
                {
                    this._Contractors = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Contractor>(GetPath("Contractors"));
                }
                return this._Contractors;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors;
        /// <summary>
        /// There are no comments for PersonDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonDetails> PersonDetails
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonDetails == null))
                {
                    this._PersonDetails = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonDetails>(GetPath("PersonDetails"));
                }
                return this._PersonDetails;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonDetails> _PersonDetails;
        /// <summary>
        /// There are no comments for Applicants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Applicant> Applicants
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Applicants == null))
                {
                    this._Applicants = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Applicant>(GetPath("Applicants"));
                }
                return this._Applicants;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Applicant> _Applicants;
        /// <summary>
        /// There are no comments for Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Workers == null))
                {
                    this._Workers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Worker>(GetPath("Workers"));
                }
                return this._Workers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Worker> _Workers;
        /// <summary>
        /// There are no comments for Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employees == null))
                {
                    this._Employees = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Employee>(GetPath("Employees"));
                }
                return this._Employees;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Employee> _Employees;
    }
    /// <summary>
    /// There are no comments for VeteranStatus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// VeteranStatusId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("VeteranStatusId")]
    [global::Microsoft.OData.Client.EntitySet("VeteranStatuses")]
    public partial class VeteranStatus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new VeteranStatus object.
        /// </summary>
        /// <param name="veteranStatusId">Initial value of VeteranStatusId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static VeteranStatus CreateVeteranStatus(string veteranStatusId)
        {
            VeteranStatus veteranStatus = new VeteranStatus();
            veteranStatus.VeteranStatusId = veteranStatusId;
            return veteranStatus;
        }
        /// <summary>
        /// There are no comments for Property VeteranStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VeteranStatusId is required.")]
        public virtual string VeteranStatusId
        {
            get
            {
                return this._VeteranStatusId;
            }
            set
            {
                this.OnVeteranStatusIdChanging(value);
                this._VeteranStatusId = value;
                this.OnVeteranStatusIdChanged();
                this.OnPropertyChanged("VeteranStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VeteranStatusId;
        partial void OnVeteranStatusIdChanging(string value);
        partial void OnVeteranStatusIdChanged();
        /// <summary>
        /// There are no comments for Property IsProtectedVeteran in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsProtectedVeteran
        {
            get
            {
                return this._IsProtectedVeteran;
            }
            set
            {
                this.OnIsProtectedVeteranChanging(value);
                this._IsProtectedVeteran = value;
                this.OnIsProtectedVeteranChanged();
                this.OnPropertyChanged("IsProtectedVeteran");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsProtectedVeteran;
        partial void OnIsProtectedVeteranChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsProtectedVeteranChanged();
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
        /// There are no comments for Property Contractors in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> Contractors
        {
            get
            {
                return this._Contractors;
            }
            set
            {
                this.OnContractorsChanging(value);
                this._Contractors = value;
                this.OnContractorsChanged();
                this.OnPropertyChanged("Contractors");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> _Contractors = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContractorsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Contractor> value);
        partial void OnContractorsChanged();
        /// <summary>
        /// There are no comments for Property PersonDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonDetails> PersonDetails
        {
            get
            {
                return this._PersonDetails;
            }
            set
            {
                this.OnPersonDetailsChanging(value);
                this._PersonDetails = value;
                this.OnPersonDetailsChanged();
                this.OnPropertyChanged("PersonDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonDetails> _PersonDetails = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonDetails>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonDetailsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonDetails> value);
        partial void OnPersonDetailsChanged();
        /// <summary>
        /// There are no comments for Property Applicants in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> Applicants
        {
            get
            {
                return this._Applicants;
            }
            set
            {
                this.OnApplicantsChanging(value);
                this._Applicants = value;
                this.OnApplicantsChanged();
                this.OnPropertyChanged("Applicants");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> _Applicants = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnApplicantsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Applicant> value);
        partial void OnApplicantsChanged();
        /// <summary>
        /// There are no comments for Property Workers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> Workers
        {
            get
            {
                return this._Workers;
            }
            set
            {
                this.OnWorkersChanging(value);
                this._Workers = value;
                this.OnWorkersChanged();
                this.OnPropertyChanged("Workers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> _Workers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Worker> value);
        partial void OnWorkersChanged();
        /// <summary>
        /// There are no comments for Property Employees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> Employees
        {
            get
            {
                return this._Employees;
            }
            set
            {
                this.OnEmployeesChanging(value);
                this._Employees = value;
                this.OnEmployeesChanged();
                this.OnPropertyChanged("Employees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> _Employees = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Employee> value);
        partial void OnEmployeesChanged();
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
