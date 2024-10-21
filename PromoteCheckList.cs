using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class PromoteCheckList
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(1, int.MaxValue, ErrorMessage = "deliveryUniqueID must start from 1.")]
    public int promoteUniqueID { get; set; }

    [Required]
    public int UserID { get; set; } // 用户ID，外码

    [Required]
    public int BatchID { get; set; } // 批次ID

    [Required]
    public string SharePicURL { get; set; } // 上传图片之后保存的URL

    [Required]
    [Range(0, 2, ErrorMessage = "Promotion Status must be between 0 and 2.")]
    [DefaultValue(0)]
    public int CheckPromoteStatus { get; set; } = 0; // 推广检查状态：0：未提交, 1：已提交, 2：已审核
}