using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientActions
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ActionId { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsTextMessage { get; set; }
        public bool IsInternal { get; set; }
    }
}
