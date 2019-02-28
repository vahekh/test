using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientTrainingFiles
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TrainingId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Guid { get; set; }
        public int? DocumentId { get; set; }

        public Documents Document { get; set; }
    }
}
