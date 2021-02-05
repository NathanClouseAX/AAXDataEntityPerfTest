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
        /// There are no comments for AddressStateSingle in the schema.
        /// </summary>
    public partial class AddressStateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AddressState>
    {
        /// <summary>
        /// Initialize a new AddressStateSingle object.
        /// </summary>
        public AddressStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AddressStateSingle object.
        /// </summary>
        public AddressStateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AddressStateSingle object.
        /// </summary>
        public AddressStateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AddressState> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Cities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressCity> Cities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Cities == null))
                {
                    this._Cities = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AddressCity>(GetPath("Cities"));
                }
                return this._Cities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressCity> _Cities;
        /// <summary>
        /// There are no comments for ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ReleasedProductsV2 == null))
                {
                    this._ReleasedProductsV2 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(GetPath("ReleasedProductsV2"));
                }
                return this._ReleasedProductsV2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2;
        /// <summary>
        /// There are no comments for Districts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict> Districts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Districts == null))
                {
                    this._Districts = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict>(GetPath("Districts"));
                }
                return this._Districts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressDistrict> _Districts;
        /// <summary>
        /// There are no comments for GarnishmentTaxLevies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> GarnishmentTaxLevies
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._GarnishmentTaxLevies == null))
                {
                    this._GarnishmentTaxLevies = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule>(GetPath("GarnishmentTaxLevies"));
                }
                return this._GarnishmentTaxLevies;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> _GarnishmentTaxLevies;
        /// <summary>
        /// There are no comments for AddressCounty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressCounty> AddressCounty
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AddressCounty == null))
                {
                    this._AddressCounty = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AddressCounty>(GetPath("AddressCounty"));
                }
                return this._AddressCounty;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AddressCounty> _AddressCounty;
        /// <summary>
        /// There are no comments for CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle CountryRegion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CountryRegion == null))
                {
                    this._CountryRegion = new global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle(this.Context, GetPath("CountryRegion"));
                }
                return this._CountryRegion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegionSingle _CountryRegion;
        /// <summary>
        /// There are no comments for OperationalSiteCurrentPostalAddresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress> OperationalSiteCurrentPostalAddresses
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OperationalSiteCurrentPostalAddresses == null))
                {
                    this._OperationalSiteCurrentPostalAddresses = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress>(GetPath("OperationalSiteCurrentPostalAddresses"));
                }
                return this._OperationalSiteCurrentPostalAddresses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress> _OperationalSiteCurrentPostalAddresses;
        /// <summary>
        /// There are no comments for Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Prospects == null))
                {
                    this._Prospects = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.Prospect>(GetPath("Prospects"));
                }
                return this._Prospects;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects;
        /// <summary>
        /// There are no comments for AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetLocation == null))
                {
                    this._AssetLocation = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation>(GetPath("AssetLocation"));
                }
                return this._AssetLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation;
    }
        /// <summary>
        /// There are no comments for AddressState in the schema.
        /// </summary>
    /// <KeyProperties>
    /// CountryRegionId
    /// State
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CountryRegionId", "State")]
    [global::Microsoft.OData.Client.EntitySet("AddressStates")]
    public partial class AddressState : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AddressState object.
        /// </summary>
        /// <param name="countryRegionId">Initial value of CountryRegionId.</param>
        /// <param name="state">Initial value of State.</param>
        /// <param name="countryRegion">Initial value of CountryRegion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AddressState CreateAddressState(string countryRegionId, string state, global::Microsoft.Dynamics.DataEntities.AddressCountryRegion countryRegion)
        {
            AddressState addressState = new AddressState();
            addressState.CountryRegionId = countryRegionId;
            addressState.State = state;
            if ((countryRegion == null))
            {
                throw new global::System.ArgumentNullException("countryRegion");
            }
            addressState.CountryRegion = countryRegion;
            return addressState;
        }
        /// <summary>
        /// There are no comments for Property CountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string CountryRegionId
        {
            get
            {
                return this._CountryRegionId;
            }
            set
            {
                this.OnCountryRegionIdChanging(value);
                this._CountryRegionId = value;
                this.OnCountryRegionIdChanged();
                this.OnPropertyChanged("CountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryRegionId;
        partial void OnCountryRegionIdChanging(string value);
        partial void OnCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property IntrastatCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string IntrastatCode
        {
            get
            {
                return this._IntrastatCode;
            }
            set
            {
                this.OnIntrastatCodeChanging(value);
                this._IntrastatCode = value;
                this.OnIntrastatCodeChanged();
                this.OnPropertyChanged("IntrastatCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IntrastatCode;
        partial void OnIntrastatCodeChanging(string value);
        partial void OnIntrastatCodeChanged();
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
        /// There are no comments for Property TimeZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> TimeZone
        {
            get
            {
                return this._TimeZone;
            }
            set
            {
                this.OnTimeZoneChanging(value);
                this._TimeZone = value;
                this.OnTimeZoneChanged();
                this.OnPropertyChanged("TimeZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> _TimeZone;
        partial void OnTimeZoneChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.Timezone> value);
        partial void OnTimeZoneChanged();
        /// <summary>
        /// There are no comments for Property BrazilStateCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string BrazilStateCode
        {
            get
            {
                return this._BrazilStateCode;
            }
            set
            {
                this.OnBrazilStateCodeChanging(value);
                this._BrazilStateCode = value;
                this.OnBrazilStateCodeChanged();
                this.OnPropertyChanged("BrazilStateCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BrazilStateCode;
        partial void OnBrazilStateCodeChanging(string value);
        partial void OnBrazilStateCodeChanged();
        /// <summary>
        /// There are no comments for Property Cities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCity> Cities
        {
            get
            {
                return this._Cities;
            }
            set
            {
                this.OnCitiesChanging(value);
                this._Cities = value;
                this.OnCitiesChanged();
                this.OnPropertyChanged("Cities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCity> _Cities = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCity>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCity> value);
        partial void OnCitiesChanged();
        /// <summary>
        /// There are no comments for Property ReleasedProductsV2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> ReleasedProductsV2
        {
            get
            {
                return this._ReleasedProductsV2;
            }
            set
            {
                this.OnReleasedProductsV2Changing(value);
                this._ReleasedProductsV2 = value;
                this.OnReleasedProductsV2Changed();
                this.OnPropertyChanged("ReleasedProductsV2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> _ReleasedProductsV2 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReleasedProductsV2Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.ReleasedProductV2> value);
        partial void OnReleasedProductsV2Changed();
        /// <summary>
        /// There are no comments for Property Districts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> Districts
        {
            get
            {
                return this._Districts;
            }
            set
            {
                this.OnDistrictsChanging(value);
                this._Districts = value;
                this.OnDistrictsChanged();
                this.OnPropertyChanged("Districts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> _Districts = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDistrictsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressDistrict> value);
        partial void OnDistrictsChanged();
        /// <summary>
        /// There are no comments for Property GarnishmentTaxLevies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> GarnishmentTaxLevies
        {
            get
            {
                return this._GarnishmentTaxLevies;
            }
            set
            {
                this.OnGarnishmentTaxLeviesChanging(value);
                this._GarnishmentTaxLevies = value;
                this.OnGarnishmentTaxLeviesChanged();
                this.OnPropertyChanged("GarnishmentTaxLevies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> _GarnishmentTaxLevies = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnGarnishmentTaxLeviesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerGarnishmentRule> value);
        partial void OnGarnishmentTaxLeviesChanged();
        /// <summary>
        /// There are no comments for Property AddressCounty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCounty> AddressCounty
        {
            get
            {
                return this._AddressCounty;
            }
            set
            {
                this.OnAddressCountyChanging(value);
                this._AddressCounty = value;
                this.OnAddressCountyChanged();
                this.OnPropertyChanged("AddressCounty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCounty> _AddressCounty = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCounty>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAddressCountyChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AddressCounty> value);
        partial void OnAddressCountyChanged();
        /// <summary>
        /// There are no comments for Property CountryRegion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.AddressCountryRegion CountryRegion
        {
            get
            {
                return this._CountryRegion;
            }
            set
            {
                this.OnCountryRegionChanging(value);
                this._CountryRegion = value;
                this.OnCountryRegionChanged();
                this.OnPropertyChanged("CountryRegion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.AddressCountryRegion _CountryRegion;
        partial void OnCountryRegionChanging(global::Microsoft.Dynamics.DataEntities.AddressCountryRegion value);
        partial void OnCountryRegionChanged();
        /// <summary>
        /// There are no comments for Property OperationalSiteCurrentPostalAddresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress> OperationalSiteCurrentPostalAddresses
        {
            get
            {
                return this._OperationalSiteCurrentPostalAddresses;
            }
            set
            {
                this.OnOperationalSiteCurrentPostalAddressesChanging(value);
                this._OperationalSiteCurrentPostalAddresses = value;
                this.OnOperationalSiteCurrentPostalAddressesChanged();
                this.OnPropertyChanged("OperationalSiteCurrentPostalAddresses");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress> _OperationalSiteCurrentPostalAddresses = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOperationalSiteCurrentPostalAddressesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.InventOperationalSiteCurrentPostalAddress> value);
        partial void OnOperationalSiteCurrentPostalAddressesChanged();
        /// <summary>
        /// There are no comments for Property Prospects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> Prospects
        {
            get
            {
                return this._Prospects;
            }
            set
            {
                this.OnProspectsChanging(value);
                this._Prospects = value;
                this.OnProspectsChanged();
                this.OnPropertyChanged("Prospects");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> _Prospects = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProspectsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.Prospect> value);
        partial void OnProspectsChanged();
        /// <summary>
        /// There are no comments for Property AssetLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> AssetLocation
        {
            get
            {
                return this._AssetLocation;
            }
            set
            {
                this.OnAssetLocationChanging(value);
                this._AssetLocation = value;
                this.OnAssetLocationChanged();
                this.OnPropertyChanged("AssetLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> _AssetLocation = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetLocationChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.AssetLocation> value);
        partial void OnAssetLocationChanged();
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
