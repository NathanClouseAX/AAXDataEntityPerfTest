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
    /// There are no comments for EnvironmentalHealthAndSafetyCodeSingle in the schema.
    /// </summary>
    public partial class EnvironmentalHealthAndSafetyCodeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EnvironmentalHealthAndSafetyCode>
    {
        /// <summary>
        /// Initialize a new EnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EnvironmentalHealthAndSafetyCodeSingle object.
        /// </summary>
        public EnvironmentalHealthAndSafetyCodeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EnvironmentalHealthAndSafetyCode> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for EnvironmentalHealthAndSafetyCode in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EnvironmentalHealthAndSafetyCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EnvironmentalHealthAndSafetyCode")]
    [global::Microsoft.OData.Client.EntitySet("EnvironmentalHealthAndSafetyCodes")]
    public partial class EnvironmentalHealthAndSafetyCode : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EnvironmentalHealthAndSafetyCode object.
        /// </summary>
        /// <param name="environmentalHealthAndSafetyCode1">Initial value of EnvironmentalHealthAndSafetyCode1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EnvironmentalHealthAndSafetyCode CreateEnvironmentalHealthAndSafetyCode(string environmentalHealthAndSafetyCode1)
        {
            EnvironmentalHealthAndSafetyCode environmentalHealthAndSafetyCode = new EnvironmentalHealthAndSafetyCode();
            environmentalHealthAndSafetyCode.EnvironmentalHealthAndSafetyCode1 = environmentalHealthAndSafetyCode1;
            return environmentalHealthAndSafetyCode;
        }
        /// <summary>
        /// There are no comments for Property EnvironmentalHealthAndSafetyCode1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnvironmentalHealthAndSafetyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EnvironmentalHealthAndSafetyCode1 is required.")]
        public virtual string EnvironmentalHealthAndSafetyCode1
        {
            get
            {
                return this._EnvironmentalHealthAndSafetyCode1;
            }
            set
            {
                this.OnEnvironmentalHealthAndSafetyCode1Changing(value);
                this._EnvironmentalHealthAndSafetyCode1 = value;
                this.OnEnvironmentalHealthAndSafetyCode1Changed();
                this.OnPropertyChanged("EnvironmentalHealthAndSafetyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnvironmentalHealthAndSafetyCode1;
        partial void OnEnvironmentalHealthAndSafetyCode1Changing(string value);
        partial void OnEnvironmentalHealthAndSafetyCode1Changed();
        /// <summary>
        /// There are no comments for Property EnvironmentalHealthAndSafetyDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string EnvironmentalHealthAndSafetyDescription
        {
            get
            {
                return this._EnvironmentalHealthAndSafetyDescription;
            }
            set
            {
                this.OnEnvironmentalHealthAndSafetyDescriptionChanging(value);
                this._EnvironmentalHealthAndSafetyDescription = value;
                this.OnEnvironmentalHealthAndSafetyDescriptionChanged();
                this.OnPropertyChanged("EnvironmentalHealthAndSafetyDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EnvironmentalHealthAndSafetyDescription;
        partial void OnEnvironmentalHealthAndSafetyDescriptionChanging(string value);
        partial void OnEnvironmentalHealthAndSafetyDescriptionChanged();
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
