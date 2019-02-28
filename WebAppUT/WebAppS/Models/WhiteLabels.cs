using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class WhiteLabels
    {
        public WhiteLabels()
        {
            CommissionGroupAssignments = new HashSet<CommissionGroupAssignments>();
            CommissionGroups = new HashSet<CommissionGroups>();
            CommissionSchedules = new HashSet<CommissionSchedules>();
            ContactPersons = new HashSet<ContactPersons>();
            CustomFields = new HashSet<CustomFields>();
            Discounts = new HashSet<Discounts>();
            FoundInfos = new HashSet<FoundInfos>();
            Industries = new HashSet<Industries>();
            Orders = new HashSet<Orders>();
            Products = new HashSet<Products>();
            SalesPersons = new HashSet<SalesPersons>();
            ShoppingCartCache = new HashSet<ShoppingCartCache>();
            Transactions = new HashSet<Transactions>();
            WhiteLabelHosts = new HashSet<WhiteLabelHosts>();
            WhiteLabelLinks = new HashSet<WhiteLabelLinks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string EmailAddresses { get; set; }
        public int PartnerClientId { get; set; }
        public int? DefaultSalesPersonId { get; set; }
        public string Logo { get; set; }
        public string LogoLight { get; set; }
        public string Favicon { get; set; }

        public ICollection<CommissionGroupAssignments> CommissionGroupAssignments { get; set; }
        public ICollection<CommissionGroups> CommissionGroups { get; set; }
        public ICollection<CommissionSchedules> CommissionSchedules { get; set; }
        public ICollection<ContactPersons> ContactPersons { get; set; }
        public ICollection<CustomFields> CustomFields { get; set; }
        public ICollection<Discounts> Discounts { get; set; }
        public ICollection<FoundInfos> FoundInfos { get; set; }
        public ICollection<Industries> Industries { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Products> Products { get; set; }
        public ICollection<SalesPersons> SalesPersons { get; set; }
        public ICollection<ShoppingCartCache> ShoppingCartCache { get; set; }
        public ICollection<Transactions> Transactions { get; set; }
        public ICollection<WhiteLabelHosts> WhiteLabelHosts { get; set; }
        public ICollection<WhiteLabelLinks> WhiteLabelLinks { get; set; }
    }
}
