using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientActionTypes
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ActionTypeId { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsEnabled { get; set; }
    }
}
