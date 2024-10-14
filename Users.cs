using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GoodsWebApp.Models;

public class Users
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Range(100, int.MaxValue, ErrorMessage = "User ID must start from 100 for users.")]
    public int UserID { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "CN must be 20 characters or less.")]
    public string CN { get; set; }

    [Required]
    [StringLength(50, ErrorMessage = "Password must be 50 characters or less.")]
    public string Password { get; set; }

    [Required]
    public string QQ { get; set; }

    [DefaultValue(0)]
    [Range(0, 10, ErrorMessage = "Authority must be between 0 and 10.")]
    public int Authority { get; set; } = 0; // Assuming default value is set to 0 for normal users.
}
