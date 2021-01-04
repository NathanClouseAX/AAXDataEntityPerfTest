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
        /// There are no comments for RegulatoryEstablishmentDetailSingle in the schema.
        /// </summary>
    public partial class RegulatoryEstablishmentDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishmentDetail>
    {
        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RegulatoryEstablishmentDetailSingle object.
        /// </summary>
        public RegulatoryEstablishmentDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RegulatoryEstablishmentDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntitySingle LegalEntity
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LegalEntity == null))
                {
                    this._LegalEntity = new global::Microsoft.Dynamics.DataEntities.LegalEntitySingle(this.Context, GetPath("LegalEntity"));
                }
                return this._LegalEntity;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LegalEntitySingle _LegalEntity;
        /// <summary>
        /// There are no comments for RegulatoryEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle RegulatoryEstablishment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RegulatoryEstablishment == null))
                {
                    this._RegulatoryEstablishment = new global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle(this.Context, GetPath("RegulatoryEstablishment"));
                }
                return this._RegulatoryEstablishment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishmentSingle _RegulatoryEstablishment;
        /// <summary>
        /// There are no comments for Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EmploymentSingle Employment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employment == null))
                {
                    this._Employment = new global::Microsoft.Dynamics.DataEntities.EmploymentSingle(this.Context, GetPath("Employment"));
                }
                return this._Employment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EmploymentSingle _Employment;
    }
        /// <summary>
        /// There are no comments for RegulatoryEstablishmentDetail in the schema.
        /// </summary>
    /// <KeyProperties>
    /// RegulatoryEstablishmentId
    /// LegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RegulatoryEstablishmentId", "LegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("RegulatoryEstablishmentDetails")]
    public partial class RegulatoryEstablishmentDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RegulatoryEstablishmentDetail object.
        /// </summary>
        /// <param name="regulatoryEstablishmentId">Initial value of RegulatoryEstablishmentId.</param>
        /// <param name="legalEntityId">Initial value of LegalEntityId.</param>
        /// <param name="legalEntity">Initial value of LegalEntity.</param>
        /// <param name="regulatoryEstablishment">Initial value of RegulatoryEstablishment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RegulatoryEstablishmentDetail CreateRegulatoryEstablishmentDetail(string regulatoryEstablishmentId, string legalEntityId, global::Microsoft.Dynamics.DataEntities.LegalEntity legalEntity, global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment regulatoryEstablishment)
        {
            RegulatoryEstablishmentDetail regulatoryEstablishmentDetail = new RegulatoryEstablishmentDetail();
            regulatoryEstablishmentDetail.RegulatoryEstablishmentId = regulatoryEstablishmentId;
            regulatoryEstablishmentDetail.LegalEntityId = legalEntityId;
            if ((legalEntity == null))
            {
                throw new global::System.ArgumentNullException("legalEntity");
            }
            regulatoryEstablishmentDetail.LegalEntity = legalEntity;
            if ((regulatoryEstablishment == null))
            {
                throw new global::System.ArgumentNullException("regulatoryEstablishment");
            }
            regulatoryEstablishmentDetail.RegulatoryEstablishment = regulatoryEstablishment;
            return regulatoryEstablishmentDetail;
        }
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RegulatoryEstablishmentId
        {
            get
            {
                return this._RegulatoryEstablishmentId;
            }
            set
            {
                this.OnRegulatoryEstablishmentIdChanging(value);
                this._RegulatoryEstablishmentId = value;
                this.OnRegulatoryEstablishmentIdChanged();
                this.OnPropertyChanged("RegulatoryEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RegulatoryEstablishmentId;
        partial void OnRegulatoryEstablishmentIdChanging(string value);
        partial void OnRegulatoryEstablishmentIdChanged();
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
        /// There are no comments for Property LegalEntity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LegalEntity LegalEntity
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
        private global::Microsoft.Dynamics.DataEntities.LegalEntity _LegalEntity;
        partial void OnLegalEntityChanging(global::Microsoft.Dynamics.DataEntities.LegalEntity value);
        partial void OnLegalEntityChanged();
        /// <summary>
        /// There are no comments for Property RegulatoryEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment RegulatoryEstablishment
        {
            get
            {
                return this._RegulatoryEstablishment;
            }
            set
            {
                this.OnRegulatoryEstablishmentChanging(value);
                this._RegulatoryEstablishment = value;
                this.OnRegulatoryEstablishmentChanged();
                this.OnPropertyChanged("RegulatoryEstablishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment _RegulatoryEstablishment;
        partial void OnRegulatoryEstablishmentChanging(global::Microsoft.Dynamics.DataEntities.RegulatoryEstablishment value);
        partial void OnRegulatoryEstablishmentChanged();
        /// <summary>
        /// There are no comments for Property Employment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Employment Employment
        {
            get
            {
                return this._Employment;
            }
            set
            {
                this.OnEmploymentChanging(value);
                this._Employment = value;
                this.OnEmploymentChanged();
                this.OnPropertyChanged("Employment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Employment _Employment;
        partial void OnEmploymentChanging(global::Microsoft.Dynamics.DataEntities.Employment value);
        partial void OnEmploymentChanged();
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
