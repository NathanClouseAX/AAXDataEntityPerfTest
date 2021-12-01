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
    /// There are no comments for EngineeringChangeOrderProductReleaseSingle in the schema.
    /// </summary>
    public partial class EngineeringChangeOrderProductReleaseSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRelease>
    {
        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductReleaseSingle object.
        /// </summary>
        public EngineeringChangeOrderProductReleaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductReleaseSingle object.
        /// </summary>
        public EngineeringChangeOrderProductReleaseSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EngineeringChangeOrderProductReleaseSingle object.
        /// </summary>
        public EngineeringChangeOrderProductReleaseSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EngineeringChangeOrderProductRelease> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2Single ProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProductV2 == null))
                {
                    this._ProductV2 = new global::Microsoft.Dynamics.DataEntities.ProductV2Single(this.Context, GetPath("ProductV2"));
                }
                return this._ProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2Single _ProductV2;
        /// <summary>
        /// There are no comments for ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single ReleasedProductV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductV2 == null))
                {
                    this._ReleasedProductV2 = new global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single(this.Context, GetPath("ReleasedProductV2"));
                }
                return this._ReleasedProductV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2Single _ReleasedProductV2;
        /// <summary>
        /// There are no comments for EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle EngineeringProductVersion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EngineeringProductVersion == null))
                {
                    this._EngineeringProductVersion = new global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle(this.Context, GetPath("EngineeringProductVersion"));
                }
                return this._EngineeringProductVersion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersionSingle _EngineeringProductVersion;
        /// <summary>
        /// There are no comments for ProcessorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.WorkerSingle ProcessorWorker
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProcessorWorker == null))
                {
                    this._ProcessorWorker = new global::Microsoft.Dynamics.DataEntities.WorkerSingle(this.Context, GetPath("ProcessorWorker"));
                }
                return this._ProcessorWorker;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.WorkerSingle _ProcessorWorker;
    }
    /// <summary>
    /// There are no comments for EngineeringChangeOrderProductRelease in the schema.
    /// </summary>
    /// <KeyProperties>
    /// dataAreaId
    /// EngineeringChangeOrderNumber
    /// EngineeringChangeOrderProductLineNumber
    /// ProductNumber
    /// ProductVersionId
    /// ReceivingLegalEntityId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("dataAreaId", "EngineeringChangeOrderNumber", "EngineeringChangeOrderProductLineNumber", "ProductNumber", "ProductVersionId", "ReceivingLegalEntityId")]
    [global::Microsoft.OData.Client.EntitySet("EngineeringChangeOrderProductReleases")]
    public partial class EngineeringChangeOrderProductRelease : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EngineeringChangeOrderProductRelease object.
        /// </summary>
        /// <param name="dataAreaId">Initial value of dataAreaId.</param>
        /// <param name="engineeringChangeOrderNumber">Initial value of EngineeringChangeOrderNumber.</param>
        /// <param name="engineeringChangeOrderProductLineNumber">Initial value of EngineeringChangeOrderProductLineNumber.</param>
        /// <param name="productNumber">Initial value of ProductNumber.</param>
        /// <param name="productVersionId">Initial value of ProductVersionId.</param>
        /// <param name="receivingLegalEntityId">Initial value of ReceivingLegalEntityId.</param>
        /// <param name="processedDateTime">Initial value of ProcessedDateTime.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EngineeringChangeOrderProductRelease CreateEngineeringChangeOrderProductRelease(string dataAreaId, 
                    string engineeringChangeOrderNumber, 
                    decimal engineeringChangeOrderProductLineNumber, 
                    string productNumber, 
                    string productVersionId, 
                    string receivingLegalEntityId, 
                    global::System.DateTimeOffset processedDateTime)
        {
            EngineeringChangeOrderProductRelease engineeringChangeOrderProductRelease = new EngineeringChangeOrderProductRelease();
            engineeringChangeOrderProductRelease.dataAreaId = dataAreaId;
            engineeringChangeOrderProductRelease.EngineeringChangeOrderNumber = engineeringChangeOrderNumber;
            engineeringChangeOrderProductRelease.EngineeringChangeOrderProductLineNumber = engineeringChangeOrderProductLineNumber;
            engineeringChangeOrderProductRelease.ProductNumber = productNumber;
            engineeringChangeOrderProductRelease.ProductVersionId = productVersionId;
            engineeringChangeOrderProductRelease.ReceivingLegalEntityId = receivingLegalEntityId;
            engineeringChangeOrderProductRelease.ProcessedDateTime = processedDateTime;
            return engineeringChangeOrderProductRelease;
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
        /// There are no comments for Property EngineeringChangeOrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderNumber is required.")]
        public virtual string EngineeringChangeOrderNumber
        {
            get
            {
                return this._EngineeringChangeOrderNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderNumberChanging(value);
                this._EngineeringChangeOrderNumber = value;
                this.OnEngineeringChangeOrderNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EngineeringChangeOrderNumber;
        partial void OnEngineeringChangeOrderNumberChanging(string value);
        partial void OnEngineeringChangeOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property EngineeringChangeOrderProductLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EngineeringChangeOrderProductLineNumber is required.")]
        public virtual decimal EngineeringChangeOrderProductLineNumber
        {
            get
            {
                return this._EngineeringChangeOrderProductLineNumber;
            }
            set
            {
                this.OnEngineeringChangeOrderProductLineNumberChanging(value);
                this._EngineeringChangeOrderProductLineNumber = value;
                this.OnEngineeringChangeOrderProductLineNumberChanged();
                this.OnPropertyChanged("EngineeringChangeOrderProductLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _EngineeringChangeOrderProductLineNumber;
        partial void OnEngineeringChangeOrderProductLineNumberChanging(decimal value);
        partial void OnEngineeringChangeOrderProductLineNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductNumber is required.")]
        public virtual string ProductNumber
        {
            get
            {
                return this._ProductNumber;
            }
            set
            {
                this.OnProductNumberChanging(value);
                this._ProductNumber = value;
                this.OnProductNumberChanged();
                this.OnPropertyChanged("ProductNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductNumber;
        partial void OnProductNumberChanging(string value);
        partial void OnProductNumberChanged();
        /// <summary>
        /// There are no comments for Property ProductVersionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProductVersionId is required.")]
        public virtual string ProductVersionId
        {
            get
            {
                return this._ProductVersionId;
            }
            set
            {
                this.OnProductVersionIdChanging(value);
                this._ProductVersionId = value;
                this.OnProductVersionIdChanged();
                this.OnPropertyChanged("ProductVersionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductVersionId;
        partial void OnProductVersionIdChanging(string value);
        partial void OnProductVersionIdChanged();
        /// <summary>
        /// There are no comments for Property ReceivingLegalEntityId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ReceivingLegalEntityId is required.")]
        public virtual string ReceivingLegalEntityId
        {
            get
            {
                return this._ReceivingLegalEntityId;
            }
            set
            {
                this.OnReceivingLegalEntityIdChanging(value);
                this._ReceivingLegalEntityId = value;
                this.OnReceivingLegalEntityIdChanged();
                this.OnPropertyChanged("ReceivingLegalEntityId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReceivingLegalEntityId;
        partial void OnReceivingLegalEntityIdChanging(string value);
        partial void OnReceivingLegalEntityIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property ReleasingSiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ReleasingSiteId
        {
            get
            {
                return this._ReleasingSiteId;
            }
            set
            {
                this.OnReleasingSiteIdChanging(value);
                this._ReleasingSiteId = value;
                this.OnReleasingSiteIdChanged();
                this.OnPropertyChanged("ReleasingSiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReleasingSiteId;
        partial void OnReleasingSiteIdChanging(string value);
        partial void OnReleasingSiteIdChanged();
        /// <summary>
        /// There are no comments for Property WillProductBeIncludedInRelease in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> WillProductBeIncludedInRelease
        {
            get
            {
                return this._WillProductBeIncludedInRelease;
            }
            set
            {
                this.OnWillProductBeIncludedInReleaseChanging(value);
                this._WillProductBeIncludedInRelease = value;
                this.OnWillProductBeIncludedInReleaseChanged();
                this.OnPropertyChanged("WillProductBeIncludedInRelease");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _WillProductBeIncludedInRelease;
        partial void OnWillProductBeIncludedInReleaseChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnWillProductBeIncludedInReleaseChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this._ProductName = value;
                this.OnProductNameChanged();
                this.OnPropertyChanged("ProductName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property ProcessorPersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string ProcessorPersonnelNumber
        {
            get
            {
                return this._ProcessorPersonnelNumber;
            }
            set
            {
                this.OnProcessorPersonnelNumberChanging(value);
                this._ProcessorPersonnelNumber = value;
                this.OnProcessorPersonnelNumberChanged();
                this.OnPropertyChanged("ProcessorPersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessorPersonnelNumber;
        partial void OnProcessorPersonnelNumberChanging(string value);
        partial void OnProcessorPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property ProcessedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ProcessedDateTime is required.")]
        public virtual global::System.DateTimeOffset ProcessedDateTime
        {
            get
            {
                return this._ProcessedDateTime;
            }
            set
            {
                this.OnProcessedDateTimeChanging(value);
                this._ProcessedDateTime = value;
                this.OnProcessedDateTimeChanged();
                this.OnPropertyChanged("ProcessedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ProcessedDateTime;
        partial void OnProcessedDateTimeChanging(global::System.DateTimeOffset value);
        partial void OnProcessedDateTimeChanged();
        /// <summary>
        /// There are no comments for Property ProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.ProductV2 ProductV2
        {
            get
            {
                return this._ProductV2;
            }
            set
            {
                this.OnProductV2Changing(value);
                this._ProductV2 = value;
                this.OnProductV2Changed();
                this.OnPropertyChanged("ProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ProductV2 _ProductV2;
        partial void OnProductV2Changing(global::Microsoft.Dynamics.DataEntities.ProductV2 value);
        partial void OnProductV2Changed();
        /// <summary>
        /// There are no comments for Property ReleasedProductV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 ReleasedProductV2
        {
            get
            {
                return this._ReleasedProductV2;
            }
            set
            {
                this.OnReleasedProductV2Changing(value);
                this._ReleasedProductV2 = value;
                this.OnReleasedProductV2Changed();
                this.OnPropertyChanged("ReleasedProductV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 _ReleasedProductV2;
        partial void OnReleasedProductV2Changing(global::Microsoft.Dynamics.DataEntities.ReleasedProductV2 value);
        partial void OnReleasedProductV2Changed();
        /// <summary>
        /// There are no comments for Property EngineeringProductVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion EngineeringProductVersion
        {
            get
            {
                return this._EngineeringProductVersion;
            }
            set
            {
                this.OnEngineeringProductVersionChanging(value);
                this._EngineeringProductVersion = value;
                this.OnEngineeringProductVersionChanged();
                this.OnPropertyChanged("EngineeringProductVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion _EngineeringProductVersion;
        partial void OnEngineeringProductVersionChanging(global::Microsoft.Dynamics.DataEntities.EngineeringProductVersion value);
        partial void OnEngineeringProductVersionChanged();
        /// <summary>
        /// There are no comments for Property ProcessorWorker in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual global::Microsoft.Dynamics.DataEntities.Worker ProcessorWorker
        {
            get
            {
                return this._ProcessorWorker;
            }
            set
            {
                this.OnProcessorWorkerChanging(value);
                this._ProcessorWorker = value;
                this.OnProcessorWorkerChanged();
                this.OnPropertyChanged("ProcessorWorker");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Worker _ProcessorWorker;
        partial void OnProcessorWorkerChanging(global::Microsoft.Dynamics.DataEntities.Worker value);
        partial void OnProcessorWorkerChanged();
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
