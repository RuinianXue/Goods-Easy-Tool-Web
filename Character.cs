using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;


public class Character
{
    [Key]
    [Required]
    [RegularExpression(@"^[A-Za-z]{2}\d+$", ErrorMessage = "characterID must be a combination of 2 letters followed by numbers.")]
    public string CharacterID { get; set; } // 2字母+数字的组合（方舟）

    [Range(0, 10, ErrorMessage = "hotPriority must be between 0 and 10.")]
    public int? HotPriority { get; set; } = 0; // 记录热门程度（？）
}