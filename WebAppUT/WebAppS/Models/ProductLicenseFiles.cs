using System;
using System.Collections.Generic;

namespace WebAppS.Models
{
    public partial class ProductLicenseFiles
    {
        public ProductLicenseFiles()
        {
            Products = new HashSet<Products>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileData { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
