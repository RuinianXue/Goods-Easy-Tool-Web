using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GoodsWebApp.Models;
public class GoodsType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(0, int.MaxValue, ErrorMessage = "goodsTypeID must start from 1.")]
    public int GoodsTypeID { get; set; }

    [Required]
    public string GoodsTypeName { get; set; }

    public int? PriceInTotal { get; set; } // 总价，原价

    public int? LimitAmount { get; set; } // 开的数量（可修改）
}