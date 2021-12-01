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
    /// There are no comments for FiscalEstablishmentIEPerStateSingle in the schema.
    /// </summary>
    public partial class FiscalEstablishmentIEPerStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalEstablishmentIEPerState>
    {
        /// <summary>
        /// Initialize a new FiscalEstablishmentIEPerStateSingle object.
        /// </summary>
        public FiscalEstablishmentIEPerStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalEstablishmentIEPerStateSingle object.
        /// </summary>
        public FiscalEstablishmentIEPerStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalEstablishmentIEPerStateSingle object.
        /// </summary>
        public FiscalEstablishmentIEPerStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalEstablishmentIEPerState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for FiscalEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalEstablishmentSingle FiscalEstablishment
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._FiscalEstablishment == null))
                {
                    this._FiscalEstablishment = new global::Microsoft.Dynamics.DataEntities.FiscalEstablishmentSingle(this.Context, GetPath("FiscalEstablishment"));
                }
                return this._FiscalEstablishment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalEstablishmentSingle _FiscalEstablishment;
    }
    /// <summary>
    /// There are no comments for FiscalEstablishmentIEPerState in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// FiscalEstablishmentId
    /// State
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "FiscalEstablishmentId", "State")]
    [global::Microsoft.OData.Client.EntitySet("FiscalEstablishmentIEPerStates")]
    public partial class FiscalEstablishmentIEPerState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalEstablishmentIEPerState object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="fiscalEstablishmentId">Initial value of FiscalEstablishmentId.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="fiscalEstablishment">Initial value of FiscalEstablishment.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalEstablishmentIEPerState CreateFiscalEstablishmentIEPerState(string dataAreaId, string fiscalEstablishmentId, string state, global::Microsoft.Dynamics.DataEntities.FiscalEstablishment fiscalEstablishment)
        {
            FiscalEstablishmentIEPerState fiscalEstablishmentIEPerState = new FiscalEstablishmentIEPerState();
            fiscalEstablishmentIEPerState.dataAreaId = dataAreaId;
            fiscalEstablishmentIEPerState.FiscalEstablishmentId = fiscalEstablishmentId;
            fiscalEstablishmentIEPerState.State = state;
            if ((fiscalEstablishment == null))
            {
                throw new global::System.ArgumentNullException("fiscalEstablishment");
            }
            fiscalEstablishmentIEPerState.FiscalEstablishment = fiscalEstablishment;
            return fiscalEstablishmentIEPerState;
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
        /// There are no comments for Property FiscalEstablishmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalEstablishmentId is required.")]
        public virtual string FiscalEstablishmentId
        {
            get
            {
                return this._FiscalEstablishmentId;
            }
            set
            {
                this.OnFiscalEstablishmentIdChanging(value);
                this._FiscalEstablishmentId = value;
                this.OnFiscalEstablishmentIdChanged();
                this.OnPropertyChanged("FiscalEstablishmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalEstablishmentId;
        partial void OnFiscalEstablishmentIdChanging(string value);
        partial void OnFiscalEstablishmentIdChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property IE in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string IE
        {
            get
            {
                return this._IE;
            }
            set
            {
                this.OnIEChanging(value);
                this._IE = value;
                this.OnIEChanged();
                this.OnPropertyChanged("IE");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IE;
        partial void OnIEChanging(string value);
        partial void OnIEChanged();
        /// <summary>
        /// There are no comments for Property FiscalEstablishment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FiscalEstablishment is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.FiscalEstablishment FiscalEstablishment
        {
            get
            {
                return this._FiscalEstablishment;
            }
            set
            {
                this.OnFiscalEstablishmentChanging(value);
                this._FiscalEstablishment = value;
                this.OnFiscalEstablishmentChanged();
                this.OnPropertyChanged("FiscalEstablishment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.FiscalEstablishment _FiscalEstablishment;
        partial void OnFiscalEstablishmentChanging(global::Microsoft.Dynamics.DataEntities.FiscalEstablishment value);
        partial void OnFiscalEstablishmentChanged();
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
