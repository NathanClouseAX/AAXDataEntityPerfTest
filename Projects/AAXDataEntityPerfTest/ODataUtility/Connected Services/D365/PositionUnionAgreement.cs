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
        /// There are no comments for PositionUnionAgreementSingle in the schema.
        /// </summary>
    public partial class PositionUnionAgreementSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionUnionAgreement>
    {
        /// <summary>
        /// Initialize a new PositionUnionAgreementSingle object.
        /// </summary>
        public PositionUnionAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionUnionAgreementSingle object.
        /// </summary>
        public PositionUnionAgreementSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionUnionAgreementSingle object.
        /// </summary>
        public PositionUnionAgreementSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionUnionAgreement> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single Position
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Position == null))
                {
                    this._Position = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("Position"));
                }
                return this._Position;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _Position;
        /// <summary>
        /// There are no comments for LaborUnionAgreement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LaborUnionAgreementSingle LaborUnionAgreement
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._LaborUnionAgreement == null))
                {
                    this._LaborUnionAgreement = new global::Microsoft.Dynamics.DataEntities.LaborUnionAgreementSingle(this.Context, GetPath("LaborUnionAgreement"));
                }
                return this._LaborUnionAgreement;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LaborUnionAgreementSingle _LaborUnionAgreement;
    }
        /// <summary>
        /// There are no comments for PositionUnionAgreement in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PositionId
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionId", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("PositionUnionAgreements")]
    public partial class PositionUnionAgreement : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionUnionAgreement object.
        /// </summary>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="laborUnionAgreement">Initial value of LaborUnionAgreement.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionUnionAgreement CreatePositionUnionAgreement(string positionId, global::System.DateTimeOffset validFrom, global::System.DateTimeOffset validTo, global::Microsoft.Dynamics.DataEntities.PositionV2 position, global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement laborUnionAgreement)
        {
            PositionUnionAgreement positionUnionAgreement = new PositionUnionAgreement();
            positionUnionAgreement.PositionId = positionId;
            positionUnionAgreement.ValidFrom = validFrom;
            positionUnionAgreement.ValidTo = validTo;
            if ((position == null))
            {
                throw new global::System.ArgumentNullException("position");
            }
            positionUnionAgreement.Position = position;
            if ((laborUnionAgreement == null))
            {
                throw new global::System.ArgumentNullException("laborUnionAgreement");
            }
            positionUnionAgreement.LaborUnionAgreement = laborUnionAgreement;
            return positionUnionAgreement;
        }
        /// <summary>
        /// There are no comments for Property PositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionId
        {
            get
            {
                return this._PositionId;
            }
            set
            {
                this.OnPositionIdChanging(value);
                this._PositionId = value;
                this.OnPositionIdChanged();
                this.OnPropertyChanged("PositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionId;
        partial void OnPositionIdChanging(string value);
        partial void OnPositionIdChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
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
        /// There are no comments for Property LaborUnionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LaborUnionId
        {
            get
            {
                return this._LaborUnionId;
            }
            set
            {
                this.OnLaborUnionIdChanging(value);
                this._LaborUnionId = value;
                this.OnLaborUnionIdChanged();
                this.OnPropertyChanged("LaborUnionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LaborUnionId;
        partial void OnLaborUnionIdChanging(string value);
        partial void OnLaborUnionIdChanged();
        /// <summary>
        /// There are no comments for Property UnionAgreementName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UnionAgreementName
        {
            get
            {
                return this._UnionAgreementName;
            }
            set
            {
                this.OnUnionAgreementNameChanging(value);
                this._UnionAgreementName = value;
                this.OnUnionAgreementNameChanged();
                this.OnPropertyChanged("UnionAgreementName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnionAgreementName;
        partial void OnUnionAgreementNameChanging(string value);
        partial void OnUnionAgreementNameChanged();
        /// <summary>
        /// There are no comments for Property Position in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 Position
        {
            get
            {
                return this._Position;
            }
            set
            {
                this.OnPositionChanging(value);
                this._Position = value;
                this.OnPositionChanged();
                this.OnPropertyChanged("Position");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _Position;
        partial void OnPositionChanging(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionChanged();
        /// <summary>
        /// There are no comments for Property LaborUnionAgreement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement LaborUnionAgreement
        {
            get
            {
                return this._LaborUnionAgreement;
            }
            set
            {
                this.OnLaborUnionAgreementChanging(value);
                this._LaborUnionAgreement = value;
                this.OnLaborUnionAgreementChanged();
                this.OnPropertyChanged("LaborUnionAgreement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement _LaborUnionAgreement;
        partial void OnLaborUnionAgreementChanging(global::Microsoft.Dynamics.DataEntities.LaborUnionAgreement value);
        partial void OnLaborUnionAgreementChanged();
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
