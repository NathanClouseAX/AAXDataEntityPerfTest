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
    /// There are no comments for LeaseIndexRevaluationSingle in the schema.
    /// </summary>
    public partial class LeaseIndexRevaluationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseIndexRevaluation>
    {
        /// <summary>
        /// Initialize a new LeaseIndexRevaluationSingle object.
        /// </summary>
        public LeaseIndexRevaluationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LeaseIndexRevaluationSingle object.
        /// </summary>
        public LeaseIndexRevaluationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LeaseIndexRevaluationSingle object.
        /// </summary>
        public LeaseIndexRevaluationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LeaseIndexRevaluation> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LeaseIndexRevaluation in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProcessId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProcessId")]
    [global::Microsoft.OData.Client.EntitySet("LeaseIndexRevaluations")]
    public partial class LeaseIndexRevaluation : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LeaseIndexRevaluation object.
        /// </summary>
        /// <param name="processId">Initial value of ProcessId.</param>
        /// <param name="variablePayment">Initial value of VariablePayment.</param>
        /// <param name="leaseAdjusted">Initial value of LeaseAdjusted.</param>
        /// <param name="liabilityAdjusted">Initial value of LiabilityAdjusted.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LeaseIndexRevaluation CreateLeaseIndexRevaluation(global::System.Guid processId, decimal variablePayment, int leaseAdjusted, decimal liabilityAdjusted)
        {
            LeaseIndexRevaluation leaseIndexRevaluation = new LeaseIndexRevaluation();
            leaseIndexRevaluation.ProcessId = processId;
            leaseIndexRevaluation.VariablePayment = variablePayment;
            leaseIndexRevaluation.LeaseAdjusted = leaseAdjusted;
            leaseIndexRevaluation.LiabilityAdjusted = liabilityAdjusted;
            return leaseIndexRevaluation;
        }
        /// <summary>
        /// There are no comments for Property ProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcessId is required.")]
        public virtual global::System.Guid ProcessId
        {
            get
            {
                return this._ProcessId;
            }
            set
            {
                this.OnProcessIdChanging(value);
                this._ProcessId = value;
                this.OnProcessIdChanged();
                this.OnPropertyChanged("ProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Guid _ProcessId;
        partial void OnProcessIdChanging(global::System.Guid value);
        partial void OnProcessIdChanged();
        /// <summary>
        /// There are no comments for Property VariablePayment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "VariablePayment is required.")]
        public virtual decimal VariablePayment
        {
            get
            {
                return this._VariablePayment;
            }
            set
            {
                this.OnVariablePaymentChanging(value);
                this._VariablePayment = value;
                this.OnVariablePaymentChanged();
                this.OnPropertyChanged("VariablePayment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _VariablePayment;
        partial void OnVariablePaymentChanging(decimal value);
        partial void OnVariablePaymentChanged();
        /// <summary>
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string LegalEntity
        {
            get
            {
                return this._LegalEntity;
            }
            set
            {
                this.OnLegalEntityChanging(value);
                this._LegalEntity = value;
                this.OnLegalEntityChanged();
                this.OnPropertyChanged("LegalEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalEntity;
        partial void OnLegalEntityChanging(string value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property LeaseAdjusted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LeaseAdjusted is required.")]
        public virtual int LeaseAdjusted
        {
            get
            {
                return this._LeaseAdjusted;
            }
            set
            {
                this.OnLeaseAdjustedChanging(value);
                this._LeaseAdjusted = value;
                this.OnLeaseAdjustedChanged();
                this.OnPropertyChanged("LeaseAdjusted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LeaseAdjusted;
        partial void OnLeaseAdjustedChanging(int value);
        partial void OnLeaseAdjustedChanged();
        /// <summary>
        /// There are no comments for Property LiabilityAdjusted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LiabilityAdjusted is required.")]
        public virtual decimal LiabilityAdjusted
        {
            get
            {
                return this._LiabilityAdjusted;
            }
            set
            {
                this.OnLiabilityAdjustedChanging(value);
                this._LiabilityAdjusted = value;
                this.OnLiabilityAdjustedChanged();
                this.OnPropertyChanged("LiabilityAdjusted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _LiabilityAdjusted;
        partial void OnLiabilityAdjustedChanging(decimal value);
        partial void OnLiabilityAdjustedChanged();
        /// <summary>
        /// There are no comments for Property RevalueProcessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string RevalueProcessId
        {
            get
            {
                return this._RevalueProcessId;
            }
            set
            {
                this.OnRevalueProcessIdChanging(value);
                this._RevalueProcessId = value;
                this.OnRevalueProcessIdChanged();
                this.OnPropertyChanged("RevalueProcessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RevalueProcessId;
        partial void OnRevalueProcessIdChanging(string value);
        partial void OnRevalueProcessIdChanged();
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
