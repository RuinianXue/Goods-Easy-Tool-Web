using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class CharacterPriority
{
    [Key]
    [Required]
    [RegularExpression(@"^[A-Za-z]{2}\d+$", ErrorMessage = "characterID must be a combination of 2 letters followed by numbers.")]
    public string CharacterID { get; set; } // 2字母+数字的组合（方舟）

    [Required]
    [DefaultValue(0)]
    public int PriorityGrade { get; set; } = 0; // 优先级从高到低，最高为管理10

    [Required]
    public int UserID { get; set; } // 用户ID 唯一值

    [Required]
    [Range(0, 100, ErrorMessage = "forcePercent must be between 0 and 100.")]
    [DefaultValue(50)]
    public int ForcePercent { get; set; } = 50; // 百分比
}