using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetails.Models
{
    public class PurchaseDetails
    {

       
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Item Code can't be more than 500")]
        public string ItemCode { get; set; } = "";

        
        public float ItemQty { get; set; }

        
        public float ItemUnitId { get; set; }

        
        public float ItemRate { get; set; }

        
        [Required(ErrorMessage = "Required")]
        public int PurchaseId { get; set;}

        [Required]
        public long Id { get; set;}
        public virtual Purchase Purchase { get; set; }
    }
}
