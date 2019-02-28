using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProcessorPaymentsGatewayTransactions
    {
        public int Id { get; set; }
        public string TsCreated { get; set; }
        public string MerchantId { get; set; }
        public string Status { get; set; }
        public string Last4 { get; set; }
        public string BillToFirstName { get; set; }
        public string BillToLastName { get; set; }
        public string BillToCompanyName { get; set; }
        public string DebitCredit { get; set; }
        public string Amount { get; set; }
        public string ConvenienceFeePrincipal { get; set; }
        public string ConsumerOrderId { get; set; }
        public string ConsumerId { get; set; }
        public string EnteredBy { get; set; }
        public string CardType { get; set; }
        public string TransactionId { get; set; }
        public string ResponseCode { get; set; }
        public string AuthCode { get; set; }
        public string ServiceFeePrincipal { get; set; }
        public string TotalAmount { get; set; }
        public string WalletId { get; set; }
        public string MerchantClientId { get; set; }
        public string TransactionType { get; set; }
    }
}
