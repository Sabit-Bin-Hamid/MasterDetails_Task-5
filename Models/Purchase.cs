using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetails.Models
{
    public class Purchase
    {
        [Required]
        public long PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }= DateTime.Now;


        
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(8, ErrorMessage = "Supplier Name length can't be more than 50")]
        public string SupplierName { get; set; } = "";

        [StringLength(8, ErrorMessage = "Addresslength can't be more than 500")]
        [Column(TypeName = "nvarchar(500)")]
        public string Address { get; set; } = "";


        [StringLength(8, ErrorMessage = "Entry By can't be more than 50")]
        [Column(TypeName = "nvarchar(50)")]
        public string EntryBy { get; set; } = "";

        public DateTime EntryDate { get; set; }= DateTime.Now;

        [StringLength(8, ErrorMessage = "Remark  can't be more than 50")]
        [Column(TypeName = "nvarchar(800)")]
        public string Remark { get; set; } = "";

        public virtual ICollection<PurchaseDetails> PurchaseDetails { get; set; }    
        
    }
}
