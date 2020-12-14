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
        /// There are no comments for DiscussionTypeSingle in the schema.
        /// </summary>
    public partial class DiscussionTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DiscussionType>
    {
        /// <summary>
        /// Initialize a new DiscussionTypeSingle object.
        /// </summary>
        public DiscussionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DiscussionTypeSingle object.
        /// </summary>
        public DiscussionTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DiscussionTypeSingle object.
        /// </summary>
        public DiscussionTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DiscussionType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Discussions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Discussion> Discussions
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Discussions == null))
                {
                    this._Discussions = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Discussion>(GetPath("Discussions"));
                }
                return this._Discussions;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Discussion> _Discussions;
    }
        /// <summary>
        /// There are no comments for DiscussionType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// DiscussionTypeId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DiscussionTypeId")]
    [global::Microsoft.OData.Client.EntitySet("DiscussionTypes")]
    public partial class DiscussionType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DiscussionType object.
        /// </summary>
        /// <param name="discussionTypeId">Initial value of DiscussionTypeId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DiscussionType CreateDiscussionType(string discussionTypeId)
        {
            DiscussionType discussionType = new DiscussionType();
            discussionType.DiscussionTypeId = discussionTypeId;
            return discussionType;
        }
        /// <summary>
        /// There are no comments for Property DiscussionTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string DiscussionTypeId
        {
            get
            {
                return this._DiscussionTypeId;
            }
            set
            {
                this.OnDiscussionTypeIdChanging(value);
                this._DiscussionTypeId = value;
                this.OnDiscussionTypeIdChanged();
                this.OnPropertyChanged("DiscussionTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DiscussionTypeId;
        partial void OnDiscussionTypeIdChanging(string value);
        partial void OnDiscussionTypeIdChanged();
        /// <summary>
        /// There are no comments for Property EnableEmployeeSignOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableEmployeeSignOff
        {
            get
            {
                return this._EnableEmployeeSignOff;
            }
            set
            {
                this.OnEnableEmployeeSignOffChanging(value);
                this._EnableEmployeeSignOff = value;
                this.OnEnableEmployeeSignOffChanged();
                this.OnPropertyChanged("EnableEmployeeSignOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableEmployeeSignOff;
        partial void OnEnableEmployeeSignOffChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableEmployeeSignOffChanged();
        /// <summary>
        /// There are no comments for Property EditFinalReview in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EditFinalReview
        {
            get
            {
                return this._EditFinalReview;
            }
            set
            {
                this.OnEditFinalReviewChanging(value);
                this._EditFinalReview = value;
                this.OnEditFinalReviewChanged();
                this.OnPropertyChanged("EditFinalReview");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EditFinalReview;
        partial void OnEditFinalReviewChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEditFinalReviewChanged();
        /// <summary>
        /// There are no comments for Property WorkflowEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WorkflowEnabled
        {
            get
            {
                return this._WorkflowEnabled;
            }
            set
            {
                this.OnWorkflowEnabledChanging(value);
                this._WorkflowEnabled = value;
                this.OnWorkflowEnabledChanged();
                this.OnPropertyChanged("WorkflowEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WorkflowEnabled;
        partial void OnWorkflowEnabledChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWorkflowEnabledChanged();
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
        /// There are no comments for Property EnableManagerSignOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> EnableManagerSignOff
        {
            get
            {
                return this._EnableManagerSignOff;
            }
            set
            {
                this.OnEnableManagerSignOffChanging(value);
                this._EnableManagerSignOff = value;
                this.OnEnableManagerSignOffChanged();
                this.OnPropertyChanged("EnableManagerSignOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _EnableManagerSignOff;
        partial void OnEnableManagerSignOffChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnEnableManagerSignOffChanged();
        /// <summary>
        /// There are no comments for Property NewReviewStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionStartingStatus> NewReviewStatus
        {
            get
            {
                return this._NewReviewStatus;
            }
            set
            {
                this.OnNewReviewStatusChanging(value);
                this._NewReviewStatus = value;
                this.OnNewReviewStatusChanged();
                this.OnPropertyChanged("NewReviewStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionStartingStatus> _NewReviewStatus;
        partial void OnNewReviewStatusChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmDiscussionStartingStatus> value);
        partial void OnNewReviewStatusChanged();
        /// <summary>
        /// There are no comments for Property Discussions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> Discussions
        {
            get
            {
                return this._Discussions;
            }
            set
            {
                this.OnDiscussionsChanging(value);
                this._Discussions = value;
                this.OnDiscussionsChanged();
                this.OnPropertyChanged("Discussions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> _Discussions = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDiscussionsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Discussion> value);
        partial void OnDiscussionsChanged();
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
