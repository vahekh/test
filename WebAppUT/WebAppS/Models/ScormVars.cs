using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ScormVars
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int EmployeeId { get; set; }
        public int TrainingId { get; set; }
        public string VarName { get; set; }
        public string VarValue { get; set; }
    }
}
