using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class BatchToType
{
    [Key]
    [Required]
    public int GoodsBatchID { get; set; } // 商品批次ID，外码

    [Required]
    public int GoodsTypeID { get; set; } // 商品类型ID
}