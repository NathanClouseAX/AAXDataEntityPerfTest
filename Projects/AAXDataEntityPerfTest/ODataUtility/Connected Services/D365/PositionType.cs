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
        /// There are no comments for PositionTypeSingle in the schema.
        /// </summary>
    public partial class PositionTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionType>
    {
        /// <summary>
        /// Initialize a new PositionTypeSingle object.
        /// </summary>
        public PositionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionTypeSingle object.
        /// </summary>
        public PositionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionTypeSingle object.
        /// </summary>
        public PositionTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Positions == null))
                {
                    this._Positions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Position>(GetPath("Positions"));
                }
                return this._Positions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Position> _Positions;
    }
        /// <summary>
        /// There are no comments for PositionType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PositionTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionTypeId")]
    [global::Microsoft.OData.Client.EntitySet("PositionTypes")]
    public partial class PositionType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionType object.
        /// </summary>
        /// <param name="positionTypeId">Initial value of PositionTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionType CreatePositionType(string positionTypeId)
        {
            PositionType positionType = new PositionType();
            positionType.PositionTypeId = positionTypeId;
            return positionType;
        }
        /// <summary>
        /// There are no comments for Property PositionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PositionTypeId
        {
            get
            {
                return this._PositionTypeId;
            }
            set
            {
                this.OnPositionTypeIdChanging(value);
                this._PositionTypeId = value;
                this.OnPositionTypeIdChanged();
                this.OnPropertyChanged("PositionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PositionTypeId;
        partial void OnPositionTypeIdChanging(string value);
        partial void OnPositionTypeIdChanged();
        /// <summary>
        /// There are no comments for Property Classification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentStatus> Classification
        {
            get
            {
                return this._Classification;
            }
            set
            {
                this.OnClassificationChanging(value);
                this._Classification = value;
                this.OnClassificationChanged();
                this.OnPropertyChanged("Classification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentStatus> _Classification;
        partial void OnClassificationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmEmploymentStatus> value);
        partial void OnClassificationChanged();
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
        /// There are no comments for Property Positions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> Positions
        {
            get
            {
                return this._Positions;
            }
            set
            {
                this.OnPositionsChanging(value);
                this._Positions = value;
                this.OnPositionsChanged();
                this.OnPropertyChanged("Positions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> _Positions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPositionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Position> value);
        partial void OnPositionsChanged();
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
