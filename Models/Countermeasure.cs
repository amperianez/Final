using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class Countermeasure
{
   
    public int CountermeasureID {get; set;} 

    [Required]
    [StringLength(50, MinimumLength = 2)]
    public string TypeAndSubname {get; set;} = string.Empty;


    public List<Monster>? Monsters { get; set; } = new List<Monster>();
   

}

