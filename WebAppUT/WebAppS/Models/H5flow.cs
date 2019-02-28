using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class H5flow
    {
        public H5flow()
        {
            H5links = new HashSet<H5links>();
            InverseNextPageFlow = new HashSet<H5flow>();
        }

        public int Id { get; set; }
        public int Version { get; set; }
        public int Language { get; set; }
        public int Seq { get; set; }
        public int Chapter { get; set; }
        public int? PageId { get; set; }
        public int? QuizId { get; set; }
        public int FlowWait { get; set; }
        public int? ActionForNextPage { get; set; }
        public int? NextPageFlowId { get; set; }
        public int? SlideId { get; set; }
        public int? SurveyId { get; set; }
        public int? ModuleId { get; set; }
        public int? Status { get; set; }

        public H5flow NextPageFlow { get; set; }
        public H5pages Page { get; set; }
        public H5quizzes Quiz { get; set; }
        public H5surveys Survey { get; set; }
        public ICollection<H5links> H5links { get; set; }
        public ICollection<H5flow> InverseNextPageFlow { get; set; }
    }
}
