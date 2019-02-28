using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Languages
    {
        public Languages()
        {
            TextBases = new HashSet<TextBases>();
            TrainingLanguageVersions = new HashSet<TrainingLanguageVersions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public ICollection<TextBases> TextBases { get; set; }
        public ICollection<TrainingLanguageVersions> TrainingLanguageVersions { get; set; }
    }
}
