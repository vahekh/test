using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ClientPaymentMethods
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PaymentMethodId { get; set; }
        public int? ContactPersonId { get; set; }
        public int? ContactPersonAddressId { get; set; }
        public DateTimeOffset? ExpirationDate { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public DateTimeOffset? LastValidationDate { get; set; }
        public int? UserId { get; set; }
        public bool IsDefault { get; set; }
        public int? PgclientId { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public int? UserAddressId { get; set; }

        public SystemClients Client { get; set; }
        public UserAddresses UserAddress { get; set; }
    }
}
