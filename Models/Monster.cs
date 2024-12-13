using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class Monster
{
   
    public int MonsterID {get; set;} 
    public string MonsterName {get; set;} = string.Empty;
    public string Description {get; set;} = string.Empty;
    public string Species {get; set;} = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;

    
    public List<Countermeasure>? Countermeasures { get; set; } = new List<Countermeasure>();
    public List<MonsterHabitat>? MonsterHabitats {get; set;} = default!; 
    public int WeaknessID { get; set; }
    public Weakness Weakness { get; set; } = default!;
    
    



}

