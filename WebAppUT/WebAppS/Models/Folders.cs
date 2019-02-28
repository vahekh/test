using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Folders
    {
        public Folders()
        {
            Documents = new HashSet<Documents>();
            InverseParent = new HashSet<Folders>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }

        public Folders Parent { get; set; }
        public ICollection<Documents> Documents { get; set; }
        public ICollection<Folders> InverseParent { get; set; }
    }
}
