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
        /// There are no comments for GroupSingle in the schema.
        /// </summary>
    public partial class GroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Group>
    {
        /// <summary>
        /// Initialize a new GroupSingle object.
        /// </summary>
        public GroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new GroupSingle object.
        /// </summary>
        public GroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new GroupSingle object.
        /// </summary>
        public GroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Group> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSetSingle DimensionSet
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionSet == null))
                {
                    this._DimensionSet = new global::Microsoft.Dynamics.DataEntities.DimensionSetSingle(this.Context, GetPath("DimensionSet"));
                }
                return this._DimensionSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSetSingle _DimensionSet;
    }
        /// <summary>
        /// There are no comments for Group in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// DeferralsGroup
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "DeferralsGroup")]
    [global::Microsoft.OData.Client.EntitySet("Groups")]
    public partial class Group : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Group object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="deferralsGroup">Initial value of DeferralsGroup.</param>
        /// <param name="writingOffTime">Initial value of WritingOffTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Group CreateGroup(string dataAreaId, string deferralsGroup, int writingOffTime)
        {
            Group group = new Group();
            group.dataAreaId = dataAreaId;
            group.DeferralsGroup = deferralsGroup;
            group.WritingOffTime = writingOffTime;
            return group;
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
        /// There are no comments for Property DeferralsGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DeferralsGroup
        {
            get
            {
                return this._DeferralsGroup;
            }
            set
            {
                this.OnDeferralsGroupChanging(value);
                this._DeferralsGroup = value;
                this.OnDeferralsGroupChanged();
                this.OnPropertyChanged("DeferralsGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DeferralsGroup;
        partial void OnDeferralsGroupChanging(string value);
        partial void OnDeferralsGroupChanged();
        /// <summary>
        /// There are no comments for Property WritingOffTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int WritingOffTime
        {
            get
            {
                return this._WritingOffTime;
            }
            set
            {
                this.OnWritingOffTimeChanging(value);
                this._WritingOffTime = value;
                this.OnWritingOffTimeChanged();
                this.OnPropertyChanged("WritingOffTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _WritingOffTime;
        partial void OnWritingOffTimeChanging(int value);
        partial void OnWritingOffTimeChanged();
        /// <summary>
        /// There are no comments for Property WritingOffMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string WritingOffMethod
        {
            get
            {
                return this._WritingOffMethod;
            }
            set
            {
                this.OnWritingOffMethodChanging(value);
                this._WritingOffMethod = value;
                this.OnWritingOffMethodChanged();
                this.OnPropertyChanged("WritingOffMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WritingOffMethod;
        partial void OnWritingOffMethodChanging(string value);
        partial void OnWritingOffMethodChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DimensionDisplayValue
        {
            get
            {
                return this._DimensionDisplayValue;
            }
            set
            {
                this.OnDimensionDisplayValueChanging(value);
                this._DimensionDisplayValue = value;
                this.OnDimensionDisplayValueChanged();
                this.OnPropertyChanged("DimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDisplayValue;
        partial void OnDimensionDisplayValueChanging(string value);
        partial void OnDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property PostingProfile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PostingProfile
        {
            get
            {
                return this._PostingProfile;
            }
            set
            {
                this.OnPostingProfileChanging(value);
                this._PostingProfile = value;
                this.OnPostingProfileChanged();
                this.OnPropertyChanged("PostingProfile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostingProfile;
        partial void OnPostingProfileChanging(string value);
        partial void OnPostingProfileChanged();
        /// <summary>
        /// There are no comments for Property VATOffsetMethodForDeferrals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsVATRefundingMethod> VATOffsetMethodForDeferrals
        {
            get
            {
                return this._VATOffsetMethodForDeferrals;
            }
            set
            {
                this.OnVATOffsetMethodForDeferralsChanging(value);
                this._VATOffsetMethodForDeferrals = value;
                this.OnVATOffsetMethodForDeferralsChanged();
                this.OnPropertyChanged("VATOffsetMethodForDeferrals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsVATRefundingMethod> _VATOffsetMethodForDeferrals;
        partial void OnVATOffsetMethodForDeferralsChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsVATRefundingMethod> value);
        partial void OnVATOffsetMethodForDeferralsChanged();
        /// <summary>
        /// There are no comments for Property BeginningDateOfWritingOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitWriteStartDate> BeginningDateOfWritingOff
        {
            get
            {
                return this._BeginningDateOfWritingOff;
            }
            set
            {
                this.OnBeginningDateOfWritingOffChanging(value);
                this._BeginningDateOfWritingOff = value;
                this.OnBeginningDateOfWritingOffChanged();
                this.OnPropertyChanged("BeginningDateOfWritingOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitWriteStartDate> _BeginningDateOfWritingOff;
        partial void OnBeginningDateOfWritingOffChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitWriteStartDate> value);
        partial void OnBeginningDateOfWritingOffChanged();
        /// <summary>
        /// There are no comments for Property ModelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ModelNumber
        {
            get
            {
                return this._ModelNumber;
            }
            set
            {
                this.OnModelNumberChanging(value);
                this._ModelNumber = value;
                this.OnModelNumberChanged();
                this.OnPropertyChanged("ModelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ModelNumber;
        partial void OnModelNumberChanging(string value);
        partial void OnModelNumberChanged();
        /// <summary>
        /// There are no comments for Property DisposalDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitRetirementDate> DisposalDate
        {
            get
            {
                return this._DisposalDate;
            }
            set
            {
                this.OnDisposalDateChanging(value);
                this._DisposalDate = value;
                this.OnDisposalDateChanged();
                this.OnPropertyChanged("DisposalDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitRetirementDate> _DisposalDate;
        partial void OnDisposalDateChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RDeferralsInitRetirementDate> value);
        partial void OnDisposalDateChanged();
        /// <summary>
        /// There are no comments for Property DimensionSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionSet DimensionSet
        {
            get
            {
                return this._DimensionSet;
            }
            set
            {
                this.OnDimensionSetChanging(value);
                this._DimensionSet = value;
                this.OnDimensionSetChanged();
                this.OnPropertyChanged("DimensionSet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionSet _DimensionSet;
        partial void OnDimensionSetChanging(global::Microsoft.Dynamics.DataEntities.DimensionSet value);
        partial void OnDimensionSetChanged();
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
