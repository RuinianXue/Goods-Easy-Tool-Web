using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GoodsWebApp.Models;


public class GoodsBatch
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(1, int.MaxValue, ErrorMessage = "goodsBatchID must start from 1.")]
    public int GoodsBatchID { get; set; }

    [Required]
    public string GoodsBatchName { get; set; }

    public DateTime GoodsBeginTime { get; set; }

    public DateTime GoodsEndTime { get; set; }

    [Required]
    [Range(0, 3, ErrorMessage = "Delivery Status must be between 0 and 3.")]
    [DefaultValue(0)]
    public int DeliveryStatus { get; set; } = 0; // 0:未成团, 1:待收款, 2:未到货, 3:可发货


    [Required]
    [DefaultValue(1)]
    public float SharedDiscount { get; set; } = 1; // 折扣系数

}
