using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class Countermeasure
{
   
    public int CountermeasureID {get; set;} 
    public string TypeAndSubname {get; set;} = string.Empty;


    public List<Monster>? Monsters { get; set; } = new List<Monster>();
   

}

