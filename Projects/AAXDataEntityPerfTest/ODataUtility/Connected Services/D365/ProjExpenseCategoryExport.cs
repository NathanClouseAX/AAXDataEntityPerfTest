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
        /// There are no comments for ProjExpenseCategoryExportSingle in the schema.
        /// </summary>
    public partial class ProjExpenseCategoryExportSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjExpenseCategoryExport>
    {
        /// <summary>
        /// Initialize a new ProjExpenseCategoryExportSingle object.
        /// </summary>
        public ProjExpenseCategoryExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjExpenseCategoryExportSingle object.
        /// </summary>
        public ProjExpenseCategoryExportSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjExpenseCategoryExportSingle object.
        /// </summary>
        public ProjExpenseCategoryExportSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjExpenseCategoryExport> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for ProjExpenseCategoryExport in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// CostType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "CostType")]
    [global::Microsoft.OData.Client.EntitySet("ProjExpenseCategoriesExport")]
    public partial class ProjExpenseCategoryExport : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjExpenseCategoryExport object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="costType">Initial value of CostType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjExpenseCategoryExport CreateProjExpenseCategoryExport(string dataAreaId, string costType)
        {
            ProjExpenseCategoryExport projExpenseCategoryExport = new ProjExpenseCategoryExport();
            projExpenseCategoryExport.dataAreaId = dataAreaId;
            projExpenseCategoryExport.CostType = costType;
            return projExpenseCategoryExport;
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
        /// There are no comments for Property CostType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostType
        {
            get
            {
                return this._CostType;
            }
            set
            {
                this.OnCostTypeChanging(value);
                this._CostType = value;
                this.OnCostTypeChanged();
                this.OnPropertyChanged("CostType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostType;
        partial void OnCostTypeChanging(string value);
        partial void OnCostTypeChanged();
        /// <summary>
        /// There are no comments for Property CostTxt in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CostTxt
        {
            get
            {
                return this._CostTxt;
            }
            set
            {
                this.OnCostTxtChanging(value);
                this._CostTxt = value;
                this.OnCostTxtChanged();
                this.OnPropertyChanged("CostTxt");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CostTxt;
        partial void OnCostTxtChanging(string value);
        partial void OnCostTxtChanged();
        /// <summary>
        /// There are no comments for Property TransactionCategoryId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TransactionCategoryId
        {
            get
            {
                return this._TransactionCategoryId;
            }
            set
            {
                this.OnTransactionCategoryIdChanging(value);
                this._TransactionCategoryId = value;
                this.OnTransactionCategoryIdChanged();
                this.OnPropertyChanged("TransactionCategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransactionCategoryId;
        partial void OnTransactionCategoryIdChanging(string value);
        partial void OnTransactionCategoryIdChanged();
        /// <summary>
        /// There are no comments for Property ExpType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> ExpType
        {
            get
            {
                return this._ExpType;
            }
            set
            {
                this.OnExpTypeChanging(value);
                this._ExpType = value;
                this.OnExpTypeChanged();
                this.OnPropertyChanged("ExpType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> _ExpType;
        partial void OnExpTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.TrvExpType> value);
        partial void OnExpTypeChanged();
        /// <summary>
        /// There are no comments for Property IsInactive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsInactive
        {
            get
            {
                return this._IsInactive;
            }
            set
            {
                this.OnIsInactiveChanging(value);
                this._IsInactive = value;
                this.OnIsInactiveChanged();
                this.OnPropertyChanged("IsInactive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsInactive;
        partial void OnIsInactiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsInactiveChanged();
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
