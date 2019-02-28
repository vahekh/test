using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ActionPendings
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int ActionId { get; set; }
        public int? UserId { get; set; }
        public DateTime? ProcessDate { get; set; }
        public string Params { get; set; }
        public int? SenderClientId { get; set; }
        public int? SenderEmployeeId { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string FromName { get; set; }
        public string Domain { get; set; }
        public bool Status { get; set; }
        public string Cc { get; set; }
        public int? TemplateId { get; set; }
        public bool? IsSystem { get; set; }
        public string PhoneNumber { get; set; }
        public int? StatusNew { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string SessionId { get; set; }
        public int? ParameterId { get; set; }
        public string ParameterIds { get; set; }
        public DateTimeOffset? VisitDate { get; set; }

        public SystemClients Client { get; set; }
    }
}
