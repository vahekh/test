using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class Products
    {
        public Products()
        {
            ClientProducts = new HashSet<ClientProducts>();
            ContactInfos = new HashSet<ContactInfos>();
            DiscountProducts = new HashSet<DiscountProducts>();
            OrderProducts = new HashSet<OrderProducts>();
            ProductActions = new HashSet<ProductActions>();
            ProductBlockPrices = new HashSet<ProductBlockPrices>();
            ProductIndustries = new HashSet<ProductIndustries>();
            ProductOptions = new HashSet<ProductOptions>();
            ProductTrainings = new HashSet<ProductTrainings>();
            ShoppingCartCache = new HashSet<ShoppingCartCache>();
        }

        public int Id { get; set; }
        public int WhiteLabelId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ShortDetails { get; set; }
        public string EmbedCode { get; set; }
        public byte[] Image { get; set; }
        public string ExpediteEmails { get; set; }
        public decimal? ExpeditePrice { get; set; }
        public bool IsActive { get; set; }
        public bool IsCreateClient { get; set; }
        public int LicenseType { get; set; }
        public int AccessMonths { get; set; }
        public decimal? SetUpFee { get; set; }
        public int? LicenseFileId { get; set; }
        public decimal? RenewalPrice { get; set; }
        public int NumPaymentsAllowed { get; set; }
        public int? RelatedProductId { get; set; }
        public int PaymentType { get; set; }
        public int? ClientId { get; set; }
        public int? FeatureId { get; set; }
        public int? GroupId { get; set; }
        public int? ReplacementId { get; set; }
        public bool RequestPrimaryContact { get; set; }
        public bool AutoRenew { get; set; }
        public string DemoLink { get; set; }
        public string Urlname { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public int? ProductGroupId { get; set; }
        public bool? ShowAsProduct { get; set; }
        public bool IsPhysical { get; set; }
        public string BlobName { get; set; }
        public int? TemplatePriority { get; set; }
        public bool RequiredVariationSelection { get; set; }
        public int? VariationId { get; set; }
        public int? FreeTrialPeriod { get; set; }

        public CommissionGroups Group { get; set; }
        public ProductLicenseFiles LicenseFile { get; set; }
        public WhiteLabels WhiteLabel { get; set; }
        public ICollection<ClientProducts> ClientProducts { get; set; }
        public ICollection<ContactInfos> ContactInfos { get; set; }
        public ICollection<DiscountProducts> DiscountProducts { get; set; }
        public ICollection<OrderProducts> OrderProducts { get; set; }
        public ICollection<ProductActions> ProductActions { get; set; }
        public ICollection<ProductBlockPrices> ProductBlockPrices { get; set; }
        public ICollection<ProductIndustries> ProductIndustries { get; set; }
        public ICollection<ProductOptions> ProductOptions { get; set; }
        public ICollection<ProductTrainings> ProductTrainings { get; set; }
        public ICollection<ShoppingCartCache> ShoppingCartCache { get; set; }
    }
}
