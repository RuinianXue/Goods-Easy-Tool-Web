using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class Goods
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(0, int.MaxValue, ErrorMessage = "goodsID must start from 1.")]
    public int GoodsID { get; set; }

    [Required]
    public int GoodsTypeID { get; set; } // 名字

    [Required]
    public int GoodsCharacter { get; set; } // 角色

    [Required]
    [DefaultValue(1)]
    public int GoodsCountEqual { get; set; } = 1; // 点数等效

    [Required]
    [DefaultValue(0)]
    public int GoodsBoundEqual { get; set; } = 0; // 捆数等效
}