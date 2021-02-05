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
        /// There are no comments for RetailTransactionServiceProfileSingle in the schema.
        /// </summary>
    public partial class RetailTransactionServiceProfileSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionServiceProfile>
    {
        /// <summary>
        /// Initialize a new RetailTransactionServiceProfileSingle object.
        /// </summary>
        public RetailTransactionServiceProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailTransactionServiceProfileSingle object.
        /// </summary>
        public RetailTransactionServiceProfileSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailTransactionServiceProfileSingle object.
        /// </summary>
        public RetailTransactionServiceProfileSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailTransactionServiceProfile> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RetailCallCenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCallCenter> RetailCallCenter
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailCallCenter == null))
                {
                    this._RetailCallCenter = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailCallCenter>(GetPath("RetailCallCenter"));
                }
                return this._RetailCallCenter;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailCallCenter> _RetailCallCenter;
        /// <summary>
        /// There are no comments for OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OnlineChannel> OnlineChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OnlineChannel == null))
                {
                    this._OnlineChannel = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.OnlineChannel>(GetPath("OnlineChannel"));
                }
                return this._OnlineChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.OnlineChannel> _OnlineChannel;
        /// <summary>
        /// There are no comments for RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailStore> RetailStore
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RetailStore == null))
                {
                    this._RetailStore = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.RetailStore>(GetPath("RetailStore"));
                }
                return this._RetailStore;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.RetailStore> _RetailStore;
    }
        /// <summary>
        /// There are no comments for RetailTransactionServiceProfile in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ProfileId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ProfileId")]
    [global::Microsoft.OData.Client.EntitySet("RetailTransactionServiceProfiles")]
    public partial class RetailTransactionServiceProfile : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailTransactionServiceProfile object.
        /// </summary>
        /// <param name="profileId">Initial value of ProfileId.</param>
        /// <param name="transferFileChunkSize">Initial value of TransferFileChunkSize.</param>
        /// <param name="reportExecutionTimeout">Initial value of ReportExecutionTimeout.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailTransactionServiceProfile CreateRetailTransactionServiceProfile(string profileId, int transferFileChunkSize, int reportExecutionTimeout)
        {
            RetailTransactionServiceProfile retailTransactionServiceProfile = new RetailTransactionServiceProfile();
            retailTransactionServiceProfile.ProfileId = profileId;
            retailTransactionServiceProfile.TransferFileChunkSize = transferFileChunkSize;
            retailTransactionServiceProfile.ReportExecutionTimeout = reportExecutionTimeout;
            return retailTransactionServiceProfile;
        }
        /// <summary>
        /// There are no comments for Property ProfileId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ProfileId
        {
            get
            {
                return this._ProfileId;
            }
            set
            {
                this.OnProfileIdChanging(value);
                this._ProfileId = value;
                this.OnProfileIdChanged();
                this.OnPropertyChanged("ProfileId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProfileId;
        partial void OnProfileIdChanging(string value);
        partial void OnProfileIdChanged();
        /// <summary>
        /// There are no comments for Property TSStaff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> TSStaff
        {
            get
            {
                return this._TSStaff;
            }
            set
            {
                this.OnTSStaffChanging(value);
                this._TSStaff = value;
                this.OnTSStaffChanged();
                this.OnPropertyChanged("TSStaff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _TSStaff;
        partial void OnTSStaffChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnTSStaffChanged();
        /// <summary>
        /// There are no comments for Property TSVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProfileVersion> TSVersion
        {
            get
            {
                return this._TSVersion;
            }
            set
            {
                this.OnTSVersionChanging(value);
                this._TSVersion = value;
                this.OnTSVersionChanged();
                this.OnPropertyChanged("TSVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProfileVersion> _TSVersion;
        partial void OnTSVersionChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailProfileVersion> value);
        partial void OnTSVersionChanged();
        /// <summary>
        /// There are no comments for Property SecurityOff in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> SecurityOff
        {
            get
            {
                return this._SecurityOff;
            }
            set
            {
                this.OnSecurityOffChanging(value);
                this._SecurityOff = value;
                this.OnSecurityOffChanged();
                this.OnPropertyChanged("SecurityOff");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _SecurityOff;
        partial void OnSecurityOffChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSecurityOffChanged();
        /// <summary>
        /// There are no comments for Property CentralTableServer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CentralTableServer
        {
            get
            {
                return this._CentralTableServer;
            }
            set
            {
                this.OnCentralTableServerChanging(value);
                this._CentralTableServer = value;
                this.OnCentralTableServerChanged();
                this.OnPropertyChanged("CentralTableServer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CentralTableServer;
        partial void OnCentralTableServerChanging(string value);
        partial void OnCentralTableServerChanged();
        /// <summary>
        /// There are no comments for Property IdentityProviderClaimType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentityProviderClaimType
        {
            get
            {
                return this._IdentityProviderClaimType;
            }
            set
            {
                this.OnIdentityProviderClaimTypeChanging(value);
                this._IdentityProviderClaimType = value;
                this.OnIdentityProviderClaimTypeChanged();
                this.OnPropertyChanged("IdentityProviderClaimType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentityProviderClaimType;
        partial void OnIdentityProviderClaimTypeChanging(string value);
        partial void OnIdentityProviderClaimTypeChanged();
        /// <summary>
        /// There are no comments for Property ServerServiceName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ServerServiceName
        {
            get
            {
                return this._ServerServiceName;
            }
            set
            {
                this.OnServerServiceNameChanging(value);
                this._ServerServiceName = value;
                this.OnServerServiceNameChanged();
                this.OnPropertyChanged("ServerServiceName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServerServiceName;
        partial void OnServerServiceNameChanging(string value);
        partial void OnServerServiceNameChanged();
        /// <summary>
        /// There are no comments for Property RetailTSData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RetailTSData
        {
            get
            {
                return this._RetailTSData;
            }
            set
            {
                this.OnRetailTSDataChanging(value);
                this._RetailTSData = value;
                this.OnRetailTSDataChanged();
                this.OnPropertyChanged("RetailTSData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RetailTSData;
        partial void OnRetailTSDataChanging(string value);
        partial void OnRetailTSDataChanged();
        /// <summary>
        /// There are no comments for Property PosTSPassword in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PosTSPassword
        {
            get
            {
                return this._PosTSPassword;
            }
            set
            {
                this.OnPosTSPasswordChanging(value);
                this._PosTSPassword = value;
                this.OnPosTSPasswordChanged();
                this.OnPropertyChanged("PosTSPassword");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PosTSPassword;
        partial void OnPosTSPasswordChanging(string value);
        partial void OnPosTSPasswordChanged();
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
        /// There are no comments for Property Protocol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionServiceProtocolType> Protocol
        {
            get
            {
                return this._Protocol;
            }
            set
            {
                this.OnProtocolChanging(value);
                this._Protocol = value;
                this.OnProtocolChanged();
                this.OnPropertyChanged("Protocol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionServiceProtocolType> _Protocol;
        partial void OnProtocolChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.RetailTransactionServiceProtocolType> value);
        partial void OnProtocolChanged();
        /// <summary>
        /// There are no comments for Property UserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this.OnUserIdChanging(value);
                this._UserId = value;
                this.OnUserIdChanged();
                this.OnPropertyChanged("UserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserId;
        partial void OnUserIdChanging(string value);
        partial void OnUserIdChanged();
        /// <summary>
        /// There are no comments for Property ServiceHostUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ServiceHostUrl
        {
            get
            {
                return this._ServiceHostUrl;
            }
            set
            {
                this.OnServiceHostUrlChanging(value);
                this._ServiceHostUrl = value;
                this.OnServiceHostUrlChanged();
                this.OnPropertyChanged("ServiceHostUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServiceHostUrl;
        partial void OnServiceHostUrlChanging(string value);
        partial void OnServiceHostUrlChanged();
        /// <summary>
        /// There are no comments for Property AosUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AosUrl
        {
            get
            {
                return this._AosUrl;
            }
            set
            {
                this.OnAosUrlChanging(value);
                this._AosUrl = value;
                this.OnAosUrlChanged();
                this.OnPropertyChanged("AosUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AosUrl;
        partial void OnAosUrlChanging(string value);
        partial void OnAosUrlChanged();
        /// <summary>
        /// There are no comments for Property IdentityProvider in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IdentityProvider
        {
            get
            {
                return this._IdentityProvider;
            }
            set
            {
                this.OnIdentityProviderChanging(value);
                this._IdentityProvider = value;
                this.OnIdentityProviderChanged();
                this.OnPropertyChanged("IdentityProvider");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IdentityProvider;
        partial void OnIdentityProviderChanging(string value);
        partial void OnIdentityProviderChanged();
        /// <summary>
        /// There are no comments for Property IssuerUri in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IssuerUri
        {
            get
            {
                return this._IssuerUri;
            }
            set
            {
                this.OnIssuerUriChanging(value);
                this._IssuerUri = value;
                this.OnIssuerUriChanged();
                this.OnPropertyChanged("IssuerUri");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuerUri;
        partial void OnIssuerUriChanging(string value);
        partial void OnIssuerUriChanged();
        /// <summary>
        /// There are no comments for Property ServerCertificateDNS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ServerCertificateDNS
        {
            get
            {
                return this._ServerCertificateDNS;
            }
            set
            {
                this.OnServerCertificateDNSChanging(value);
                this._ServerCertificateDNS = value;
                this.OnServerCertificateDNSChanged();
                this.OnPropertyChanged("ServerCertificateDNS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServerCertificateDNS;
        partial void OnServerCertificateDNSChanging(string value);
        partial void OnServerCertificateDNSChanged();
        /// <summary>
        /// There are no comments for Property AudienceUrn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string AudienceUrn
        {
            get
            {
                return this._AudienceUrn;
            }
            set
            {
                this.OnAudienceUrnChanging(value);
                this._AudienceUrn = value;
                this.OnAudienceUrnChanged();
                this.OnPropertyChanged("AudienceUrn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AudienceUrn;
        partial void OnAudienceUrnChanging(string value);
        partial void OnAudienceUrnChanged();
        /// <summary>
        /// There are no comments for Property TransferFileChunkSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int TransferFileChunkSize
        {
            get
            {
                return this._TransferFileChunkSize;
            }
            set
            {
                this.OnTransferFileChunkSizeChanging(value);
                this._TransferFileChunkSize = value;
                this.OnTransferFileChunkSizeChanged();
                this.OnPropertyChanged("TransferFileChunkSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TransferFileChunkSize;
        partial void OnTransferFileChunkSizeChanging(int value);
        partial void OnTransferFileChunkSizeChanged();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property IssuedTokenType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IssuedTokenType
        {
            get
            {
                return this._IssuedTokenType;
            }
            set
            {
                this.OnIssuedTokenTypeChanging(value);
                this._IssuedTokenType = value;
                this.OnIssuedTokenTypeChanged();
                this.OnPropertyChanged("IssuedTokenType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuedTokenType;
        partial void OnIssuedTokenTypeChanging(string value);
        partial void OnIssuedTokenTypeChanged();
        /// <summary>
        /// There are no comments for Property CentralTableServerPort in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CentralTableServerPort
        {
            get
            {
                return this._CentralTableServerPort;
            }
            set
            {
                this.OnCentralTableServerPortChanging(value);
                this._CentralTableServerPort = value;
                this.OnCentralTableServerPortChanged();
                this.OnPropertyChanged("CentralTableServerPort");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CentralTableServerPort;
        partial void OnCentralTableServerPortChanging(string value);
        partial void OnCentralTableServerPortChanged();
        /// <summary>
        /// There are no comments for Property ReportExecutionTimeout in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int ReportExecutionTimeout
        {
            get
            {
                return this._ReportExecutionTimeout;
            }
            set
            {
                this.OnReportExecutionTimeoutChanging(value);
                this._ReportExecutionTimeout = value;
                this.OnReportExecutionTimeoutChanged();
                this.OnPropertyChanged("ReportExecutionTimeout");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _ReportExecutionTimeout;
        partial void OnReportExecutionTimeoutChanging(int value);
        partial void OnReportExecutionTimeoutChanged();
        /// <summary>
        /// There are no comments for Property RetailCallCenter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCallCenter> RetailCallCenter
        {
            get
            {
                return this._RetailCallCenter;
            }
            set
            {
                this.OnRetailCallCenterChanging(value);
                this._RetailCallCenter = value;
                this.OnRetailCallCenterChanged();
                this.OnPropertyChanged("RetailCallCenter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCallCenter> _RetailCallCenter = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCallCenter>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailCallCenterChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailCallCenter> value);
        partial void OnRetailCallCenterChanged();
        /// <summary>
        /// There are no comments for Property OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OnlineChannel> OnlineChannel
        {
            get
            {
                return this._OnlineChannel;
            }
            set
            {
                this.OnOnlineChannelChanging(value);
                this._OnlineChannel = value;
                this.OnOnlineChannelChanged();
                this.OnPropertyChanged("OnlineChannel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OnlineChannel> _OnlineChannel = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OnlineChannel>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOnlineChannelChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.OnlineChannel> value);
        partial void OnOnlineChannelChanged();
        /// <summary>
        /// There are no comments for Property RetailStore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStore> RetailStore
        {
            get
            {
                return this._RetailStore;
            }
            set
            {
                this.OnRetailStoreChanging(value);
                this._RetailStore = value;
                this.OnRetailStoreChanged();
                this.OnPropertyChanged("RetailStore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStore> _RetailStore = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStore>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRetailStoreChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.RetailStore> value);
        partial void OnRetailStoreChanged();
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
