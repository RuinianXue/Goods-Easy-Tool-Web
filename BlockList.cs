using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsWebApp.Models;

public class BlockList
{
    [Required]
    [Key]
    public int UserID { get; set; } // 用户ID，外码

    public string DonePicURL { get; set; } // 光荣事迹截图上传图片的URL
}