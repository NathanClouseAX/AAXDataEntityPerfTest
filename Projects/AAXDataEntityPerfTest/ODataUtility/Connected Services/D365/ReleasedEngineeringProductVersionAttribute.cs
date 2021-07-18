﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ReleasedEngineeringProductVersionAttributeSingle in the schema.
        /// </summary>
    public partial class ReleasedEngineeringProductVersionAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedEngineeringProductVersionAttribute>
    {
        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedEngineeringProductVersionAttribute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle ProductAttribute
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductAttribute == null))
                {
                    this._ProductAttribute = new global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle(this.Context, GetPath("ProductAttribute"));
                }
                return this._ProductAttribute;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductAttributeSingle _ProductAttribute;
    }
        /// <summary>
        /// There are no comments for ReleasedEngineeringProductVersionAttribute in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringProductNumber
    /// EngineeringProductVersionId
    /// EngineeringProductAttributeName
    /// EngineeringProductAttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringProductNumber", "EngineeringProductVersionId", "EngineeringProductAttributeName", "EngineeringProductAttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedEngineeringProductVersionAttributes")]
    public partial class ReleasedEngineeringProductVersionAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedEngineeringProductVersionAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringProductNumber">Initial value of EngineeringProductNumber.</param>
        /// <param name="engineeringProductVersionId">Initial value of EngineeringProductVersionId.</param>
        /// <param name="engineeringProductAttributeName">Initial value of EngineeringProductAttributeName.</param>
        /// <param name="engineeringProductAttributeTypeName">Initial value of EngineeringProductAttributeTypeName.</param>
        /// <param name="maximumDecimalTolerance">Initial value of MaximumDecimalTolerance.</param>
        /// <param name="decimalToleranceIncrement">Initial value of DecimalToleranceIncrement.</param>
        /// <param name="integerToleranceIncrement">Initial value of IntegerToleranceIncrement.</param>
        /// <param name="maximumIntegerTolerance">Initial value of MaximumIntegerTolerance.</param>
        /// <param name="minimumIntegerTolerance">Initial value of MinimumIntegerTolerance.</param>
        /// <param name="minimumDecimalTolerance">Initial value of MinimumDecimalTolerance.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedEngineeringProductVersionAttribute CreateReleasedEngineeringProductVersionAttribute(string dataAreaId, 
                    string engineeringProductNumber, 
                    string engineeringProductVersionId, 
                    string engineeringProductAttributeName, 
                    string engineeringProductAttributeTypeName, 
                    decimal maximumDecimalTolerance, 
                    decimal decimalToleranceIncrement, 
                    int integerToleranceIncrement, 
                    int maximumIntegerTolerance, 
                    int minimumIntegerTolerance, 
                    decimal minimumDecimalTolerance)
        {
            ReleasedEngineeringProductVersionAttribute releasedEngineeringProductVersionAttribute = new ReleasedEngineeringProductVersionAttribute();
            releasedEngineeringProductVersionAttribute.dataAreaId = dataAreaId;
            releasedEngineeringProductVersionAttribute.EngineeringProductNumber = engineeringProductNumber;
            releasedEngineeringProductVersionAttribute.EngineeringProductVersionId = engineeringProductVersionId;
            releasedEngineeringProductVersionAttribute.EngineeringProductAttributeName = engineeringProductAttributeName;
            releasedEngineeringProductVersionAttribute.EngineeringProductAttributeTypeName = engineeringProductAttributeTypeName;
            releasedEngineeringProductVersionAttribute.MaximumDecimalTolerance = maximumDecimalTolerance;
            releasedEngineeringProductVersionAttribute.DecimalToleranceIncrement = decimalToleranceIncrement;
            releasedEngineeringProductVersionAttribute.IntegerToleranceIncrement = integerToleranceIncrement;
            releasedEngineeringProductVersionAttribute.MaximumIntegerTolerance = maximumIntegerTolerance;
            releasedEngineeringProductVersionAttribute.MinimumIntegerTolerance = minimumIntegerTolerance;
            releasedEngineeringProductVersionAttribute.MinimumDecimalTolerance = minimumDecimalTolerance;
            return releasedEngineeringProductVersionAttribute;
        }
        /// <summary>
        /// There are no comments for Property dataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property EngineeringProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringProductNumber
        {
            get
            {
                return this._EngineeringProductNumber;
            }
            set
            {
                this.OnEngineeringProductNumberChanging(value);
                this._EngineeringProductNumber = value;
                this.OnEngineeringProductNumberChanged();
                this.OnPropertyChanged("EngineeringProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringProductNumber;
        partial void OnEngineeringProductNumberChanging(string value);
        partial void OnEngineeringProductNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringProductVersionId
        {
            get
            {
                return this._EngineeringProductVersionId;
            }
            set
            {
                this.OnEngineeringProductVersionIdChanging(value);
                this._EngineeringProductVersionId = value;
                this.OnEngineeringProductVersionIdChanged();
                this.OnPropertyChanged("EngineeringProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringProductVersionId;
        partial void OnEngineeringProductVersionIdChanging(string value);
        partial void OnEngineeringProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductAttributeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringProductAttributeName
        {
            get
            {
                return this._EngineeringProductAttributeName;
            }
            set
            {
                this.OnEngineeringProductAttributeNameChanging(value);
                this._EngineeringProductAttributeName = value;
                this.OnEngineeringProductAttributeNameChanged();
                this.OnPropertyChanged("EngineeringProductAttributeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringProductAttributeName;
        partial void OnEngineeringProductAttributeNameChanging(string value);
        partial void OnEngineeringProductAttributeNameChanged();
        /// <summary>
        /// There are no comments for Property EngineeringProductAttributeTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringProductAttributeTypeName
        {
            get
            {
                return this._EngineeringProductAttributeTypeName;
            }
            set
            {
                this.OnEngineeringProductAttributeTypeNameChanging(value);
                this._EngineeringProductAttributeTypeName = value;
                this.OnEngineeringProductAttributeTypeNameChanged();
                this.OnPropertyChanged("EngineeringProductAttributeTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringProductAttributeTypeName;
        partial void OnEngineeringProductAttributeTypeNameChanging(string value);
        partial void OnEngineeringProductAttributeTypeNameChanged();
        /// <summary>
        /// There are no comments for Property MaximumDecimalTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MaximumDecimalTolerance
        {
            get
            {
                return this._MaximumDecimalTolerance;
            }
            set
            {
                this.OnMaximumDecimalToleranceChanging(value);
                this._MaximumDecimalTolerance = value;
                this.OnMaximumDecimalToleranceChanged();
                this.OnPropertyChanged("MaximumDecimalTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MaximumDecimalTolerance;
        partial void OnMaximumDecimalToleranceChanging(decimal value);
        partial void OnMaximumDecimalToleranceChanged();
        /// <summary>
        /// There are no comments for Property DecimalToleranceIncrement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DecimalToleranceIncrement
        {
            get
            {
                return this._DecimalToleranceIncrement;
            }
            set
            {
                this.OnDecimalToleranceIncrementChanging(value);
                this._DecimalToleranceIncrement = value;
                this.OnDecimalToleranceIncrementChanged();
                this.OnPropertyChanged("DecimalToleranceIncrement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DecimalToleranceIncrement;
        partial void OnDecimalToleranceIncrementChanging(decimal value);
        partial void OnDecimalToleranceIncrementChanged();
        /// <summary>
        /// There are no comments for Property IntegerToleranceIncrement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IntegerToleranceIncrement
        {
            get
            {
                return this._IntegerToleranceIncrement;
            }
            set
            {
                this.OnIntegerToleranceIncrementChanging(value);
                this._IntegerToleranceIncrement = value;
                this.OnIntegerToleranceIncrementChanged();
                this.OnPropertyChanged("IntegerToleranceIncrement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntegerToleranceIncrement;
        partial void OnIntegerToleranceIncrementChanging(int value);
        partial void OnIntegerToleranceIncrementChanged();
        /// <summary>
        /// There are no comments for Property MaximumIntegerTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int MaximumIntegerTolerance
        {
            get
            {
                return this._MaximumIntegerTolerance;
            }
            set
            {
                this.OnMaximumIntegerToleranceChanging(value);
                this._MaximumIntegerTolerance = value;
                this.OnMaximumIntegerToleranceChanged();
                this.OnPropertyChanged("MaximumIntegerTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaximumIntegerTolerance;
        partial void OnMaximumIntegerToleranceChanging(int value);
        partial void OnMaximumIntegerToleranceChanged();
        /// <summary>
        /// There are no comments for Property IsInheritedAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInheritedAttribute
        {
            get
            {
                return this._IsInheritedAttribute;
            }
            set
            {
                this.OnIsInheritedAttributeChanging(value);
                this._IsInheritedAttribute = value;
                this.OnIsInheritedAttributeChanged();
                this.OnPropertyChanged("IsInheritedAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInheritedAttribute;
        partial void OnIsInheritedAttributeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInheritedAttributeChanged();
        /// <summary>
        /// There are no comments for Property IsSynchronizedWithBatchAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsSynchronizedWithBatchAttribute
        {
            get
            {
                return this._IsSynchronizedWithBatchAttribute;
            }
            set
            {
                this.OnIsSynchronizedWithBatchAttributeChanging(value);
                this._IsSynchronizedWithBatchAttribute = value;
                this.OnIsSynchronizedWithBatchAttributeChanged();
                this.OnPropertyChanged("IsSynchronizedWithBatchAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsSynchronizedWithBatchAttribute;
        partial void OnIsSynchronizedWithBatchAttributeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsSynchronizedWithBatchAttributeChanged();
        /// <summary>
        /// There are no comments for Property ToleranceFailingAction in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribToleranceAction> ToleranceFailingAction
        {
            get
            {
                return this._ToleranceFailingAction;
            }
            set
            {
                this.OnToleranceFailingActionChanging(value);
                this._ToleranceFailingAction = value;
                this.OnToleranceFailingActionChanged();
                this.OnPropertyChanged("ToleranceFailingAction");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribToleranceAction> _ToleranceFailingAction;
        partial void OnToleranceFailingActionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribToleranceAction> value);
        partial void OnToleranceFailingActionChanged();
        /// <summary>
        /// There are no comments for Property MinimumIntegerTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int MinimumIntegerTolerance
        {
            get
            {
                return this._MinimumIntegerTolerance;
            }
            set
            {
                this.OnMinimumIntegerToleranceChanging(value);
                this._MinimumIntegerTolerance = value;
                this.OnMinimumIntegerToleranceChanged();
                this.OnPropertyChanged("MinimumIntegerTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MinimumIntegerTolerance;
        partial void OnMinimumIntegerToleranceChanging(int value);
        partial void OnMinimumIntegerToleranceChanged();
        /// <summary>
        /// There are no comments for Property MinimumDecimalTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal MinimumDecimalTolerance
        {
            get
            {
                return this._MinimumDecimalTolerance;
            }
            set
            {
                this.OnMinimumDecimalToleranceChanging(value);
                this._MinimumDecimalTolerance = value;
                this.OnMinimumDecimalToleranceChanged();
                this.OnPropertyChanged("MinimumDecimalTolerance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _MinimumDecimalTolerance;
        partial void OnMinimumDecimalToleranceChanging(decimal value);
        partial void OnMinimumDecimalToleranceChanged();
        /// <summary>
        /// There are no comments for Property IsAttributeMandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsAttributeMandatory
        {
            get
            {
                return this._IsAttributeMandatory;
            }
            set
            {
                this.OnIsAttributeMandatoryChanging(value);
                this._IsAttributeMandatory = value;
                this.OnIsAttributeMandatoryChanged();
                this.OnPropertyChanged("IsAttributeMandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsAttributeMandatory;
        partial void OnIsAttributeMandatoryChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsAttributeMandatoryChanged();
        /// <summary>
        /// There are no comments for Property IsInheritingAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInheritingAttribute
        {
            get
            {
                return this._IsInheritingAttribute;
            }
            set
            {
                this.OnIsInheritingAttributeChanging(value);
                this._IsInheritingAttribute = value;
                this.OnIsInheritingAttributeChanged();
                this.OnPropertyChanged("IsInheritingAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInheritingAttribute;
        partial void OnIsInheritingAttributeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInheritingAttributeChanged();
        /// <summary>
        /// There are no comments for Property ProductAttribute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductAttribute ProductAttribute
        {
            get
            {
                return this._ProductAttribute;
            }
            set
            {
                this.OnProductAttributeChanging(value);
                this._ProductAttribute = value;
                this.OnProductAttributeChanged();
                this.OnPropertyChanged("ProductAttribute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductAttribute _ProductAttribute;
        partial void OnProductAttributeChanging(global::Microsoft.Dynamics.DataEntities.ProductAttribute value);
        partial void OnProductAttributeChanged();
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
