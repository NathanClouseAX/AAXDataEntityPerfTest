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
        /// There are no comments for Kitting_KitHeaderSingle in the schema.
        /// </summary>
    public partial class Kitting_KitHeaderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_KitHeader>
    {
        /// <summary>
        /// Initialize a new Kitting_KitHeaderSingle object.
        /// </summary>
        public Kitting_KitHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new Kitting_KitHeaderSingle object.
        /// </summary>
        public Kitting_KitHeaderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new Kitting_KitHeaderSingle object.
        /// </summary>
        public Kitting_KitHeaderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Kitting_KitHeader> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for KittingKitVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitVersion> KittingKitVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._KittingKitVersion == null))
                {
                    this._KittingKitVersion = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.KittingKitVersion>(GetPath("KittingKitVersion"));
                }
                return this._KittingKitVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitVersion> _KittingKitVersion;
        /// <summary>
        /// There are no comments for KittingKitLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine> KittingKitLine
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._KittingKitLine == null))
                {
                    this._KittingKitLine = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine>(GetPath("KittingKitLine"));
                }
                return this._KittingKitLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine> _KittingKitLine;
        /// <summary>
        /// There are no comments for KitLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine> KitLines
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._KitLines == null))
                {
                    this._KitLines = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine>(GetPath("KitLines"));
                }
                return this._KitLines;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.KittingKitLine> _KitLines;
        /// <summary>
        /// There are no comments for ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle ProductionSite
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductionSite == null))
                {
                    this._ProductionSite = new global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle(this.Context, GetPath("ProductionSite"));
                }
                return this._ProductionSite;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSiteSingle _ProductionSite;
        /// <summary>
        /// There are no comments for ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ApprovingWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovingWorker == null))
                {
                    this._ApprovingWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ApprovingWorker"));
                }
                return this._ApprovingWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ApprovingWorker;
    }
        /// <summary>
        /// There are no comments for Kitting_KitHeader in the schema.
        /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// KitId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "KitId")]
    [global::Microsoft.OData.Client.EntitySet("Kitting_KitHeaders")]
    public partial class Kitting_KitHeader : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Kitting_KitHeader object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="kitId">Initial value of KitId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Kitting_KitHeader CreateKitting_KitHeader(string dataAreaId, string kitId)
        {
            Kitting_KitHeader kitting_KitHeader = new Kitting_KitHeader();
            kitting_KitHeader.dataAreaId = dataAreaId;
            kitting_KitHeader.KitId = kitId;
            return kitting_KitHeader;
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
        /// There are no comments for Property KitId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KitId
        {
            get
            {
                return this._KitId;
            }
            set
            {
                this.OnKitIdChanging(value);
                this._KitId = value;
                this.OnKitIdChanged();
                this.OnPropertyChanged("KitId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitId;
        partial void OnKitIdChanging(string value);
        partial void OnKitIdChanged();
        /// <summary>
        /// There are no comments for Property KitName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string KitName
        {
            get
            {
                return this._KitName;
            }
            set
            {
                this.OnKitNameChanging(value);
                this._KitName = value;
                this.OnKitNameChanged();
                this.OnPropertyChanged("KitName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _KitName;
        partial void OnKitNameChanging(string value);
        partial void OnKitNameChanged();
        /// <summary>
        /// There are no comments for Property ProductionSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductionSiteId
        {
            get
            {
                return this._ProductionSiteId;
            }
            set
            {
                this.OnProductionSiteIdChanging(value);
                this._ProductionSiteId = value;
                this.OnProductionSiteIdChanged();
                this.OnPropertyChanged("ProductionSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductionSiteId;
        partial void OnProductionSiteIdChanging(string value);
        partial void OnProductionSiteIdChanged();
        /// <summary>
        /// There are no comments for Property ProductGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProductGroupId
        {
            get
            {
                return this._ProductGroupId;
            }
            set
            {
                this.OnProductGroupIdChanging(value);
                this._ProductGroupId = value;
                this.OnProductGroupIdChanged();
                this.OnPropertyChanged("ProductGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductGroupId;
        partial void OnProductGroupIdChanging(string value);
        partial void OnProductGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ApproverPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ApproverPersonnelNumber
        {
            get
            {
                return this._ApproverPersonnelNumber;
            }
            set
            {
                this.OnApproverPersonnelNumberChanging(value);
                this._ApproverPersonnelNumber = value;
                this.OnApproverPersonnelNumberChanged();
                this.OnPropertyChanged("ApproverPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ApproverPersonnelNumber;
        partial void OnApproverPersonnelNumberChanging(string value);
        partial void OnApproverPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property IsApproved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsApproved
        {
            get
            {
                return this._IsApproved;
            }
            set
            {
                this.OnIsApprovedChanging(value);
                this._IsApproved = value;
                this.OnIsApprovedChanged();
                this.OnPropertyChanged("IsApproved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsApproved;
        partial void OnIsApprovedChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsApprovedChanged();
        /// <summary>
        /// There are no comments for Property KittingKitVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitVersion> KittingKitVersion
        {
            get
            {
                return this._KittingKitVersion;
            }
            set
            {
                this.OnKittingKitVersionChanging(value);
                this._KittingKitVersion = value;
                this.OnKittingKitVersionChanged();
                this.OnPropertyChanged("KittingKitVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitVersion> _KittingKitVersion = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitVersion>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnKittingKitVersionChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitVersion> value);
        partial void OnKittingKitVersionChanged();
        /// <summary>
        /// There are no comments for Property KittingKitLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> KittingKitLine
        {
            get
            {
                return this._KittingKitLine;
            }
            set
            {
                this.OnKittingKitLineChanging(value);
                this._KittingKitLine = value;
                this.OnKittingKitLineChanged();
                this.OnPropertyChanged("KittingKitLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> _KittingKitLine = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnKittingKitLineChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> value);
        partial void OnKittingKitLineChanged();
        /// <summary>
        /// There are no comments for Property KitLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> KitLines
        {
            get
            {
                return this._KitLines;
            }
            set
            {
                this.OnKitLinesChanging(value);
                this._KitLines = value;
                this.OnKitLinesChanged();
                this.OnPropertyChanged("KitLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> _KitLines = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnKitLinesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.KittingKitLine> value);
        partial void OnKitLinesChanged();
        /// <summary>
        /// There are no comments for Property ProductionSite in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OperationalSite ProductionSite
        {
            get
            {
                return this._ProductionSite;
            }
            set
            {
                this.OnProductionSiteChanging(value);
                this._ProductionSite = value;
                this.OnProductionSiteChanged();
                this.OnPropertyChanged("ProductionSite");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OperationalSite _ProductionSite;
        partial void OnProductionSiteChanging(global::Microsoft.Dynamics.DataEntities.OperationalSite value);
        partial void OnProductionSiteChanged();
        /// <summary>
        /// There are no comments for Property ApprovingWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Worker ApprovingWorker
        {
            get
            {
                return this._ApprovingWorker;
            }
            set
            {
                this.OnApprovingWorkerChanging(value);
                this._ApprovingWorker = value;
                this.OnApprovingWorkerChanged();
                this.OnPropertyChanged("ApprovingWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ApprovingWorker;
        partial void OnApprovingWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnApprovingWorkerChanged();
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