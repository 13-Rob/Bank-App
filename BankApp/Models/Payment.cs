
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Models;

public class Payment {
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public String? Description { get; set; }

    [Display(Name = "Payment Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString ="0:yyyy-MM-dd")]
    public DateTime Date { get; set; }

    [Range(0.01, 1000000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Required]
    public decimal Amount { get; set; }
}