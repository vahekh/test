using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class FavoriteListEmployees
    {
        public int Id { get; set; }
        public int FavoriteListId { get; set; }
        public int EmployeeId { get; set; }

        public Employees Employee { get; set; }
        public FavoriteLists FavoriteList { get; set; }
    }
}
