using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class SurveyUsers
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
        public int? Fid { get; set; }

        public Surveys Survey { get; set; }
    }
}
