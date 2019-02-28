using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductActions
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ActionId { get; set; }
        public string Email { get; set; }

        public SystemActions Action { get; set; }
        public Products Product { get; set; }
    }
}
