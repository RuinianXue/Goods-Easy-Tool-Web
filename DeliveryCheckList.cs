using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class DeliveryCheckList
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(1, int.MaxValue, ErrorMessage = "deliveryUniqueID must start from 1.")]
    public int deliveryUniqueID { get; set; }


    [Required]
    public int UserID { get; set; } // 用户ID，外码

    [Required]
    public DateTime DeliveryRequestTime { get; set; }

    [Required]
    public string ListPicURL { get; set; } // 用户截图上传图片的URL

    [Required]
    [Range(0, 2, ErrorMessage = "Delivery Status must be between 0 and 2.")]
    [DefaultValue(0)]
    public int CheckDeliveryStatus { get; set; } = 0; // 发货检查状态：0：未提交, 1：已提交, 2：已审核
}