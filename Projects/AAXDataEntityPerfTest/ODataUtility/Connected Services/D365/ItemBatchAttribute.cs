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
    /// There are no comments for ItemBatchAttributeSingle in the schema.
    /// </summary>
    public partial class ItemBatchAttributeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemBatchAttribute>
    {
        /// <summary>
        /// Initialize a new ItemBatchAttributeSingle object.
        /// </summary>
        public ItemBatchAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemBatchAttributeSingle object.
        /// </summary>
        public ItemBatchAttributeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemBatchAttributeSingle object.
        /// </summary>
        public ItemBatchAttributeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemBatchAttribute> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ItemBatchAttributeValues in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue> ItemBatchAttributeValues
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ItemBatchAttributeValues == null))
                {
                    this._ItemBatchAttributeValues = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue>(GetPath("ItemBatchAttributeValues"));
                }
                return this._ItemBatchAttributeValues;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue> _ItemBatchAttributeValues;
    }
    /// <summary>
    /// There are no comments for ItemBatchAttribute in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// AttributeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "AttributeId")]
    [global::Microsoft.OData.Client.EntitySet("ItemBatchAttributes")]
    public partial class ItemBatchAttribute : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemBatchAttribute object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="attributeId">Initial value of AttributeId.</param>
        /// <param name="maximumDecimalTolerance">Initial value of MaximumDecimalTolerance.</param>
        /// <param name="decimalToleranceIncrement">Initial value of DecimalToleranceIncrement.</param>
        /// <param name="optimalDecimal">Initial value of OptimalDecimal.</param>
        /// <param name="integerToleranceIncrement">Initial value of IntegerToleranceIncrement.</param>
        /// <param name="optimalDate">Initial value of OptimalDate.</param>
        /// <param name="maximumIntegerTolerance">Initial value of MaximumIntegerTolerance.</param>
        /// <param name="minimumIntegerTolerance">Initial value of MinimumIntegerTolerance.</param>
        /// <param name="minimumDecimalTolerance">Initial value of MinimumDecimalTolerance.</param>
        /// <param name="optimalInteger">Initial value of OptimalInteger.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemBatchAttribute CreateItemBatchAttribute(string dataAreaId, 
                    string attributeId, 
                    decimal maximumDecimalTolerance, 
                    decimal decimalToleranceIncrement, 
                    decimal optimalDecimal, 
                    int integerToleranceIncrement, 
                    global::System.DateTimeOffset optimalDate, 
                    int maximumIntegerTolerance, 
                    int minimumIntegerTolerance, 
                    decimal minimumDecimalTolerance, 
                    int optimalInteger)
        {
            ItemBatchAttribute itemBatchAttribute = new ItemBatchAttribute();
            itemBatchAttribute.dataAreaId = dataAreaId;
            itemBatchAttribute.AttributeId = attributeId;
            itemBatchAttribute.MaximumDecimalTolerance = maximumDecimalTolerance;
            itemBatchAttribute.DecimalToleranceIncrement = decimalToleranceIncrement;
            itemBatchAttribute.OptimalDecimal = optimalDecimal;
            itemBatchAttribute.IntegerToleranceIncrement = integerToleranceIncrement;
            itemBatchAttribute.OptimalDate = optimalDate;
            itemBatchAttribute.MaximumIntegerTolerance = maximumIntegerTolerance;
            itemBatchAttribute.MinimumIntegerTolerance = minimumIntegerTolerance;
            itemBatchAttribute.MinimumDecimalTolerance = minimumDecimalTolerance;
            itemBatchAttribute.OptimalInteger = optimalInteger;
            return itemBatchAttribute;
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
        /// There are no comments for Property AttributeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AttributeId is required.")]
        public virtual string AttributeId
        {
            get
            {
                return this._AttributeId;
            }
            set
            {
                this.OnAttributeIdChanging(value);
                this._AttributeId = value;
                this.OnAttributeIdChanged();
                this.OnPropertyChanged("AttributeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeId;
        partial void OnAttributeIdChanging(string value);
        partial void OnAttributeIdChanged();
        /// <summary>
        /// There are no comments for Property MaximumDecimalTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumDecimalTolerance is required.")]
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
        /// There are no comments for Property AttributeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribType> AttributeType
        {
            get
            {
                return this._AttributeType;
            }
            set
            {
                this.OnAttributeTypeChanging(value);
                this._AttributeType = value;
                this.OnAttributeTypeChanged();
                this.OnPropertyChanged("AttributeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribType> _AttributeType;
        partial void OnAttributeTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.PdsBatchAttribType> value);
        partial void OnAttributeTypeChanged();
        /// <summary>
        /// There are no comments for Property DecimalToleranceIncrement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DecimalToleranceIncrement is required.")]
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
        /// There are no comments for Property OptimalDecimal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OptimalDecimal is required.")]
        public virtual decimal OptimalDecimal
        {
            get
            {
                return this._OptimalDecimal;
            }
            set
            {
                this.OnOptimalDecimalChanging(value);
                this._OptimalDecimal = value;
                this.OnOptimalDecimalChanged();
                this.OnPropertyChanged("OptimalDecimal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _OptimalDecimal;
        partial void OnOptimalDecimalChanging(decimal value);
        partial void OnOptimalDecimalChanged();
        /// <summary>
        /// There are no comments for Property IntegerToleranceIncrement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "IntegerToleranceIncrement is required.")]
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
        /// There are no comments for Property OptimalDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OptimalDate is required.")]
        public virtual global::System.DateTimeOffset OptimalDate
        {
            get
            {
                return this._OptimalDate;
            }
            set
            {
                this.OnOptimalDateChanging(value);
                this._OptimalDate = value;
                this.OnOptimalDateChanged();
                this.OnPropertyChanged("OptimalDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _OptimalDate;
        partial void OnOptimalDateChanging(global::System.DateTimeOffset value);
        partial void OnOptimalDateChanged();
        /// <summary>
        /// There are no comments for Property AttributeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string AttributeDescription
        {
            get
            {
                return this._AttributeDescription;
            }
            set
            {
                this.OnAttributeDescriptionChanging(value);
                this._AttributeDescription = value;
                this.OnAttributeDescriptionChanged();
                this.OnPropertyChanged("AttributeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AttributeDescription;
        partial void OnAttributeDescriptionChanging(string value);
        partial void OnAttributeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property MaximumIntegerTolerance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MaximumIntegerTolerance is required.")]
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
        /// There are no comments for Property OptimalText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string OptimalText
        {
            get
            {
                return this._OptimalText;
            }
            set
            {
                this.OnOptimalTextChanging(value);
                this._OptimalText = value;
                this.OnOptimalTextChanged();
                this.OnPropertyChanged("OptimalText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OptimalText;
        partial void OnOptimalTextChanging(string value);
        partial void OnOptimalTextChanged();
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumIntegerTolerance is required.")]
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

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "MinimumDecimalTolerance is required.")]
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
        /// There are no comments for Property OptimalInteger in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "OptimalInteger is required.")]
        public virtual int OptimalInteger
        {
            get
            {
                return this._OptimalInteger;
            }
            set
            {
                this.OnOptimalIntegerChanging(value);
                this._OptimalInteger = value;
                this.OnOptimalIntegerChanged();
                this.OnPropertyChanged("OptimalInteger");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _OptimalInteger;
        partial void OnOptimalIntegerChanging(int value);
        partial void OnOptimalIntegerChanged();
        /// <summary>
        /// There are no comments for Property ItemBatchAttributeValues in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue> ItemBatchAttributeValues
        {
            get
            {
                return this._ItemBatchAttributeValues;
            }
            set
            {
                this.OnItemBatchAttributeValuesChanging(value);
                this._ItemBatchAttributeValues = value;
                this.OnItemBatchAttributeValuesChanged();
                this.OnPropertyChanged("ItemBatchAttributeValues");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue> _ItemBatchAttributeValues = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnItemBatchAttributeValuesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ItemBatchAttributeValue> value);
        partial void OnItemBatchAttributeValuesChanged();
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
