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
        /// There are no comments for EngineeringChangeOrderProductAttributeSingle in the schema.
        /// </summary>
    public partial class EngineeringChangeOrderProductAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductAttribute>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductAttributeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductAttributeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductAttributeSingle object.
        /// </summary>
        public EngineeringChangeOrderProductAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductAttribute> query)
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
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle EngineeringChangeOrderProduct
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringChangeOrderProduct == null))
                {
                    this._EngineeringChangeOrderProduct = new global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle(this.Context, GetPath("EngineeringChangeOrderProduct"));
                }
                return this._EngineeringChangeOrderProduct;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProductSingle _EngineeringChangeOrderProduct;
    }
        /// <summary>
        /// There are no comments for EngineeringChangeOrderProductAttribute in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// EngineeringProductAttributeName
    /// EngineeringProductAttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "EngineeringProductAttributeName", "EngineeringProductAttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductAttributes")]
    public partial class EngineeringChangeOrderProductAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="engineeringProductAttributeName">Initial value of EngineeringProductAttributeName.</param>
        /// <param name="engineeringProductAttributeTypeName">Initial value of EngineeringProductAttributeTypeName.</param>
        /// <param name="integerValue">Initial value of IntegerValue.</param>
        /// <param name="maximumDecimalTolerance">Initial value of MaximumDecimalTolerance.</param>
        /// <param name="decimalToleranceIncrement">Initial value of DecimalToleranceIncrement.</param>
        /// <param name="integerToleranceIncrement">Initial value of IntegerToleranceIncrement.</param>
        /// <param name="dateTimeValue">Initial value of DateTimeValue.</param>
        /// <param name="maximumIntegerTolerance">Initial value of MaximumIntegerTolerance.</param>
        /// <param name="decimalValue">Initial value of DecimalValue.</param>
        /// <param name="minimumIntegerTolerance">Initial value of MinimumIntegerTolerance.</param>
        /// <param name="minimumDecimalTolerance">Initial value of MinimumDecimalTolerance.</param>
        /// <param name="currencyValue">Initial value of CurrencyValue.</param>
        /// <param name="productAttribute">Initial value of ProductAttribute.</param>
        /// <param name="engineeringChangeOrderProduct">Initial value of EngineeringChangeOrderProduct.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductAttribute CreateEngineeringChangeOrderProductAttribute(string dataAreaId, 
                    string engineeringChangeOrderNumber, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    string engineeringProductAttributeName, 
                    string engineeringProductAttributeTypeName, 
                    int integerValue, 
                    decimal maximumDecimalTolerance, 
                    decimal decimalToleranceIncrement, 
                    int integerToleranceIncrement, 
                    global::System.DateTimeOffset dateTimeValue, 
                    int maximumIntegerTolerance, 
                    decimal decimalValue, 
                    int minimumIntegerTolerance, 
                    decimal minimumDecimalTolerance, 
                    decimal currencyValue, 
                    global::Microsoft.Dynamics.DataEntities.ProductAttribute productAttribute, 
                    global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct engineeringChangeOrderProduct)
        {
            EngineeringChangeOrderProductAttribute engineeringChangeOrderProductAttribute = new EngineeringChangeOrderProductAttribute();
            engineeringChangeOrderProductAttribute.dataAreaId = dataAreaId;
            engineeringChangeOrderProductAttribute.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductAttribute.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductAttribute.EngineeringProductAttributeName = engineeringProductAttributeName;
            engineeringChangeOrderProductAttribute.EngineeringProductAttributeTypeName = engineeringProductAttributeTypeName;
            engineeringChangeOrderProductAttribute.IntegerValue = integerValue;
            engineeringChangeOrderProductAttribute.MaximumDecimalTolerance = maximumDecimalTolerance;
            engineeringChangeOrderProductAttribute.DecimalToleranceIncrement = decimalToleranceIncrement;
            engineeringChangeOrderProductAttribute.IntegerToleranceIncrement = integerToleranceIncrement;
            engineeringChangeOrderProductAttribute.DateTimeValue = dateTimeValue;
            engineeringChangeOrderProductAttribute.MaximumIntegerTolerance = maximumIntegerTolerance;
            engineeringChangeOrderProductAttribute.DecimalValue = decimalValue;
            engineeringChangeOrderProductAttribute.MinimumIntegerTolerance = minimumIntegerTolerance;
            engineeringChangeOrderProductAttribute.MinimumDecimalTolerance = minimumDecimalTolerance;
            engineeringChangeOrderProductAttribute.CurrencyValue = currencyValue;
            if ((productAttribute == null))
            {
                throw new global::System.ArgumentNullException("productAttribute");
            }
            engineeringChangeOrderProductAttribute.ProductAttribute = productAttribute;
            if ((engineeringChangeOrderProduct == null))
            {
                throw new global::System.ArgumentNullException("engineeringChangeOrderProduct");
            }
            engineeringChangeOrderProductAttribute.EngineeringChangeOrderProduct = engineeringChangeOrderProduct;
            return engineeringChangeOrderProductAttribute;
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
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
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
        /// There are no comments for Property IntegerValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int IntegerValue
        {
            get
            {
                return this._IntegerValue;
            }
            set
            {
                this.OnIntegerValueChanging(value);
                this._IntegerValue = value;
                this.OnIntegerValueChanged();
                this.OnPropertyChanged("IntegerValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _IntegerValue;
        partial void OnIntegerValueChanging(int value);
        partial void OnIntegerValueChanged();
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
        /// There are no comments for Property CurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CurrencyCode
        {
            get
            {
                return this._CurrencyCode;
            }
            set
            {
                this.OnCurrencyCodeChanging(value);
                this._CurrencyCode = value;
                this.OnCurrencyCodeChanged();
                this.OnPropertyChanged("CurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CurrencyCode;
        partial void OnCurrencyCodeChanging(string value);
        partial void OnCurrencyCodeChanged();
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
        /// There are no comments for Property DateTimeValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.DateTimeOffset DateTimeValue
        {
            get
            {
                return this._DateTimeValue;
            }
            set
            {
                this.OnDateTimeValueChanging(value);
                this._DateTimeValue = value;
                this.OnDateTimeValueChanged();
                this.OnPropertyChanged("DateTimeValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _DateTimeValue;
        partial void OnDateTimeValueChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeValueChanged();
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
        /// There are no comments for Property DecimalValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal DecimalValue
        {
            get
            {
                return this._DecimalValue;
            }
            set
            {
                this.OnDecimalValueChanging(value);
                this._DecimalValue = value;
                this.OnDecimalValueChanged();
                this.OnPropertyChanged("DecimalValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _DecimalValue;
        partial void OnDecimalValueChanging(decimal value);
        partial void OnDecimalValueChanged();
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
        /// There are no comments for Property BooleanValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> BooleanValue
        {
            get
            {
                return this._BooleanValue;
            }
            set
            {
                this.OnBooleanValueChanging(value);
                this._BooleanValue = value;
                this.OnBooleanValueChanged();
                this.OnPropertyChanged("BooleanValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _BooleanValue;
        partial void OnBooleanValueChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnBooleanValueChanged();
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
        /// There are no comments for Property CurrencyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual decimal CurrencyValue
        {
            get
            {
                return this._CurrencyValue;
            }
            set
            {
                this.OnCurrencyValueChanging(value);
                this._CurrencyValue = value;
                this.OnCurrencyValueChanged();
                this.OnPropertyChanged("CurrencyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _CurrencyValue;
        partial void OnCurrencyValueChanging(decimal value);
        partial void OnCurrencyValueChanged();
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
        /// There are no comments for Property TextValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TextValue
        {
            get
            {
                return this._TextValue;
            }
            set
            {
                this.OnTextValueChanging(value);
                this._TextValue = value;
                this.OnTextValueChanged();
                this.OnPropertyChanged("TextValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TextValue;
        partial void OnTextValueChanging(string value);
        partial void OnTextValueChanged();
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
        /// There are no comments for Property EngineeringChangeOrderProduct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct EngineeringChangeOrderProduct
        {
            get
            {
                return this._EngineeringChangeOrderProduct;
            }
            set
            {
                this.OnEngineeringChangeOrderProductChanging(value);
                this._EngineeringChangeOrderProduct = value;
                this.OnEngineeringChangeOrderProductChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProduct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct _EngineeringChangeOrderProduct;
        partial void OnEngineeringChangeOrderProductChanging(global::Microsoft.Dynamics.DataEntities.EngineeringChangeOrderProduct value);
        partial void OnEngineeringChangeOrderProductChanged();
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
