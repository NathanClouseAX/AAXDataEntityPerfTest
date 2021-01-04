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
        /// There are no comments for PositionHierarchySingle in the schema.
        /// </summary>
    public partial class PositionHierarchySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PositionHierarchy>
    {
        /// <summary>
        /// Initialize a new PositionHierarchySingle object.
        /// </summary>
        public PositionHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PositionHierarchySingle object.
        /// </summary>
        public PositionHierarchySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PositionHierarchySingle object.
        /// </summary>
        public PositionHierarchySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PositionHierarchy> query)
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
        /// There are no comments for PositionHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionHierarchyTypeSingle PositionHierarchyType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PositionHierarchyType == null))
                {
                    this._PositionHierarchyType = new global::Microsoft.Dynamics.DataEntities.PositionHierarchyTypeSingle(this.Context, GetPath("PositionHierarchyType"));
                }
                return this._PositionHierarchyType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionHierarchyTypeSingle _PositionHierarchyType;
        /// <summary>
        /// There are no comments for ParentPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2Single ParentPosition
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ParentPosition == null))
                {
                    this._ParentPosition = new global::Microsoft.Dynamics.DataEntities.PositionV2Single(this.Context, GetPath("ParentPosition"));
                }
                return this._ParentPosition;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2Single _ParentPosition;
    }
        /// <summary>
        /// There are no comments for PositionHierarchy in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PositionId
    /// HierarchyTypeName
    /// ValidFrom
    /// ValidTo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionId", "HierarchyTypeName", "ValidFrom", "ValidTo")]
    [global::Microsoft.OData.Client.EntitySet("PositionHierarchies")]
    public partial class PositionHierarchy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PositionHierarchy object.
        /// </summary>
        /// <param name="positionId">Initial value of PositionId.</param>
        /// <param name="hierarchyTypeName">Initial value of HierarchyTypeName.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="position">Initial value of Position.</param>
        /// <param name="positionHierarchyType">Initial value of PositionHierarchyType.</param>
        /// <param name="parentPosition">Initial value of ParentPosition.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PositionHierarchy CreatePositionHierarchy(string positionId, 
                    string hierarchyTypeName, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 position, 
                    global::Microsoft.Dynamics.DataEntities.PositionHierarchyType positionHierarchyType, 
                    global::Microsoft.Dynamics.DataEntities.PositionV2 parentPosition)
        {
            PositionHierarchy positionHierarchy = new PositionHierarchy();
            positionHierarchy.PositionId = positionId;
            positionHierarchy.HierarchyTypeName = hierarchyTypeName;
            positionHierarchy.ValidFrom = validFrom;
            positionHierarchy.ValidTo = validTo;
            if ((position == null))
            {
                throw new global::System.ArgumentNullException("position");
            }
            positionHierarchy.Position = position;
            if ((positionHierarchyType == null))
            {
                throw new global::System.ArgumentNullException("positionHierarchyType");
            }
            positionHierarchy.PositionHierarchyType = positionHierarchyType;
            if ((parentPosition == null))
            {
                throw new global::System.ArgumentNullException("parentPosition");
            }
            positionHierarchy.ParentPosition = parentPosition;
            return positionHierarchy;
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
        /// There are no comments for Property HierarchyTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string HierarchyTypeName
        {
            get
            {
                return this._HierarchyTypeName;
            }
            set
            {
                this.OnHierarchyTypeNameChanging(value);
                this._HierarchyTypeName = value;
                this.OnHierarchyTypeNameChanged();
                this.OnPropertyChanged("HierarchyTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _HierarchyTypeName;
        partial void OnHierarchyTypeNameChanging(string value);
        partial void OnHierarchyTypeNameChanged();
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
        /// There are no comments for Property ParentPositionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ParentPositionId
        {
            get
            {
                return this._ParentPositionId;
            }
            set
            {
                this.OnParentPositionIdChanging(value);
                this._ParentPositionId = value;
                this.OnParentPositionIdChanged();
                this.OnPropertyChanged("ParentPositionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentPositionId;
        partial void OnParentPositionIdChanging(string value);
        partial void OnParentPositionIdChanged();
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
        /// There are no comments for Property PositionHierarchyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionHierarchyType PositionHierarchyType
        {
            get
            {
                return this._PositionHierarchyType;
            }
            set
            {
                this.OnPositionHierarchyTypeChanging(value);
                this._PositionHierarchyType = value;
                this.OnPositionHierarchyTypeChanged();
                this.OnPropertyChanged("PositionHierarchyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionHierarchyType _PositionHierarchyType;
        partial void OnPositionHierarchyTypeChanging(global::Microsoft.Dynamics.DataEntities.PositionHierarchyType value);
        partial void OnPositionHierarchyTypeChanged();
        /// <summary>
        /// There are no comments for Property ParentPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PositionV2 ParentPosition
        {
            get
            {
                return this._ParentPosition;
            }
            set
            {
                this.OnParentPositionChanging(value);
                this._ParentPosition = value;
                this.OnParentPositionChanged();
                this.OnPropertyChanged("ParentPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PositionV2 _ParentPosition;
        partial void OnParentPositionChanging(global::Microsoft.Dynamics.DataEntities.PositionV2 value);
        partial void OnParentPositionChanged();
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
