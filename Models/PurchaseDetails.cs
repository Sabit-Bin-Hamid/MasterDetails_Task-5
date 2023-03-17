using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetails.Models
{
    public class PurchaseDetails
    {

        [Required(ErrorMessage = "Required")]
        [Column(TypeName = "nvarchar(50)")]
        public string ItemCode { get; set; } = "";

        [Required(ErrorMessage = "Required")]
        public float ItemQty { get; set; }

        [Required(ErrorMessage = "Required")]
        public float ItemUnitId { get; set; }

        [Required(ErrorMessage = "Required")]
        public float ItemRate { get; set; }

        
        [Required(ErrorMessage = "Required")]
        public int PurchaseId { get; set;}

        [Required]
        public long Id { get; set;}
        public virtual Purchase Purchase { get; set; }
    }
}
