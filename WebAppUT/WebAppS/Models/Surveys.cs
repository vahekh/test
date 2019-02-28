using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Surveys
    {
        public Surveys()
        {
            SurveyAnswers = new HashSet<SurveyAnswers>();
            SurveyDocuments = new HashSet<SurveyDocuments>();
            SurveyQuestions = new HashSet<SurveyQuestions>();
            SurveyUsers = new HashSet<SurveyUsers>();
            SurveyUsersSettings = new HashSet<SurveyUsersSettings>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SurveyType { get; set; }
        public int CreatedByClientId { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string Urlparameter { get; set; }
        public bool IsAllowedCopy { get; set; }
        public int? NumberOfTakes { get; set; }
        public int? NumberOfTakesPerUser { get; set; }
        public DateTimeOffset? FromDate { get; set; }
        public DateTimeOffset? ToDate { get; set; }
        public int? Fid { get; set; }
        public bool RequestClientInfo { get; set; }
        public bool? IsAllowedEditAnswer { get; set; }
        public bool IsShared { get; set; }

        public ICollection<SurveyAnswers> SurveyAnswers { get; set; }
        public ICollection<SurveyDocuments> SurveyDocuments { get; set; }
        public ICollection<SurveyQuestions> SurveyQuestions { get; set; }
        public ICollection<SurveyUsers> SurveyUsers { get; set; }
        public ICollection<SurveyUsersSettings> SurveyUsersSettings { get; set; }
    }
}
