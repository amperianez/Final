using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class Weakness
{
   
    public int WeaknessID {get; set;} 

    public string WeaknessDescription {get; set;} = string.Empty;

    //
    
    public Monster Monster { get; set; } = default!;
}

