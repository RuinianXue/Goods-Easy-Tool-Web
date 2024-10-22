using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GoodsWebApp.Models;


public class GoodsBatch
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(0, int.MaxValue, ErrorMessage = "goodsBatchID must start from 0.")]
    public int GoodsBatchID { get; set; }

    [Required]
    public string GoodsBatchName { get; set; }

    public DateTime GoodsBeginTime { get; set; }

    public DateTime GoodsEndTime { get; set; }
    /*
    public string GoodsBeginTimeString { get; set; }

    public DateTime GoodsBeginTime
    {
        get => DateTime.Parse(GoodsBeginTimeString);
        set => GoodsBeginTimeString = value.ToString("yyyy-MM-ddTHH:mm:ss");
    }

    public string GoodsEndTimeString { get; set; }

    public DateTime GoodsEndTime
    {
        get => DateTime.Parse(GoodsEndTimeString);
        set => GoodsEndTimeString = value.ToString("yyyy-MM-ddTHH:mm:ss");
    }
    */

    [Required]
    [Range(0, 3, ErrorMessage = "Delivery Status must be between 0 and 3.")]
    [DefaultValue(0)]
    public int DeliveryStatus { get; set; } = 0; // 0:未成团, 1:待收款, 2:未到货, 3:可发货


    [Required]
    [DefaultValue(1)]
    public float SharedDiscount { get; set; } = 1; // 折扣系数

}
