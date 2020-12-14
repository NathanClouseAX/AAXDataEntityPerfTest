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
        /// There are no comments for ReleasedEngineeringProductVersionAttributeValueSingle in the schema.
        /// </summary>
    public partial class ReleasedEngineeringProductVersionAttributeValueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedEngineeringProductVersionAttributeValue>
    {
        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeValueSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeValueSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeValueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ReleasedEngineeringProductVersionAttributeValueSingle object.
        /// </summary>
        public ReleasedEngineeringProductVersionAttributeValueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ReleasedEngineeringProductVersionAttributeValue> query)
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
        /// There are no comments for ReleasedEngineeringProductVersionAttributeValue in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringProductNumber
    /// EngineeringProductVersionId
    /// EngineeringProductAttributeName
    /// EngineeringProductAttributeTypeName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringProductNumber", "EngineeringProductVersionId", "EngineeringProductAttributeName", "EngineeringProductAttributeTypeName")]
    [global::Microsoft.OData.Client.EntitySet("ReleasedEngineeringProductVersionAttributeValues")]
    public partial class ReleasedEngineeringProductVersionAttributeValue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ReleasedEngineeringProductVersionAttributeValue object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringProductNumber">Initial value of EngineeringProductNumber.</param>
        /// <param name="engineeringProductVersionId">Initial value of EngineeringProductVersionId.</param>
        /// <param name="engineeringProductAttributeName">Initial value of EngineeringProductAttributeName.</param>
        /// <param name="engineeringProductAttributeTypeName">Initial value of EngineeringProductAttributeTypeName.</param>
        /// <param name="integerValue">Initial value of IntegerValue.</param>
        /// <param name="integerUnitOfMeasure">Initial value of IntegerUnitOfMeasure.</param>
        /// <param name="dateTimeValue">Initial value of DateTimeValue.</param>
        /// <param name="decimalValue">Initial value of DecimalValue.</param>
        /// <param name="currencyValue">Initial value of CurrencyValue.</param>
        /// <param name="decimalUnitOfMeasure">Initial value of DecimalUnitOfMeasure.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ReleasedEngineeringProductVersionAttributeValue CreateReleasedEngineeringProductVersionAttributeValue(string dataAreaId, 
                    string engineeringProductNumber, 
                    string engineeringProductVersionId, 
                    string engineeringProductAttributeName, 
                    string engineeringProductAttributeTypeName, 
                    int integerValue, 
                    long integerUnitOfMeasure, 
                    global::System.DateTimeOffset dateTimeValue, 
                    decimal decimalValue, 
                    decimal currencyValue, 
                    long decimalUnitOfMeasure)
        {
            ReleasedEngineeringProductVersionAttributeValue releasedEngineeringProductVersionAttributeValue = new ReleasedEngineeringProductVersionAttributeValue();
            releasedEngineeringProductVersionAttributeValue.dataAreaId = dataAreaId;
            releasedEngineeringProductVersionAttributeValue.EngineeringProductNumber = engineeringProductNumber;
            releasedEngineeringProductVersionAttributeValue.EngineeringProductVersionId = engineeringProductVersionId;
            releasedEngineeringProductVersionAttributeValue.EngineeringProductAttributeName = engineeringProductAttributeName;
            releasedEngineeringProductVersionAttributeValue.EngineeringProductAttributeTypeName = engineeringProductAttributeTypeName;
            releasedEngineeringProductVersionAttributeValue.IntegerValue = integerValue;
            releasedEngineeringProductVersionAttributeValue.IntegerUnitOfMeasure = integerUnitOfMeasure;
            releasedEngineeringProductVersionAttributeValue.DateTimeValue = dateTimeValue;
            releasedEngineeringProductVersionAttributeValue.DecimalValue = decimalValue;
            releasedEngineeringProductVersionAttributeValue.CurrencyValue = currencyValue;
            releasedEngineeringProductVersionAttributeValue.DecimalUnitOfMeasure = decimalUnitOfMeasure;
            return releasedEngineeringProductVersionAttributeValue;
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
        /// There are no comments for Property IntegerUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long IntegerUnitOfMeasure
        {
            get
            {
                return this._IntegerUnitOfMeasure;
            }
            set
            {
                this.OnIntegerUnitOfMeasureChanging(value);
                this._IntegerUnitOfMeasure = value;
                this.OnIntegerUnitOfMeasureChanged();
                this.OnPropertyChanged("IntegerUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _IntegerUnitOfMeasure;
        partial void OnIntegerUnitOfMeasureChanging(long value);
        partial void OnIntegerUnitOfMeasureChanged();
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
        /// There are no comments for Property DecimalUnitOfMeasure in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual long DecimalUnitOfMeasure
        {
            get
            {
                return this._DecimalUnitOfMeasure;
            }
            set
            {
                this.OnDecimalUnitOfMeasureChanging(value);
                this._DecimalUnitOfMeasure = value;
                this.OnDecimalUnitOfMeasureChanged();
                this.OnPropertyChanged("DecimalUnitOfMeasure");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _DecimalUnitOfMeasure;
        partial void OnDecimalUnitOfMeasureChanging(long value);
        partial void OnDecimalUnitOfMeasureChanged();
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
