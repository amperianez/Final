using Microsoft.EntityFrameworkCore;

namespace Final.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Monsters!.Any() || context.Weaknesses!.Any())
        {
            return;
        }


    List<Weakness> weaknesses = new List<Weakness>
    {
        new Weakness { WeaknessID = 1, WeaknessDescription = "Fire and Dimeritium bombs disrupt its connection to nature, reducing its ability to summon wolves and ravens. Its bark-like armor is resistant to ordinary attacks but vulnerable to prolonged burning and magical interference." },
        new Weakness { WeaknessID = 2, WeaknessDescription = "Bright light disorients its hypnotic third eye, causing temporary blindness and disrupting its psychic attacks. Its large frame makes it vulnerable to precise strikes on its vital organs." },
        new Weakness { WeaknessID = 3, WeaknessDescription = "Their glossy exoskeletons, while tough, are flammable and susceptible to cracks under high-impact strikes. Colonies are easily disoriented by fire or loud explosions." },
        new Weakness { WeaknessID = 4, WeaknessDescription = "The bulbous abdomen is a soft spot, prone to piercing attacks. Fire and silver are particularly effective, disrupting its venom production and nest defense." },
        new Weakness { WeaknessID = 5, WeaknessDescription = "Its regenerative abilities are severely hindered by cursed oil and moon dust bombs, which disrupt the magic sustaining its transformation. Prolonged combat exhausts its stamina." },
        new Weakness { WeaknessID = 6, WeaknessDescription = "Its leathery skin is resistant to blunt force but tears under slashing strikes. Vulnerable to fire, which desiccates its body, and necrophage oil which amplifies silver blade effectiveness." },
        new Weakness { WeaknessID = 7, WeaknessDescription = "Their slick skin provides underwater camouflage but is easily torn by silver blades. They are disoriented by sudden bursts of light or fire near the surface." },
        new Weakness { WeaknessID = 8, WeaknessDescription = "Its half-formed body is unstable and highly sensitive to Yrden traps, which force it to materialize fully. Prolonged exposure to light or fire damages its spectral essence." },
        new Weakness { WeaknessID = 9, WeaknessDescription = "The gases within its bloated body ignite explosively, making it vulnerable to fire. Silver blades coated with necrophage oil can sever its limbs, reducing its mobility." },
        new Weakness { WeaknessID = 10, WeaknessDescription = "Its skeletal frame is brittle under heavy strikes, while fire and silver disrupt its dark magic. Its claws are slow but deadly, leaving it open after swings." },
        new Weakness { WeaknessID = 11, WeaknessDescription = "Its wing membranes are fragile and easily torn by crossbow bolts. Aard signs can stagger it on the ground, exposing its underside." },
        new Weakness { WeaknessID = 12, WeaknessDescription = "The frost covering its body can be melted with fire, weakening its armor. Its slow movements leave it vulnerable to agile opponents." },
        new Weakness { WeaknessID = 13, WeaknessDescription = "Their hollow bones make them fragile despite their agility. Aard signs can disrupt their flight patterns, making them easy targets." },
        new Weakness { WeaknessID = 14, WeaknessDescription = "Its single eye is a glaring weak spot. Blunt trauma to its legs can cripple its mobility, reducing its combat effectiveness." },
        new Weakness { WeaknessID = 15, WeaknessDescription = "Its wing joints are vulnerable to precise strikes. Draconid oil exacerbates wounds, and crossbow bolts can bring it down mid-flight." },
        new Weakness { WeaknessID = 16, WeaknessDescription = "Its shadowy form is disrupted by fire and vampire oil. Exposure to sunlight weakens its magical defenses." },
        new Weakness { WeaknessID = 17, WeaknessDescription = "Its magically bound structure is disrupted by Dimeritium, which nullifies enchantments. Heavy strikes to its joints weaken its form." },
        new Weakness { WeaknessID = 18, WeaknessDescription = "Yrden traps force it to take physical form, and silver blades disrupt its spectral essence. Its hatred makes it predictable in combat." },
        new Weakness { WeaknessID = 19, WeaknessDescription = "Explosives shatter its stone armor, and its sluggish movements make it vulnerable to faster opponents. Weak spots appear at its joints." },
        new Weakness { WeaknessID = 20, WeaknessDescription = "Fire burns through its sinewy flesh, while vampire oil disrupts its regeneration. Silver causes extreme pain, limiting its movements." },
        new Weakness { WeaknessID = 21, WeaknessDescription = "Their small size and swarming behavior make them vulnerable to area-of-effect attacks. Silver blades can sever their limbs easily." },
        new Weakness { WeaknessID = 22, WeaknessDescription = "Its cursed origin makes it vulnerable to Axii signs and cursed oil. Its wails disrupt concentration, requiring magical protection." },
        new Weakness { WeaknessID = 23, WeaknessDescription = "Its thick hide can be penetrated by cursed oil and fire. Its enraged state makes it predictable, though highly dangerous." },
        new Weakness { WeaknessID = 24, WeaknessDescription = "Its spiked hide ignites easily, and silver blades sever its feeding tendrils, preventing regeneration." },
        new Weakness { WeaknessID = 25, WeaknessDescription = "Its venom sacs are prone to rupture, and its flight patterns are disrupted by crossbow bolts. Draconid oil amplifies damage." },
        new Weakness { WeaknessID = 26, WeaknessDescription = "Its spectral form is weakened by Yrden traps and holy artifacts. Its foggy shroud dissipates under bright light." },
        new Weakness { WeaknessID = 27, WeaknessDescription = "During transformation, its body is unstable and vulnerable to silver. Its mimicry falters under intense scrutiny." },
        new Weakness { WeaknessID = 28, WeaknessDescription = "Its hold on its host is disrupted by fire and magic traps. Reflections reveal its true form, breaking its illusions." },
        new Weakness { WeaknessID = 29, WeaknessDescription = "Their feral nature makes them predictable, and silver blades disrupt their feeding frenzy. Necrophage oil enhances damage." },
        new Weakness { WeaknessID = 30, WeaknessDescription = "Holy artifacts disrupt its aura of disease, and silver blades sever its spectral connection. Its presence weakens in direct sunlight." },
        new Weakness { WeaknessID = 31, WeaknessDescription = "Their shimmering forms are bound to sunlight, making them vulnerable to Yrden traps and specter oil. Loud noises disorient them." },
        new Weakness { WeaknessID = 32, WeaknessDescription = "The curse tying it to its monstrous form weakens under prolonged exposure to silver. Magic signs can disrupt its feral focus." }
    };

        context.AddRange(weaknesses);
        context.SaveChanges();
   



    List<Countermeasure> countermeasures = new List<Countermeasure>
    {
        new Countermeasure { CountermeasureID = 1, TypeAndSubname = "Bomb : Dancing Star" },
        new Countermeasure { CountermeasureID = 2, TypeAndSubname = "Bomb : Samum" },
        new Countermeasure { CountermeasureID = 3, TypeAndSubname = "Bomb : Moon Dust" },
        new Countermeasure { CountermeasureID = 4, TypeAndSubname = "Bomb : Dimeritium" },
        new Countermeasure { CountermeasureID = 5, TypeAndSubname = "Bomb : Cluster Bombs" },
        new Countermeasure { CountermeasureID = 6, TypeAndSubname = "Weapon : Silver Sword" },
        new Countermeasure { CountermeasureID = 7, TypeAndSubname = "Weapon : Blunt Weapons" },
        new Countermeasure { CountermeasureID = 8, TypeAndSubname = "Weapon : Crossbow" },
        new Countermeasure { CountermeasureID = 9, TypeAndSubname = "Oil : Relict Oil" },
        new Countermeasure { CountermeasureID = 10, TypeAndSubname = "Oil : Insectoid Oil" },
        new Countermeasure { CountermeasureID = 11, TypeAndSubname = "Oil : Necrophage Oil" },
        new Countermeasure { CountermeasureID = 12, TypeAndSubname = "Oil : Vampire Oil" },
        new Countermeasure { CountermeasureID = 13, TypeAndSubname = "Oil : Cursed Oil" },
        new Countermeasure { CountermeasureID = 14, TypeAndSubname = "Oil : Draconid Oil" },
        new Countermeasure { CountermeasureID = 15, TypeAndSubname = "Oil : Specter Oil" },
        new Countermeasure { CountermeasureID = 16, TypeAndSubname = "Sign : Igni" },
        new Countermeasure { CountermeasureID = 17, TypeAndSubname = "Sign : Yrden" },
        new Countermeasure { CountermeasureID = 18, TypeAndSubname = "Sign : Aard" },
        new Countermeasure { CountermeasureID = 19, TypeAndSubname = "Sign : Axii" },
        new Countermeasure { CountermeasureID = 20, TypeAndSubname = "Sign : Quen" }
    };

    context.AddRange(countermeasures);
    context.SaveChanges();        

       

    List<Habitat> habitats = new List<Habitat>
    {
        new Habitat { HabitatID = 1, HabitatName = "Forests", HabitatDescription = "Densely packed trees with thick canopies that limit sunlight. The ground is covered in damp soil and moss, with the sounds of wildlife and rustling leaves creating a constant background.", ImageUrl = "/img/Forest.png"},
        new Habitat { HabitatID = 2, HabitatName = "Swamps", HabitatDescription = "Stagnant pools of water interspersed with twisted tree roots and reeds. The air is humid and smells of decay, with muddy ground that makes movement difficult.", ImageUrl = "/img/Swamp.png"},
        new Habitat { HabitatID = 3, HabitatName = "Mountains", HabitatDescription = "Steep, jagged peaks covered in snow and ice. The area is dominated by strong winds and low temperatures, with sparse vegetation and rocky terrain.", ImageUrl = "/img/Mountains.png"},
        new Habitat { HabitatID = 4, HabitatName = "Caves and Ruins", HabitatDescription = "Dark, enclosed spaces with stone walls and uneven floors. Often filled with debris or ancient remnants, these areas are damp, cold, and poorly lit.", ImageUrl = "/img/Ruins.png" },
        new Habitat { HabitatID = 5, HabitatName = "Fields and Plains", HabitatDescription = "Flat or gently rolling terrain covered with grass and scattered wildflowers. The open landscape offers clear visibility, but few places for shelter.", ImageUrl = "/img/Fields.png" },
        new Habitat { HabitatID = 6, HabitatName = "Cities and Towns", HabitatDescription = "Urban environments with a mix of crowded streets and secluded alleys. Buildings vary in size and function, with noise and activity concentrated in marketplaces or residential areas.", ImageUrl = "/img/Cities.png" },
        new Habitat { HabitatID = 7, HabitatName = "Settlements and Villages", HabitatDescription = "Small, tightly packed homes surrounded by farmland. The environment is quiet, with simple infrastructure and a focus on agricultural activity", ImageUrl = "/img/Settlement.png" }
    };

    context.AddRange(habitats);
    context.SaveChanges();

    ////////////////////////
    
    List<Monster> monsters = new List<Monster>
    {

        new Monster
        {
            MonsterID = 1,
            MonsterName = "Leshen",
            WeaknessID = 1,
            Description = "Towering entities of twisted bark and root, Leshens are ancient guardians of forests. They stand like dark effigies, their antlered heads adorned with skulls and vines. Preferring large game such as deer and wild boar, they are territorial and unyielding, unleashing flocks of ravens and packs of wolves to eliminate threats. Danger level: Very High.",
            Species = "Relict",
            ImageUrl = "/img/leshen.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 4), // Bomb: Dimeritium
                context.Countermeasures!.First(c => c.CountermeasureID == 9), // Oil: Relict Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },

        new Monster
        {
            MonsterID = 2,
            MonsterName = "Fiend",
            WeaknessID = 2,
            Description = "Massive, horned beasts covered in coarse fur, Fiends are territorial Relicts with a faintly glowing third eye that enables hypnotic stares, disorienting prey. While they share similarities with Chorts in their hulking, horned appearance and behavior, Fiends are more elusive, often residing in dense forests. Danger level: Very High.",
            Species = "Relict",
            ImageUrl = "/img/Fiend.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 2), // Bomb: Samum
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 9), // Oil: Relict Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },

        new Monster
        {
            MonsterID = 3,
            MonsterName = "Endrega",
            WeaknessID = 3,
            Description = "Sleek, armored predators resembling oversized ants or arachnids. They travel in colonies, their glossy exoskeletons gleaming in filtered light. Preying on smaller creatures and stray travelers, they overwhelm with numbers and precision. Danger level: High.",
            Species = "Insectoid",
            ImageUrl = "/img/EndregaWarrior.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 5), // Bomb: Area-of-Effect Bombs
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 10), // Oil: Insectoid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },

        new Monster
        {
            MonsterID = 4,
            MonsterName = "Arachas Queen",
            WeaknessID = 4,
            Description = "Gigantic spider-like creatures with bulbous bodies covered in spines. Their venomous bite paralyzes prey, which they drag back to their nests. They favor deer, livestock, and careless wanderers. Danger level: High.",
            Species = "Insectoid",
            ImageUrl = "/img/ArachasQueen.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 10), // Oil: Insectoid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },

        new Monster
        {
            MonsterID = 5,
            MonsterName = "Werewolf",
            WeaknessID = 5,
            Description = "Humans cursed to transform into wolves, their forms blending the savagery of beast and man. With sinewy muscles and glowing eyes, they hunt livestock, travelers, and sometimes their own kin. Danger level: Very High.",
            Species = "Cursed",
            ImageUrl = "/img/Werewolf.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 13), // Oil: Cursed Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 19) // Sign: Axii
            }
        },

        new Monster
        {
            MonsterID = 6,
            MonsterName = "Water Hag",
            WeaknessID = 6,
            Description = "Grotesque, hunched Necrophages with leathery skin, Water Hags lurk in swamps and shallow waters. They share similarities with Grave Hags, particularly in their decayed, humanoid forms and preference for ambushing prey. Water Hags are adept at using mud and water to disorient victims, often relying on their swampy environment for camouflage. Danger level: High.",
            Species = "Necrophage",
            ImageUrl = "/img/WaterHag.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16), // Sign: Igni
                context.Countermeasures!.First(c => c.CountermeasureID == 17) // Sign: Yrden
            }
        },

        new Monster
        {
            MonsterID = 7,
            MonsterName = "Drowner",
            WeaknessID = 7,
            Description = "Slick, blue-skinned creatures with bulbous eyes and webbed claws. Drowners hunt in packs, dragging their victims into the water to drown before devouring them. Danger level: Moderate.",
            Species = "Necrophage",
            ImageUrl = "/img/Drowner.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 2), // Bomb: Samum
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16), // Sign: Igni
                context.Countermeasures!.First(c => c.CountermeasureID == 17) // Sign: Yrden
            }
        },
        new Monster
        {
            MonsterID = 8,
            MonsterName = "Foglet",
            WeaknessID = 8,
            Description = "Mist-like creatures, their half-formed bodies flickering in and out of visibility. Foglets create dense fog to disorient prey before attacking with sharp claws. They favor lone travelers. Danger level: High.",
            Species = "Necrophage",
            ImageUrl = "/img/Foglet.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 17) // Sign: Yrden
            }
        },
        new Monster
        {
            MonsterID = 9,
            MonsterName = "Rotfiend",
            WeaknessID = 9,
            Description = "Bloated, rotting corpses reanimated by dark magic. They explode upon death, releasing noxious fumes. Rotfiends feed on carrion and the living alike. Danger level: Moderate.",
            Species = "Necrophage",
            ImageUrl = "/img/Rotfiend.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },
        new Monster
        {
            MonsterID = 10,
            MonsterName = "Grave Hag",
            WeaknessID = 10,
            Description = "Shriveled and skeletal Necrophages, Grave Hags resemble their Water Hag cousins in their macabre appearance and predatory instincts. However, they primarily haunt graveyards and burial sites, feasting on the dead and attacking the living with curses and claws. Danger level: High.",
            Species = "Necrophage",
            ImageUrl = "/img/GraveHag.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 1), // Bomb: Dancing Star
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16), // Sign: Igni
                context.Countermeasures!.First(c => c.CountermeasureID == 20) // Sign: Quen
            }
        },
        new Monster
        {
            MonsterID = 11,
            MonsterName = "Griffin",
            WeaknessID = 11,
            Description = "Regal predators with the body of a lion and the head and wings of an eagle. Griffins hunt livestock, large game, and the occasional human. Danger level: Very High.",
            Species = "Hybrid",
            ImageUrl = "/img/Griffin.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 8), // Weapon: Crossbow
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 14), // Oil: Draconid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 12,
            MonsterName = "Ice Giant",
            WeaknessID = 12,
            Description = "Colossal and imposing, Ice Giants are humanoid figures covered in frost and ice. They crush anything that crosses their path. Danger level: Very High.",
            Species = "Ogre",
            ImageUrl = "/img/IceGiant.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 16), // Sign: Igni
                context.Countermeasures!.First(c => c.CountermeasureID == 19),
                context.Countermeasures!.First(c => c.CountermeasureID == 20) 
            }
        },
        new Monster
        {
            MonsterID = 13,
            MonsterName = "Harpy",
            WeaknessID = 13,
            Description = "Winged scavengers with leathery skin and talons like knives. They prey on small livestock and lone travelers. Danger level: Moderate.",
            Species = "Hybrid",
            ImageUrl = "/img/Harpy.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 8), // Weapon: Crossbow
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 14), // Oil: Draconid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 14,
            MonsterName = "Cyclops",
            WeaknessID = 14,
            Description = "Massive, one-eyed brutes with thick hides and unmatched strength. Cyclopes crush their prey with boulders or bare hands. Danger level: High.",
            Species = "Ogre",
            ImageUrl = "/img/Cyclops.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 7), // Weapon: Blunt Weapons
                context.Countermeasures!.First(c => c.CountermeasureID == 19), // Sign: Axii
                context.Countermeasures!.First(c => c.CountermeasureID == 20) // Sign: Axii
            }
        },
        new Monster
        {
            MonsterID = 15,
            MonsterName = "Wyvern",
            WeaknessID = 15,
            Description = "Large winged reptiles with piercing maw and talons. Wyverns hunt any living creature within their territory. Danger level: Very High.",
            Species = "Draconid",
            ImageUrl = "/img/Wyvern.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 8), // Weapon: Crossbow
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 14), // Oil: Draconid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },

        new Monster
        {
            MonsterID = 16,
            MonsterName = "Katakan",
            WeaknessID = 16,
            Description = "Silent and shadowy higher vampires, Katakans prowl urban environments, preying on humans under the cover of night. Sharing vampiric traits with Ekimmaras, Katakans are more cunning and adept at stealth, often turning invisible to evade or ambush. Danger level: High.",
            Species = "Vampire",
            ImageUrl = "/img/Katakan.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 12), // Oil: Vampire Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },
        new Monster
        {
            MonsterID = 17,
            MonsterName = "Golem",
            WeaknessID = 17,
            Description = "Enormous, hulking masses of stone imbued with magic. Golems serve as guardians, utterly loyal to their creators. Their slow but devastating blows can crush bone and steel alike. Danger level: High.",
            Species = "Construct",
            ImageUrl = "/img/Golem.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 4), // Bomb: Dimeritium
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 18,
            MonsterName = "Night Wraith",
            WeaknessID = 18,
            Description = "Ethereal remnants of souls bound to the world by hatred or sorrow. Wraiths are insubstantial yet lethal, slashing at their victims with spectral blades. Danger level: Moderate.",
            Species = "Specter",
            ImageUrl = "/img/Nightwraith.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 15), // Oil: Specter Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 17) // Sign: Yrden
            }
        },
        new Monster
        {
            MonsterID = 19,
            MonsterName = "Gargoyle",
            WeaknessID = 19,
            Description = "Grotesque creatures carved of stone, Gargoyles animate to defend their ancient lairs. Their heavy, jagged bodies can smash through walls, and their stone skin is almost impervious to harm. Danger level: High.",
            Species = "Construct",
            ImageUrl = "/img/Gargoyle.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 4), // Bomb: Dimeritium
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 8), // Weapon: Crossbow
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 20,
            MonsterName = "Ekimmara",
            WeaknessID = 20,
            Description = "Feral and bloodthirsty predators, Ekimmaras are sinewy vampires driven by their insatiable hunger for blood. Similar to Katakans in their bat-like features, they differ in behavior, as they are more primal and less reliant on stealth. Found in rural areas such as forests and caves, they pose a constant threat to travelers. Danger level: High.",
            Species = "Vampire",
            ImageUrl = "/img/Ekimmara.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 12), // Oil: Vampire Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },
        new Monster
        {
            MonsterID = 21,
            MonsterName = "Nekker",
            WeaknessID = 21,
            Description = "Small, goblin-like creatures with wiry builds and sharp claws. Nekkars attack in swarms, overwhelming larger creatures with sheer numbers. Danger level: Moderate.",
            Species = "Necrophage",
            ImageUrl = "/img/Nekker.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 5), // Bomb: Area-of-Effect Bombs
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 22,
            MonsterName = "Botchling",
            WeaknessID = 22,
            Description = "Twisted, infant-like creatures born of cursed, unwanted pregnancies. Their misshapen bodies emit a chilling wail, and they easily rend flesh with unnatural strength. Danger level: High.",
            Species = "Cursed",
            ImageUrl = "/img/Botchling.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 13), // Oil: Cursed Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 19) // Sign: Axii
            }
        },
        new Monster
        {
            MonsterID = 23,
            MonsterName = "Chort",
            WeaknessID = 23,
            Description = "Hulking creatures with a muscular, horned frame, Chorts resemble Fiends in their appearance and aggressive nature. However, they are less cunning, relying on brute strength over hypnotic abilities. Often found in caves and secluded areas, Chorts are highly territorial. Danger level: Very High.",
            Species = "Relict",
            ImageUrl = "/img/Chort.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 4), // Bomb: Dimeritium
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 9), // Oil: Relict Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },
        new Monster
        {
            MonsterID = 24,
            MonsterName = "Alghoul",
            WeaknessID = 24,
            Description = "Larger, more aggressive variants of ghouls, Alghouls possess spiked hides and a feral hunger for flesh. They scavenge battlefields but will defend their feeding grounds viciously. Danger level: High.",
            Species = "Necrophage",
            ImageUrl = "/img/Alghoul.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },

            new Monster
        {
            MonsterID = 25,
            MonsterName = "Cockatrice",
            WeaknessID = 25,
            Description = "A deadly hybrid of rooster and lizard, Cockatrices are winged beasts with barbed tails and razor-sharp beaks. They attack livestock and lone travelers, using their speed and venom to great effect. Danger level: High.",
            Species = "Draconid",
            ImageUrl = "/img/Cockatrice.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 8), // Weapon: Crossbow
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 14), // Oil: Draconid Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 18) // Sign: Aard
            }
        },
        new Monster
        {
            MonsterID = 26,
            MonsterName = "Penitent",
            WeaknessID = 26,
            Description = "Haunting the forgotten corners of cities, these spectral beings cling to places of sorrow and tragedy. Their translucent forms shimmer in dim light, and their touch brings icy death shrouded in fog. Danger level: High.",
            Species = "Specter",
            ImageUrl = "/img/Penitent.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 15), // Oil: Specter Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 17),
                context.Countermeasures!.First(c => c.CountermeasureID == 20) // Sign: Yrden
            }
        },
        new Monster
        {
            MonsterID = 27,
            MonsterName = "Doppler",
            WeaknessID = 27,
            Description = "Chameleonic beings hiding in plain sight, Dopplers mimic their surroundings with eerie perfection. They use their mimicry for survival, often causing chaos when impersonating others. Danger level: Low.",
            Species = "Relict",
            ImageUrl = "/img/Doppler.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 19) // Sign: Axii
            }
        },
        new Monster
        {
            MonsterID = 28,
            MonsterName = "Hym",
            WeaknessID = 28,
            Description = "Manifestations of guilt and torment, Hym feed on the insecurities of their chosen hosts. They are invisible to most, appearing only in mirrors or shadows. Danger level: Very High.",
            Species = "Specter",
            ImageUrl = "/img/Hym.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 4), // Bomb: Dimeritium
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 15), // Oil: Specter Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 17), // Sign: Yrden
                context.Countermeasures!.First(c => c.CountermeasureID == 19) // Sign: Axii
            }
        },
        new Monster
        {
            MonsterID = 29,
            MonsterName = "Ghoul",
            WeaknessID = 29,
            Description = "Feeding on the corpses of the fallen, Ghouls occasionally infest the darker corners of urban sprawl. Their hunched forms and sharp teeth make them efficient scavengers. Danger level: Moderate.",
            Species = "Necrophage",
            ImageUrl = "/img/Ghoul.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 11), // Oil: Necrophage Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        },
        new Monster
        {
            MonsterID = 30,
            MonsterName = "Plague Maiden",
            WeaknessID = 30,
            Description = "Ghostly remnants of plague victims, their translucent forms glide silently, spreading disease and despair. Their mere presence invites sickness. Danger level: High.",
            Species = "Specter",
            ImageUrl = "/img/PlagueMaiden.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 15), // Oil: Specter Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 20) // Sign: Quen
            }
        },
        new Monster
        {
            MonsterID = 31,
            MonsterName = "Noonwraith",
            WeaknessID = 31,
            Description = "Bound to the sunlit fields of villages, these spectral women wail for their lost lives. Their pale forms shimmer in sunlight, and their touch burns with unearthly energy. Danger level: Moderate.",
            Species = "Specter",
            ImageUrl = "/img/Noonwraith.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 15), // Oil: Specter Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 17) // Sign: Yrden
            }
        },
        new Monster
        {
            MonsterID = 32,
            MonsterName = "Striga",
            WeaknessID = 32,
            Description = "Humans twisted into monstrous forms by ancient curses, Strigas are creatures of relentless rage. Their clawed hands and grotesque faces strike terror into those who behold them. Danger level: Very High.",
            Species = "Cursed",
            ImageUrl = "/img/Striga.png",
            Countermeasures = new List<Countermeasure>
            {
                context.Countermeasures!.First(c => c.CountermeasureID == 3), // Bomb: Moon Dust
                context.Countermeasures!.First(c => c.CountermeasureID == 6), // Weapon: Silver Sword
                context.Countermeasures!.First(c => c.CountermeasureID == 13), // Oil: Cursed Oil
                context.Countermeasures!.First(c => c.CountermeasureID == 16) // Sign: Igni
            }
        }


    };

    context.AddRange(monsters);
    context.SaveChanges();

    /////////////// 


    List<MonsterHabitat> monsterHabitats = new List<MonsterHabitat>
    {
        // Forests
        new MonsterHabitat { MonsterID = 1, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 2, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 3, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 4, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 5, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 20, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 21, HabitatID = 1 },
        new MonsterHabitat { MonsterID = 23, HabitatID = 1 },

        // Swamps
        new MonsterHabitat { MonsterID = 6, HabitatID = 2 },
        new MonsterHabitat { MonsterID = 7, HabitatID = 2 },
        new MonsterHabitat { MonsterID = 8, HabitatID = 2 },
        new MonsterHabitat { MonsterID = 9, HabitatID = 2 },
        new MonsterHabitat { MonsterID = 10, HabitatID = 2 },

        // Mountains
        new MonsterHabitat { MonsterID = 11, HabitatID = 3 },
        new MonsterHabitat { MonsterID = 12, HabitatID = 3 },
        new MonsterHabitat { MonsterID = 13, HabitatID = 3 },
        new MonsterHabitat { MonsterID = 14, HabitatID = 3 },
        new MonsterHabitat { MonsterID = 15, HabitatID = 3 },

        // Caves and Ruins
        new MonsterHabitat { MonsterID = 8, HabitatID = 4 },
        new MonsterHabitat { MonsterID = 16, HabitatID = 4 },
        new MonsterHabitat { MonsterID = 17, HabitatID = 4 },
        new MonsterHabitat { MonsterID = 19, HabitatID = 4 },
        new MonsterHabitat { MonsterID = 20, HabitatID = 4 },
        new MonsterHabitat { MonsterID = 23, HabitatID = 4 },

        // Fields and Plains
        new MonsterHabitat { MonsterID = 11, HabitatID = 5 },
        new MonsterHabitat { MonsterID = 21, HabitatID = 5 },
        new MonsterHabitat { MonsterID = 23, HabitatID = 5 },
        new MonsterHabitat { MonsterID = 24, HabitatID = 5 },
        new MonsterHabitat { MonsterID = 25, HabitatID = 5 },

        // Cities and Towns
        new MonsterHabitat { MonsterID = 26, HabitatID = 6 },
        new MonsterHabitat { MonsterID = 16, HabitatID = 6 }, 
        new MonsterHabitat { MonsterID = 7,  HabitatID = 6 },
        new MonsterHabitat { MonsterID = 27, HabitatID = 6 },
        new MonsterHabitat { MonsterID = 28, HabitatID = 6 },
        new MonsterHabitat { MonsterID = 29, HabitatID = 6 },

        // Settlements and Villages
        new MonsterHabitat { MonsterID = 18, HabitatID = 7 }, 
        new MonsterHabitat { MonsterID = 22, HabitatID = 7 }, 
        new MonsterHabitat { MonsterID = 30, HabitatID = 7 },
        new MonsterHabitat { MonsterID = 31, HabitatID = 7 },
        new MonsterHabitat { MonsterID = 32, HabitatID = 7 },
        new MonsterHabitat { MonsterID = 15, HabitatID = 7 }  
    };

    context.AddRange(monsterHabitats);
    context.SaveChanges();



    }
}
