using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class TrainingsOwners
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public int TrainingId { get; set; }
        public int? UserId { get; set; }

        public SystemClients Owner { get; set; }
        public Trainings Training { get; set; }
    }
}
