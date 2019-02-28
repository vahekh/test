using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Trainings
    {
        public Trainings()
        {
            Cfrs = new HashSet<Cfrs>();
            TrainingLanguageVersions = new HashSet<TrainingLanguageVersions>();
            TrainingsOwners = new HashSet<TrainingsOwners>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Expires { get; set; }
        public int TrainingNumber { get; set; }
        public int TrainingVersion { get; set; }
        public int TrainingType { get; set; }
        public byte[] ThumbnailImage { get; set; }
        public bool IsPracticalExamRequired { get; set; }
        public bool? DisableGroupMode { get; set; }
        public int? CompletionTime { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSignatureRequired { get; set; }
        public int TableOfContent { get; set; }
        public string ExternalCourseId { get; set; }
        public bool SkipFinishPage { get; set; }
        public string Guid { get; set; }
        public bool IsMenuLeft { get; set; }
        public int TrainingOrder { get; set; }
        public int? ReplacementId { get; set; }
        public string ScormStartPage { get; set; }
        public int? PassingScore { get; set; }
        public int? ScormVersion { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public int ScoreType { get; set; }
        public bool IsSignedDocumentRequired { get; set; }
        public string SignedDocumentName { get; set; }
        public string SignedDocumentBlobName { get; set; }

        public ICollection<Cfrs> Cfrs { get; set; }
        public ICollection<TrainingLanguageVersions> TrainingLanguageVersions { get; set; }
        public ICollection<TrainingsOwners> TrainingsOwners { get; set; }
    }
}
