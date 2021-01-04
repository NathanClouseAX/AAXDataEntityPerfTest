﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/3/2021 8:21:45 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RetailChannelPaymentConnectorLineSingle in the schema.
        /// </summary>
    public partial class RetailChannelPaymentConnectorLineSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelPaymentConnectorLine>
    {
        /// <summary>
        /// Initialize a new RetailChannelPaymentConnectorLineSingle object.
        /// </summary>
        public RetailChannelPaymentConnectorLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RetailChannelPaymentConnectorLineSingle object.
        /// </summary>
        public RetailChannelPaymentConnectorLineSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RetailChannelPaymentConnectorLineSingle object.
        /// </summary>
        public RetailChannelPaymentConnectorLineSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RetailChannelPaymentConnectorLine> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle OnlineChannel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._OnlineChannel == null))
                {
                    this._OnlineChannel = new global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle(this.Context, GetPath("OnlineChannel"));
                }
                return this._OnlineChannel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.OnlineChannelSingle _OnlineChannel;
    }
        /// <summary>
        /// There are no comments for RetailChannelPaymentConnectorLine in the schema.
        /// </summary>
    /// <KeyProperties>
    /// OperatingUnitNumber
    /// PaymentConnectorName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("OperatingUnitNumber", "PaymentConnectorName")]
    [global::Microsoft.OData.Client.EntitySet("RetailChannelPaymentConnectorLines")]
    public partial class RetailChannelPaymentConnectorLine : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RetailChannelPaymentConnectorLine object.
        /// </summary>
        /// <param name="operatingUnitNumber">Initial value of OperatingUnitNumber.</param>
        /// <param name="paymentConnectorName">Initial value of PaymentConnectorName.</param>
        /// <param name="onlineChannel">Initial value of OnlineChannel.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RetailChannelPaymentConnectorLine CreateRetailChannelPaymentConnectorLine(string operatingUnitNumber, string paymentConnectorName, global::Microsoft.Dynamics.DataEntities.OnlineChannel onlineChannel)
        {
            RetailChannelPaymentConnectorLine retailChannelPaymentConnectorLine = new RetailChannelPaymentConnectorLine();
            retailChannelPaymentConnectorLine.OperatingUnitNumber = operatingUnitNumber;
            retailChannelPaymentConnectorLine.PaymentConnectorName = paymentConnectorName;
            if ((onlineChannel == null))
            {
                throw new global::System.ArgumentNullException("onlineChannel");
            }
            retailChannelPaymentConnectorLine.OnlineChannel = onlineChannel;
            return retailChannelPaymentConnectorLine;
        }
        /// <summary>
        /// There are no comments for Property OperatingUnitNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string OperatingUnitNumber
        {
            get
            {
                return this._OperatingUnitNumber;
            }
            set
            {
                this.OnOperatingUnitNumberChanging(value);
                this._OperatingUnitNumber = value;
                this.OnOperatingUnitNumberChanged();
                this.OnPropertyChanged("OperatingUnitNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OperatingUnitNumber;
        partial void OnOperatingUnitNumberChanging(string value);
        partial void OnOperatingUnitNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentConnectorName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentConnectorName
        {
            get
            {
                return this._PaymentConnectorName;
            }
            set
            {
                this.OnPaymentConnectorNameChanging(value);
                this._PaymentConnectorName = value;
                this.OnPaymentConnectorNameChanged();
                this.OnPropertyChanged("PaymentConnectorName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentConnectorName;
        partial void OnPaymentConnectorNameChanging(string value);
        partial void OnPaymentConnectorNameChanged();
        /// <summary>
        /// There are no comments for Property PaymentConnectorProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PaymentConnectorProperties
        {
            get
            {
                return this._PaymentConnectorProperties;
            }
            set
            {
                this.OnPaymentConnectorPropertiesChanging(value);
                this._PaymentConnectorProperties = value;
                this.OnPaymentConnectorPropertiesChanged();
                this.OnPropertyChanged("PaymentConnectorProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentConnectorProperties;
        partial void OnPaymentConnectorPropertiesChanging(string value);
        partial void OnPaymentConnectorPropertiesChanged();
        /// <summary>
        /// There are no comments for Property OnlineChannel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.OnlineChannel OnlineChannel
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
        private global::Microsoft.Dynamics.DataEntities.OnlineChannel _OnlineChannel;
        partial void OnOnlineChannelChanging(global::Microsoft.Dynamics.DataEntities.OnlineChannel value);
        partial void OnOnlineChannelChanged();
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
