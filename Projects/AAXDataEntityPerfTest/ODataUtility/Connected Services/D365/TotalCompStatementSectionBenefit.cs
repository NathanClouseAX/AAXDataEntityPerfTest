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
        /// There are no comments for TotalCompStatementSectionBenefitSingle in the schema.
        /// </summary>
    public partial class TotalCompStatementSectionBenefitSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TotalCompStatementSectionBenefit>
    {
        /// <summary>
        /// Initialize a new TotalCompStatementSectionBenefitSingle object.
        /// </summary>
        public TotalCompStatementSectionBenefitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TotalCompStatementSectionBenefitSingle object.
        /// </summary>
        public TotalCompStatementSectionBenefitSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TotalCompStatementSectionBenefitSingle object.
        /// </summary>
        public TotalCompStatementSectionBenefitSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TotalCompStatementSectionBenefit> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for HcmBenefitEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.BenefitSingle HcmBenefitEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmBenefitEntity == null))
                {
                    this._HcmBenefitEntity = new global::Microsoft.Dynamics.DataEntities.BenefitSingle(this.Context, GetPath("HcmBenefitEntity"));
                }
                return this._HcmBenefitEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.BenefitSingle _HcmBenefitEntity;
        /// <summary>
        /// There are no comments for HcmTotalCompStatementSectionHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle HcmTotalCompStatementSectionHeaderEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._HcmTotalCompStatementSectionHeaderEntity == null))
                {
                    this._HcmTotalCompStatementSectionHeaderEntity = new global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle(this.Context, GetPath("HcmTotalCompStatementSectionHeaderEntity"));
                }
                return this._HcmTotalCompStatementSectionHeaderEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeaderSingle _HcmTotalCompStatementSectionHeaderEntity;
    }
        /// <summary>
        /// There are no comments for TotalCompStatementSectionBenefit in the schema.
        /// </summary>
    /// <KeyProperties>
    /// StatementSectionId
    /// BenefitId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("StatementSectionId", "BenefitId")]
    [global::Microsoft.OData.Client.EntitySet("TotalCompStatementSectionBenefits")]
    public partial class TotalCompStatementSectionBenefit : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TotalCompStatementSectionBenefit object.
        /// </summary>
        /// <param name="statementSectionId">Initial value of StatementSectionId.</param>
        /// <param name="benefitId">Initial value of BenefitId.</param>
        /// <param name="hcmBenefitEntity">Initial value of HcmBenefitEntity.</param>
        /// <param name="hcmTotalCompStatementSectionHeaderEntity">Initial value of HcmTotalCompStatementSectionHeaderEntity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TotalCompStatementSectionBenefit CreateTotalCompStatementSectionBenefit(string statementSectionId, string benefitId, global::Microsoft.Dynamics.DataEntities.Benefit hcmBenefitEntity, global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader hcmTotalCompStatementSectionHeaderEntity)
        {
            TotalCompStatementSectionBenefit totalCompStatementSectionBenefit = new TotalCompStatementSectionBenefit();
            totalCompStatementSectionBenefit.StatementSectionId = statementSectionId;
            totalCompStatementSectionBenefit.BenefitId = benefitId;
            if ((hcmBenefitEntity == null))
            {
                throw new global::System.ArgumentNullException("hcmBenefitEntity");
            }
            totalCompStatementSectionBenefit.HcmBenefitEntity = hcmBenefitEntity;
            if ((hcmTotalCompStatementSectionHeaderEntity == null))
            {
                throw new global::System.ArgumentNullException("hcmTotalCompStatementSectionHeaderEntity");
            }
            totalCompStatementSectionBenefit.HcmTotalCompStatementSectionHeaderEntity = hcmTotalCompStatementSectionHeaderEntity;
            return totalCompStatementSectionBenefit;
        }
        /// <summary>
        /// There are no comments for Property StatementSectionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string StatementSectionId
        {
            get
            {
                return this._StatementSectionId;
            }
            set
            {
                this.OnStatementSectionIdChanging(value);
                this._StatementSectionId = value;
                this.OnStatementSectionIdChanged();
                this.OnPropertyChanged("StatementSectionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatementSectionId;
        partial void OnStatementSectionIdChanging(string value);
        partial void OnStatementSectionIdChanged();
        /// <summary>
        /// There are no comments for Property BenefitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BenefitId
        {
            get
            {
                return this._BenefitId;
            }
            set
            {
                this.OnBenefitIdChanging(value);
                this._BenefitId = value;
                this.OnBenefitIdChanged();
                this.OnPropertyChanged("BenefitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BenefitId;
        partial void OnBenefitIdChanging(string value);
        partial void OnBenefitIdChanged();
        /// <summary>
        /// There are no comments for Property HcmBenefitEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Benefit HcmBenefitEntity
        {
            get
            {
                return this._HcmBenefitEntity;
            }
            set
            {
                this.OnHcmBenefitEntityChanging(value);
                this._HcmBenefitEntity = value;
                this.OnHcmBenefitEntityChanged();
                this.OnPropertyChanged("HcmBenefitEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Benefit _HcmBenefitEntity;
        partial void OnHcmBenefitEntityChanging(global::Microsoft.Dynamics.DataEntities.Benefit value);
        partial void OnHcmBenefitEntityChanged();
        /// <summary>
        /// There are no comments for Property HcmTotalCompStatementSectionHeaderEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader HcmTotalCompStatementSectionHeaderEntity
        {
            get
            {
                return this._HcmTotalCompStatementSectionHeaderEntity;
            }
            set
            {
                this.OnHcmTotalCompStatementSectionHeaderEntityChanging(value);
                this._HcmTotalCompStatementSectionHeaderEntity = value;
                this.OnHcmTotalCompStatementSectionHeaderEntityChanged();
                this.OnPropertyChanged("HcmTotalCompStatementSectionHeaderEntity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader _HcmTotalCompStatementSectionHeaderEntity;
        partial void OnHcmTotalCompStatementSectionHeaderEntityChanging(global::Microsoft.Dynamics.DataEntities.TotalCompStatementSectionHeader value);
        partial void OnHcmTotalCompStatementSectionHeaderEntityChanged();
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
