using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Transactions
    {
        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public int? ClientId { get; set; }
        public int? SalesPersonId { get; set; }
        public int? InvoiceId { get; set; }
        public string GroupId { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public int TransactionTypeId { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public int? CommissionScheduleId { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ProcessDate { get; set; }
        public int? CommissionGroupAssignmentId { get; set; }
        public bool? IsNew { get; set; }

        public SystemClients Client { get; set; }
        public Invoices Invoice { get; set; }
        public SalesPersons SalesPerson { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
    }
}
