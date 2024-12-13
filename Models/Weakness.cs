using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class Weakness
{
   
    public int WeaknessID {get; set;} 

    [Required]
    [StringLength(500, MinimumLength = 2)]
    public string WeaknessDescription {get; set;} = string.Empty;

    //
    
    public Monster Monster { get; set; } = default!;
}

