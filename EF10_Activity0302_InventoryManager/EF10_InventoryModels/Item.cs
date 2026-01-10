using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EF10_InventoryModels;

public class Item
{
    public int Id {get; set;}

    [Required]
    [StringLength(100)]
    public string Name {get; set;}

    [Required]
    [DefaultValue(true)]
    public bool IsActive {get; set;}
}
