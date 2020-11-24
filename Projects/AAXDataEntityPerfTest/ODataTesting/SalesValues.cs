using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODataTesting
{
    public class SalesValues
    {
        public string SalesId { get; set; }
        public string CustAccount { get; set; }
        public string DataAreaId { get; set; }
        public string InventSiteId { get; set; }
        public string InventLocationid { get; set; }      
        public string SalesName { get; set; }
        public string Email { get; set; }
        public string PurchOrderFormNum { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public int SalesStatus { get; set; }
    }
}
