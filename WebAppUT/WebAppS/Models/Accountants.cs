﻿using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Accountants
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int UserId { get; set; }
    }
}