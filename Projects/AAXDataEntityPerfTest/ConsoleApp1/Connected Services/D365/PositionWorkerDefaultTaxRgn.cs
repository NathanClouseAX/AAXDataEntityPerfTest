﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 10/4/2020 2:55:10 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for PositionWorkerDefaultTaxRgnSingle in the schema.
    /// </summary>
    public partial class PositionWorkerDefaultTaxRgnSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionWorkerDefaultTaxRgn>
    {
        /// <summary>
        /// Initialize a new PositionWorkerDefaultTaxRgnSingle object.
        /// </summary>
        public PositionWorkerDefaultTaxRgnSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionWorkerDefaultTaxRgnSingle object.
        /// </summary>
        public PositionWorkerDefaultTaxRgnSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionWorkerDefaultTaxRgnSingle object.
        /// </summary>
        public PositionWorkerDefaultTaxRgnSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionWorkerDefaultTaxRgn> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single PositionV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionV2 == null))
                {
                    this._PositionV2 = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("PositionV2"));
                }
                return this._PositionV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _PositionV2;
    }
    /// <summary>
    /// There are no comments for PositionWorkerDefaultTaxRgn in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonnelNumber
    /// PositionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PersonnelNumber", "PositionId")]
    [global::Microsoft.OData.Client.EntitySet("PositionWorkerDefaultTaxRgns")]
    public partial class PositionWorkerDefaultTaxRgn : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionWorkerDefaultTaxRgn object.
        /// </summary>
        /// <param name="personnelNumber">Initial value of PersonnelNumber.</param>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="positionV2">Initial value of PositionV2.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionWorkerDefaultTaxRgn CreatePositionWorkerDefaultTaxRgn(string personnelNumber, string positionId, global::Microsoft.Dynamics.DataEntities.PositionV2 positionV2)
        {
            PositionWorkerDefaultTaxRgn positionWorkerDefaultTaxRgn = new PositionWorkerDefaultTaxRgn();
            positionWorkerDefaultTaxRgn.PersonnelNumber = personnelNumber;
            positionWorkerDefaultTaxRgn.PositionId = positionId;
            if ((positionV2 == null))
            {
                throw new global::System.ArgumentNullException("positionV2");
            }
            positionWorkerDefaultTaxRgn.PositionV2 = positionV2;
            return positionWorkerDefaultTaxRgn;
        }
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
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
        /// There are no comments for Property LocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string LocationId
        {
            get
            {
                return this._LocationId;
            }
            set
            {
                this.OnLocationIdChanging(value);
                this._LocationId = value;
                this.OnLocationIdChanged();
                this.OnPropertyChanged("LocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LocationId;
        partial void OnLocationIdChanging(string value);
        partial void OnLocationIdChanged();
        /// <summary>
        /// There are no comments for Property PositionV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 PositionV2
        {
            get
            {
                return this._PositionV2;
            }
            set
            {
                this.OnPositionV2Changing(value);
                this._PositionV2 = value;
                this.OnPositionV2Changed();
                this.OnPropertyChanged("PositionV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _PositionV2;
        partial void OnPositionV2Changing(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnPositionV2Changed();
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
