using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class FavoriteLists
    {
        public FavoriteLists()
        {
            FavoriteListEmployees = new HashSet<FavoriteListEmployees>();
        }

        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }

        public SystemClients Client { get; set; }
        public Employees Employee { get; set; }
        public ICollection<FavoriteListEmployees> FavoriteListEmployees { get; set; }
    }
}
