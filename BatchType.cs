using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class BatchType
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BatchTypeRelationID { get; set; }

    [Required]
    public int GoodsBatchID { get; set; } // 商品批次ID，外码

    [Required]
    public int GoodsTypeID { get; set; } // 商品类型ID
}