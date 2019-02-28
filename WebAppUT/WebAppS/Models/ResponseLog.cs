using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ResponseLog
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public int LanguageId { get; set; }
        public int TrainingVersion { get; set; }
        public int FlowId { get; set; }
        public string ResponseValue { get; set; }
        public int RunLogId { get; set; }
        public DateTime DateOfResponse { get; set; }
    }
}
