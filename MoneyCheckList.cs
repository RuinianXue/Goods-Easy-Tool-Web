using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class MoneyCheckList
{

    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(0, int.MaxValue, ErrorMessage = "deliveryUniqueID must start from 0.")]
    public int moneyUniqueID { get; set; }
    [Required]
    public int UserID { get; set; } // 用户ID，外码

    [Required]
    public int BatchID { get; set; } // 批次ID

    [Required]
    public string PayPicURL { get; set; } // 上传图片之后保存的URL

    [Required]
    [Range(0, 2, ErrorMessage = "Money Status must be between 0 and .")]
    [DefaultValue(0)]
    public int CheckMoneyStatus { get; set; } = 0; // 检查金钱状态：0：未提交, 1：已提交, 2：已审核
}