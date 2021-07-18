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
        /// There are no comments for MaterialDisposalCodeSingle in the schema.
        /// </summary>
    public partial class MaterialDisposalCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MaterialDisposalCode>
    {
        /// <summary>
        /// Initialize a new MaterialDisposalCodeSingle object.
        /// </summary>
        public MaterialDisposalCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MaterialDisposalCodeSingle object.
        /// </summary>
        public MaterialDisposalCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MaterialDisposalCodeSingle object.
        /// </summary>
        public MaterialDisposalCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MaterialDisposalCode> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for MaterialDisposalCode in the schema.
        /// </summary>
    /// <KeyProperties>
    /// MaterialDisposalCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("MaterialDisposalCode")]
    [global::Microsoft.OData.Client.EntitySet("MaterialDisposalCodes")]
    public partial class MaterialDisposalCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MaterialDisposalCode object.
        /// </summary>
        /// <param name="materialDisposalCode1">Initial value of MaterialDisposalCode1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static MaterialDisposalCode CreateMaterialDisposalCode(string materialDisposalCode1)
        {
            MaterialDisposalCode materialDisposalCode = new MaterialDisposalCode();
            materialDisposalCode.MaterialDisposalCode1 = materialDisposalCode1;
            return materialDisposalCode;
        }
        /// <summary>
        /// There are no comments for Property MaterialDisposalCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MaterialDisposalCode")]
        public virtual string MaterialDisposalCode1
        {
            get
            {
                return this._MaterialDisposalCode1;
            }
            set
            {
                this.OnMaterialDisposalCode1Changing(value);
                this._MaterialDisposalCode1 = value;
                this.OnMaterialDisposalCode1Changed();
                this.OnPropertyChanged("MaterialDisposalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialDisposalCode1;
        partial void OnMaterialDisposalCode1Changing(string value);
        partial void OnMaterialDisposalCode1Changed();
        /// <summary>
        /// There are no comments for Property MaterialDisposalDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string MaterialDisposalDescription
        {
            get
            {
                return this._MaterialDisposalDescription;
            }
            set
            {
                this.OnMaterialDisposalDescriptionChanging(value);
                this._MaterialDisposalDescription = value;
                this.OnMaterialDisposalDescriptionChanged();
                this.OnPropertyChanged("MaterialDisposalDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MaterialDisposalDescription;
        partial void OnMaterialDisposalDescriptionChanging(string value);
        partial void OnMaterialDisposalDescriptionChanged();
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
