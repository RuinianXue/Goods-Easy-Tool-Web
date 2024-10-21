using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int OrderID { get; set; } // 自增主键

    [Required]
    public DateTime OrderTime { get; set; } // 时间，用于24h优先等排序

    [Required]
    public int UserID { get; set; } // 用户ID 唯一值

    [Required]
    public int BatchID { get; set; } // 批次ID 唯一值

    [Required]
    public int TypeID { get; set; } // 类型ID 唯一值

    [Required]
    public int CharacterID { get; set; } // 角色ID 唯一值

    [Required]
    public int OrderAmount { get; set; } // 数量

    [Required]
    [Range(0, 2, ErrorMessage = "Special Status must be between 0 and 2.")]
    [DefaultValue(0)]
    public int SpecialStatus { get; set; } = 0; // 特殊状态：0：无特殊状态, 1：包尾, 2：凹
}