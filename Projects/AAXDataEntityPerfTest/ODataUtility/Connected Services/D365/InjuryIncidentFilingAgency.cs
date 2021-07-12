﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 6/6/2021 9:11:38 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for InjuryIncidentFilingAgencySingle in the schema.
        /// </summary>
    public partial class InjuryIncidentFilingAgencySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryIncidentFilingAgency>
    {
        /// <summary>
        /// Initialize a new InjuryIncidentFilingAgencySingle object.
        /// </summary>
        public InjuryIncidentFilingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InjuryIncidentFilingAgencySingle object.
        /// </summary>
        public InjuryIncidentFilingAgencySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InjuryIncidentFilingAgencySingle object.
        /// </summary>
        public InjuryIncidentFilingAgencySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InjuryIncidentFilingAgency> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InjuryIncident in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryIncidentSingle InjuryIncident
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InjuryIncident == null))
                {
                    this._InjuryIncident = new global::Microsoft.Dynamics.DataEntities.InjuryIncidentSingle(this.Context, GetPath("InjuryIncident"));
                }
                return this._InjuryIncident;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryIncidentSingle _InjuryIncident;
        /// <summary>
        /// There are no comments for InjuryFilingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryFilingAgencySingle InjuryFilingAgency
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InjuryFilingAgency == null))
                {
                    this._InjuryFilingAgency = new global::Microsoft.Dynamics.DataEntities.InjuryFilingAgencySingle(this.Context, GetPath("InjuryFilingAgency"));
                }
                return this._InjuryFilingAgency;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryFilingAgencySingle _InjuryFilingAgency;
    }
        /// <summary>
        /// There are no comments for InjuryIncidentFilingAgency in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CaseNumber
    /// FilingAgencyId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CaseNumber", "FilingAgencyId")]
    [global::Microsoft.OData.Client.EntitySet("InjuryIncidentFilingAgencies")]
    public partial class InjuryIncidentFilingAgency : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InjuryIncidentFilingAgency object.
        /// </summary>
        /// <param name="caseNumber">Initial value of CaseNumber.</param>
        /// <param name="filingAgencyId">Initial value of FilingAgencyId.</param>
        /// <param name="reportSubmitDateTime">Initial value of ReportSubmitDateTime.</param>
        /// <param name="injuryIncident">Initial value of InjuryIncident.</param>
        /// <param name="injuryFilingAgency">Initial value of InjuryFilingAgency.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InjuryIncidentFilingAgency CreateInjuryIncidentFilingAgency(string caseNumber, string filingAgencyId, global::System.DateTimeOffset reportSubmitDateTime, global::Microsoft.Dynamics.DataEntities.InjuryIncident injuryIncident, global::Microsoft.Dynamics.DataEntities.InjuryFilingAgency injuryFilingAgency)
        {
            InjuryIncidentFilingAgency injuryIncidentFilingAgency = new InjuryIncidentFilingAgency();
            injuryIncidentFilingAgency.CaseNumber = caseNumber;
            injuryIncidentFilingAgency.FilingAgencyId = filingAgencyId;
            injuryIncidentFilingAgency.ReportSubmitDateTime = reportSubmitDateTime;
            if ((injuryIncident == null))
            {
                throw new global::System.ArgumentNullException("injuryIncident");
            }
            injuryIncidentFilingAgency.InjuryIncident = injuryIncident;
            if ((injuryFilingAgency == null))
            {
                throw new global::System.ArgumentNullException("injuryFilingAgency");
            }
            injuryIncidentFilingAgency.InjuryFilingAgency = injuryFilingAgency;
            return injuryIncidentFilingAgency;
        }
        /// <summary>
        /// There are no comments for Property CaseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CaseNumber
        {
            get
            {
                return this._CaseNumber;
            }
            set
            {
                this.OnCaseNumberChanging(value);
                this._CaseNumber = value;
                this.OnCaseNumberChanged();
                this.OnPropertyChanged("CaseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CaseNumber;
        partial void OnCaseNumberChanging(string value);
        partial void OnCaseNumberChanged();
        /// <summary>
        /// There are no comments for Property FilingAgencyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string FilingAgencyId
        {
            get
            {
                return this._FilingAgencyId;
            }
            set
            {
                this.OnFilingAgencyIdChanging(value);
                this._FilingAgencyId = value;
                this.OnFilingAgencyIdChanged();
                this.OnPropertyChanged("FilingAgencyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FilingAgencyId;
        partial void OnFilingAgencyIdChanging(string value);
        partial void OnFilingAgencyIdChanged();
        /// <summary>
        /// There are no comments for Property ReportSubmitDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ReportSubmitDateTime
        {
            get
            {
                return this._ReportSubmitDateTime;
            }
            set
            {
                this.OnReportSubmitDateTimeChanging(value);
                this._ReportSubmitDateTime = value;
                this.OnReportSubmitDateTimeChanged();
                this.OnPropertyChanged("ReportSubmitDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ReportSubmitDateTime;
        partial void OnReportSubmitDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnReportSubmitDateTimeChanged();
        /// <summary>
        /// There are no comments for Property Comments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Comments
        {
            get
            {
                return this._Comments;
            }
            set
            {
                this.OnCommentsChanging(value);
                this._Comments = value;
                this.OnCommentsChanged();
                this.OnPropertyChanged("Comments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comments;
        partial void OnCommentsChanging(string value);
        partial void OnCommentsChanged();
        /// <summary>
        /// There are no comments for Property AgencyWasNotified in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> AgencyWasNotified
        {
            get
            {
                return this._AgencyWasNotified;
            }
            set
            {
                this.OnAgencyWasNotifiedChanging(value);
                this._AgencyWasNotified = value;
                this.OnAgencyWasNotifiedChanged();
                this.OnPropertyChanged("AgencyWasNotified");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _AgencyWasNotified;
        partial void OnAgencyWasNotifiedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnAgencyWasNotifiedChanged();
        /// <summary>
        /// There are no comments for Property InjuryIncident in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryIncident InjuryIncident
        {
            get
            {
                return this._InjuryIncident;
            }
            set
            {
                this.OnInjuryIncidentChanging(value);
                this._InjuryIncident = value;
                this.OnInjuryIncidentChanged();
                this.OnPropertyChanged("InjuryIncident");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryIncident _InjuryIncident;
        partial void OnInjuryIncidentChanging(global::Microsoft.Dynamics.DataEntities.InjuryIncident value);
        partial void OnInjuryIncidentChanged();
        /// <summary>
        /// There are no comments for Property InjuryFilingAgency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.InjuryFilingAgency InjuryFilingAgency
        {
            get
            {
                return this._InjuryFilingAgency;
            }
            set
            {
                this.OnInjuryFilingAgencyChanging(value);
                this._InjuryFilingAgency = value;
                this.OnInjuryFilingAgencyChanged();
                this.OnPropertyChanged("InjuryFilingAgency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.InjuryFilingAgency _InjuryFilingAgency;
        partial void OnInjuryFilingAgencyChanging(global::Microsoft.Dynamics.DataEntities.InjuryFilingAgency value);
        partial void OnInjuryFilingAgencyChanged();
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
