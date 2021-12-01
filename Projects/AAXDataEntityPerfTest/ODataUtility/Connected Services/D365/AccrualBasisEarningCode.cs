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
    /// There are no comments for AccrualBasisEarningCodeSingle in the schema.
    /// </summary>
    public partial class AccrualBasisEarningCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualBasisEarningCode>
    {
        /// <summary>
        /// Initialize a new AccrualBasisEarningCodeSingle object.
        /// </summary>
        public AccrualBasisEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AccrualBasisEarningCodeSingle object.
        /// </summary>
        public AccrualBasisEarningCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AccrualBasisEarningCodeSingle object.
        /// </summary>
        public AccrualBasisEarningCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AccrualBasisEarningCode> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EarningCodeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningCodeGroupSingle EarningCodeGroup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EarningCodeGroup == null))
                {
                    this._EarningCodeGroup = new global::Microsoft.Dynamics.DataEntities.EarningCodeGroupSingle(this.Context, GetPath("EarningCodeGroup"));
                }
                return this._EarningCodeGroup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningCodeGroupSingle _EarningCodeGroup;
        /// <summary>
        /// There are no comments for AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle AccrualPlan
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AccrualPlan == null))
                {
                    this._AccrualPlan = new global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle(this.Context, GetPath("AccrualPlan"));
                }
                return this._AccrualPlan;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlanSingle _AccrualPlan;
    }
    /// <summary>
    /// There are no comments for AccrualBasisEarningCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccrualId
    /// EarningCodeId
    /// EarningCodeGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccrualId", "EarningCodeId", "EarningCodeGroupId")]
    [global::Microsoft.OData.Client.EntitySet("AccrualBasisEarningCodes")]
    public partial class AccrualBasisEarningCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AccrualBasisEarningCode object.
        /// </summary>
        /// <param name="accrualId">Initial value of AccrualId.</param>
        /// <param name="earningCodeId">Initial value of EarningCodeId.</param>
        /// <param name="earningCodeGroupId">Initial value of EarningCodeGroupId.</param>
        /// <param name="accrualRate">Initial value of AccrualRate.</param>
        /// <param name="earningCodeGroup">Initial value of EarningCodeGroup.</param>
        /// <param name="accrualPlan">Initial value of AccrualPlan.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AccrualBasisEarningCode CreateAccrualBasisEarningCode(string accrualId, 
                    string earningCodeId, 
                    string earningCodeGroupId, 
                    decimal accrualRate, 
                    global::Microsoft.Dynamics.DataEntities.EarningCodeGroup earningCodeGroup, 
                    global::Microsoft.Dynamics.DataEntities.AccrualPlan accrualPlan)
        {
            AccrualBasisEarningCode accrualBasisEarningCode = new AccrualBasisEarningCode();
            accrualBasisEarningCode.AccrualId = accrualId;
            accrualBasisEarningCode.EarningCodeId = earningCodeId;
            accrualBasisEarningCode.EarningCodeGroupId = earningCodeGroupId;
            accrualBasisEarningCode.AccrualRate = accrualRate;
            if ((earningCodeGroup == null))
            {
                throw new global::System.ArgumentNullException("earningCodeGroup");
            }
            accrualBasisEarningCode.EarningCodeGroup = earningCodeGroup;
            if ((accrualPlan == null))
            {
                throw new global::System.ArgumentNullException("accrualPlan");
            }
            accrualBasisEarningCode.AccrualPlan = accrualPlan;
            return accrualBasisEarningCode;
        }
        /// <summary>
        /// There are no comments for Property AccrualId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualId is required.")]
        public virtual string AccrualId
        {
            get
            {
                return this._AccrualId;
            }
            set
            {
                this.OnAccrualIdChanging(value);
                this._AccrualId = value;
                this.OnAccrualIdChanged();
                this.OnPropertyChanged("AccrualId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccrualId;
        partial void OnAccrualIdChanging(string value);
        partial void OnAccrualIdChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EarningCodeId is required.")]
        public virtual string EarningCodeId
        {
            get
            {
                return this._EarningCodeId;
            }
            set
            {
                this.OnEarningCodeIdChanging(value);
                this._EarningCodeId = value;
                this.OnEarningCodeIdChanged();
                this.OnPropertyChanged("EarningCodeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeId;
        partial void OnEarningCodeIdChanging(string value);
        partial void OnEarningCodeIdChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EarningCodeGroupId is required.")]
        public virtual string EarningCodeGroupId
        {
            get
            {
                return this._EarningCodeGroupId;
            }
            set
            {
                this.OnEarningCodeGroupIdChanging(value);
                this._EarningCodeGroupId = value;
                this.OnEarningCodeGroupIdChanged();
                this.OnPropertyChanged("EarningCodeGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EarningCodeGroupId;
        partial void OnEarningCodeGroupIdChanging(string value);
        partial void OnEarningCodeGroupIdChanged();
        /// <summary>
        /// There are no comments for Property AccrualType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualType> AccrualType
        {
            get
            {
                return this._AccrualType;
            }
            set
            {
                this.OnAccrualTypeChanging(value);
                this._AccrualType = value;
                this.OnAccrualTypeChanged();
                this.OnPropertyChanged("AccrualType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualType> _AccrualType;
        partial void OnAccrualTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PayrollAccrualType> value);
        partial void OnAccrualTypeChanged();
        /// <summary>
        /// There are no comments for Property AccrualRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualRate is required.")]
        public virtual decimal AccrualRate
        {
            get
            {
                return this._AccrualRate;
            }
            set
            {
                this.OnAccrualRateChanging(value);
                this._AccrualRate = value;
                this.OnAccrualRateChanged();
                this.OnPropertyChanged("AccrualRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _AccrualRate;
        partial void OnAccrualRateChanging(decimal value);
        partial void OnAccrualRateChanged();
        /// <summary>
        /// There are no comments for Property EarningCodeGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EarningCodeGroup is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.EarningCodeGroup EarningCodeGroup
        {
            get
            {
                return this._EarningCodeGroup;
            }
            set
            {
                this.OnEarningCodeGroupChanging(value);
                this._EarningCodeGroup = value;
                this.OnEarningCodeGroupChanged();
                this.OnPropertyChanged("EarningCodeGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EarningCodeGroup _EarningCodeGroup;
        partial void OnEarningCodeGroupChanging(global::Microsoft.Dynamics.DataEntities.EarningCodeGroup value);
        partial void OnEarningCodeGroupChanged();
        /// <summary>
        /// There are no comments for Property AccrualPlan in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccrualPlan is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.AccrualPlan AccrualPlan
        {
            get
            {
                return this._AccrualPlan;
            }
            set
            {
                this.OnAccrualPlanChanging(value);
                this._AccrualPlan = value;
                this.OnAccrualPlanChanged();
                this.OnPropertyChanged("AccrualPlan");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AccrualPlan _AccrualPlan;
        partial void OnAccrualPlanChanging(global::Microsoft.Dynamics.DataEntities.AccrualPlan value);
        partial void OnAccrualPlanChanged();
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
