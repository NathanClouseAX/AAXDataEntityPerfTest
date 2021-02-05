﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for ProjectItemJournalTableSingle in the schema.
        /// </summary>
    public partial class ProjectItemJournalTableSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectItemJournalTable>
    {
        /// <summary>
        /// Initialize a new ProjectItemJournalTableSingle object.
        /// </summary>
        public ProjectItemJournalTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ProjectItemJournalTableSingle object.
        /// </summary>
        public ProjectItemJournalTableSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ProjectItemJournalTableSingle object.
        /// </summary>
        public ProjectItemJournalTableSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ProjectItemJournalTable> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle DimensionCombination
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DimensionCombination == null))
                {
                    this._DimensionCombination = new global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle(this.Context, GetPath("DimensionCombination"));
                }
                return this._DimensionCombination;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombinationSingle _DimensionCombination;
    }
        /// <summary>
        /// There are no comments for ProjectItemJournalTable in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// JournalId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "JournalId")]
    [global::Microsoft.OData.Client.EntitySet("ProjectItemJournalTables")]
    public partial class ProjectItemJournalTable : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProjectItemJournalTable object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="journalId">Initial value of JournalId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ProjectItemJournalTable CreateProjectItemJournalTable(string dataAreaId, string journalId)
        {
            ProjectItemJournalTable projectItemJournalTable = new ProjectItemJournalTable();
            projectItemJournalTable.dataAreaId = dataAreaId;
            projectItemJournalTable.JournalId = journalId;
            return projectItemJournalTable;
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
        /// There are no comments for Property JournalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalId
        {
            get
            {
                return this._JournalId;
            }
            set
            {
                this.OnJournalIdChanging(value);
                this._JournalId = value;
                this.OnJournalIdChanged();
                this.OnPropertyChanged("JournalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalId;
        partial void OnJournalIdChanging(string value);
        partial void OnJournalIdChanged();
        /// <summary>
        /// There are no comments for Property JournalName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string JournalName
        {
            get
            {
                return this._JournalName;
            }
            set
            {
                this.OnJournalNameChanging(value);
                this._JournalName = value;
                this.OnJournalNameChanged();
                this.OnPropertyChanged("JournalName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalName;
        partial void OnJournalNameChanging(string value);
        partial void OnJournalNameChanged();
        /// <summary>
        /// There are no comments for Property IsLinesDeletedAfterPosting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsLinesDeletedAfterPosting
        {
            get
            {
                return this._IsLinesDeletedAfterPosting;
            }
            set
            {
                this.OnIsLinesDeletedAfterPostingChanging(value);
                this._IsLinesDeletedAfterPosting = value;
                this.OnIsLinesDeletedAfterPostingChanged();
                this.OnPropertyChanged("IsLinesDeletedAfterPosting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsLinesDeletedAfterPosting;
        partial void OnIsLinesDeletedAfterPostingChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsLinesDeletedAfterPostingChanged();
        /// <summary>
        /// There are no comments for Property PostingDetailLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> PostingDetailLevel
        {
            get
            {
                return this._PostingDetailLevel;
            }
            set
            {
                this.OnPostingDetailLevelChanging(value);
                this._PostingDetailLevel = value;
                this.OnPostingDetailLevelChanged();
                this.OnPropertyChanged("PostingDetailLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> _PostingDetailLevel;
        partial void OnPostingDetailLevelChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DetailSummary> value);
        partial void OnPostingDetailLevelChanged();
        /// <summary>
        /// There are no comments for Property Posted in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Posted
        {
            get
            {
                return this._Posted;
            }
            set
            {
                this.OnPostedChanging(value);
                this._Posted = value;
                this.OnPostedChanged();
                this.OnPropertyChanged("Posted");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Posted;
        partial void OnPostedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnPostedChanged();
        /// <summary>
        /// There are no comments for Property OffsetAccountDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OffsetAccountDisplayValue
        {
            get
            {
                return this._OffsetAccountDisplayValue;
            }
            set
            {
                this.OnOffsetAccountDisplayValueChanging(value);
                this._OffsetAccountDisplayValue = value;
                this.OnOffsetAccountDisplayValueChanged();
                this.OnPropertyChanged("OffsetAccountDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OffsetAccountDisplayValue;
        partial void OnOffsetAccountDisplayValueChanging(string value);
        partial void OnOffsetAccountDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property InventSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventSiteId
        {
            get
            {
                return this._InventSiteId;
            }
            set
            {
                this.OnInventSiteIdChanging(value);
                this._InventSiteId = value;
                this.OnInventSiteIdChanged();
                this.OnPropertyChanged("InventSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventSiteId;
        partial void OnInventSiteIdChanging(string value);
        partial void OnInventSiteIdChanged();
        /// <summary>
        /// There are no comments for Property InventLocationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string InventLocationId
        {
            get
            {
                return this._InventLocationId;
            }
            set
            {
                this.OnInventLocationIdChanging(value);
                this._InventLocationId = value;
                this.OnInventLocationIdChanged();
                this.OnPropertyChanged("InventLocationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventLocationId;
        partial void OnInventLocationIdChanging(string value);
        partial void OnInventLocationIdChanged();
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
        /// There are no comments for Property BlockUserGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BlockUserGroupId
        {
            get
            {
                return this._BlockUserGroupId;
            }
            set
            {
                this.OnBlockUserGroupIdChanging(value);
                this._BlockUserGroupId = value;
                this.OnBlockUserGroupIdChanged();
                this.OnPropertyChanged("BlockUserGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BlockUserGroupId;
        partial void OnBlockUserGroupIdChanging(string value);
        partial void OnBlockUserGroupIdChanged();
        /// <summary>
        /// There are no comments for Property Reservation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> Reservation
        {
            get
            {
                return this._Reservation;
            }
            set
            {
                this.OnReservationChanging(value);
                this._Reservation = value;
                this.OnReservationChanged();
                this.OnPropertyChanged("Reservation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> _Reservation;
        partial void OnReservationChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.ItemReservation> value);
        partial void OnReservationChanged();
        /// <summary>
        /// There are no comments for Property DimensionCombination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.DimensionCombination DimensionCombination
        {
            get
            {
                return this._DimensionCombination;
            }
            set
            {
                this.OnDimensionCombinationChanging(value);
                this._DimensionCombination = value;
                this.OnDimensionCombinationChanged();
                this.OnPropertyChanged("DimensionCombination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.DimensionCombination _DimensionCombination;
        partial void OnDimensionCombinationChanging(global::Microsoft.Dynamics.DataEntities.DimensionCombination value);
        partial void OnDimensionCombinationChanged();
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
