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
        /// There are no comments for PickupTimeslotTemplateSingle in the schema.
        /// </summary>
    public partial class PickupTimeslotTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PickupTimeslotTemplate>
    {
        /// <summary>
        /// Initialize a new PickupTimeslotTemplateSingle object.
        /// </summary>
        public PickupTimeslotTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PickupTimeslotTemplateSingle object.
        /// </summary>
        public PickupTimeslotTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PickupTimeslotTemplateSingle object.
        /// </summary>
        public PickupTimeslotTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PickupTimeslotTemplate> query)
            : base(query) {}

    }
        /// <summary>
        /// There are no comments for PickupTimeslotTemplate in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// TimeslotId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "TimeslotId")]
    [global::Microsoft.OData.Client.EntitySet("PickupTimeslotTemplates")]
    public partial class PickupTimeslotTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PickupTimeslotTemplate object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="timeslotId">Initial value of TimeslotId.</param>
        /// <param name="maximumLimit">Initial value of MaximumLimit.</param>
        /// <param name="minimumLimit">Initial value of MinimumLimit.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PickupTimeslotTemplate CreatePickupTimeslotTemplate(string dataAreaId, string timeslotId, int maximumLimit, int minimumLimit)
        {
            PickupTimeslotTemplate pickupTimeslotTemplate = new PickupTimeslotTemplate();
            pickupTimeslotTemplate.dataAreaId = dataAreaId;
            pickupTimeslotTemplate.TimeslotId = timeslotId;
            pickupTimeslotTemplate.MaximumLimit = maximumLimit;
            pickupTimeslotTemplate.MinimumLimit = minimumLimit;
            return pickupTimeslotTemplate;
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
        /// There are no comments for Property TimeslotId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TimeslotId
        {
            get
            {
                return this._TimeslotId;
            }
            set
            {
                this.OnTimeslotIdChanging(value);
                this._TimeslotId = value;
                this.OnTimeslotIdChanged();
                this.OnPropertyChanged("TimeslotId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TimeslotId;
        partial void OnTimeslotIdChanging(string value);
        partial void OnTimeslotIdChanged();
        /// <summary>
        /// There are no comments for Property MaximumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int MaximumLimit
        {
            get
            {
                return this._MaximumLimit;
            }
            set
            {
                this.OnMaximumLimitChanging(value);
                this._MaximumLimit = value;
                this.OnMaximumLimitChanged();
                this.OnPropertyChanged("MaximumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MaximumLimit;
        partial void OnMaximumLimitChanging(int value);
        partial void OnMaximumLimitChanged();
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
        /// There are no comments for Property MinimumLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int MinimumLimit
        {
            get
            {
                return this._MinimumLimit;
            }
            set
            {
                this.OnMinimumLimitChanging(value);
                this._MinimumLimit = value;
                this.OnMinimumLimitChanged();
                this.OnPropertyChanged("MinimumLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _MinimumLimit;
        partial void OnMinimumLimitChanging(int value);
        partial void OnMinimumLimitChanged();
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
