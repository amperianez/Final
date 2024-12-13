using System.ComponentModel.DataAnnotations;

namespace  Final.Models;

public class Habitat
{
    
    public int HabitatID {get; set;} ///// pk

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string HabitatName {get; set;} = string.Empty;

    [Required]
    [StringLength(500, MinimumLength = 2)]
    public string HabitatDescription {get; set;} = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<MonsterHabitat>? MonsterHabitats {get; set;} = default!; 
}




public class MonsterHabitat
{
    public int HabitatID {get; set;} // fkey 1
    public int MonsterID {get; set;} // fkey 2
    public Monster Monster {get; set;} = default!; 
    public Habitat Habitat {get; set;} = default!; 
}