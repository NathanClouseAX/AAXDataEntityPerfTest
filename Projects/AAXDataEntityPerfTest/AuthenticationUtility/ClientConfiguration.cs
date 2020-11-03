using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationUtility
{
    public partial class ClientConfiguration
    {
        public static ClientConfiguration Default { get { return ClientConfiguration.OneBox; } }

        public static ClientConfiguration OneBox = new ClientConfiguration()
        {
            // You only need to populate this section if you are logging on via a native app. For Service to Service scenarios in which you e.g. use a service principal you don't need that.
            UriString = "https://usnconeboxax1aos.cloud.onebox.dynamics.com/",
            UserName = "",
            // Insert the correct password here for the actual test.
            Password = "",

            // You need this only if you logon via service principal using a client secret. See: https://docs.microsoft.com/en-us/dynamics365/unified-operations/dev-itpro/data-entities/services-home-page to get more data on how to populate those fields.
            // You can find that under AAD in the azure portal
            ActiveDirectoryResource = "https://usnconeboxax1aos.cloud.onebox.dynamics.com", // Don't have a trailing " / ". Note: Some of the sample code handles that issue.
            ActiveDirectoryTenant = "https://login.windows.net/dynamicconsulting.com", // Some samples: https://login.windows.net/yourtenant.onmicrosoft.com, https://login.windows.net/microsoft.com
            ActiveDirectoryClientAppId = "6633f9d1-b8d8-446b-83f5-605b8a5a9313",
            // Insert here the application secret when authenticate with AAD by the application
            //ActiveDirectoryClientAppSecret = "VZD=6Xe7Bd55jBMQDFdB[OXg=qt]:4ru",
            ActiveDirectoryClientAppSecret = "a8JRbG61953yR1_U6KmX1..8.._YDlyD~K",

            // Change TLS version of HTTP request from the client here
            // Ex: TLSVersion = "1.2"
            // Leave it empty if want to use the default version
            TLSVersion = "",
        };

        public string TLSVersion { get; set; }
        public string UriString { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ActiveDirectoryResource { get; set; }
        public String ActiveDirectoryTenant { get; set; }
        public String ActiveDirectoryClientAppId { get; set; }
        public string ActiveDirectoryClientAppSecret { get; set; }
    }
}
