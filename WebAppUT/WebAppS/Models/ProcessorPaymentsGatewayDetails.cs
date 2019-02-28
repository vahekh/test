using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProcessorPaymentsGatewayDetails
    {
        public int Id { get; set; }
        public bool? Stignore { get; set; }
        public DateTime? Stvalidated { get; set; }
        public int? PgclientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DebitorCredit { get; set; }
        public int? OrderId { get; set; }
        public DateTime? OriginationDate { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
        public string ResponseType { get; set; }
        public DateTime? SettleDate { get; set; }
        public string SettledResponseCode { get; set; }
        public string Status { get; set; }
        public decimal? TotalAmount { get; set; }
        public string TransactionId { get; set; }
    }
}
