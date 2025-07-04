using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public class BreedingCave
    {
        public Dragon Dragon1 { get; set; }
        public Dragon Dragon2 { get; set; }
        public static Dictionary<string, string> Opposites = new()
        {
            ["Earth"] = "Metal",
            ["Water"] = "Dark",
            ["Fire"] = "Ice",
            ["Nature"] = "Electric"
        };

        public static Dictionary<string, Dictionary<string, string>> RegularBreedingTable = new()
        {
            ["Earth"] =
            {
                ["Earth"] = "Earth",
                ["Fire"] = "Flaming Rock",
                ["Water"] = "Waterfall",
                ["Nature"] = "Tropical",
                ["Electric"] = "Star",
                ["Ice"] = "Snowflake",
                ["Metal"] = "Armadillo",
                ["Dark"] = "Hedgehog",
                ["Pure"] = "Pure Earth"
            },
            ["Fire"] =
            {
                ["Earth"] = "Volcano",
                ["Fire"] = "Fire",
                ["Water"] = "Cloud",
                ["Nature"] = "Firebird",
                ["Electric"] = "Hot Metal",
                ["Ice"] = "Cool Fire",
                ["Metal"] = "Medieval",
                ["Dark"] = "Vampire",
                ["Pure"] = "Pure Fire"
            },
            ["Water"] =
            {
                ["Earth"] = "Mud",
                ["Fire"] = "Blizzard",
                ["Water"] = "Water",
                ["Nature"] = "Nenufar",
                ["Electric"] = "Storm",
                ["Ice"] = "Ice Cube",
                ["Metal"] = "Seashell",
                ["Dark"] = "Petroleum",
                ["Pure"] = "Pure Water"
            },
            ["Nature"] =
            {
                ["Earth"] = "Cactus",
                ["Fire"] = "Spicy",
                ["Water"] = "Coral",
                ["Nature"] = "Nature",
                ["Electric"] = "Gummy",
                ["Ice"] = "Dandelion",
                ["Metal"] = "Dragonfly",
                ["Dark"] = "Carnivore Plant",
                ["Pure"] = "Pure Nature"
            },
            ["Electric"] =
            {
                ["Earth"] = "Chameleon",
                ["Fire"] = "Laser",
                ["Water"] = "Lantern Fish",
                ["Nature"] = "Gummy",
                ["Electric"] = "Electric",
                ["Ice"] = "Fluorescent",
                ["Metal"] = "Battery",
                ["Dark"] = "Neon",
                ["Pure"] = "Pure Electric"
            },
            ["Ice"] =
            {
                ["Earth"] = "Alpine",
                ["Fire"] = "Soccer",
                ["Water"] = "Ice Cream",
                ["Nature"] = "Mojito",
                ["Electric"] = "Moose",
                ["Ice"] = "Ice",
                ["Metal"] = "Platinum",
                ["Dark"] = "Penguin",
                ["Pure"] = "Pure Ice",

            },
            ["Metal"] =
            {
                ["Earth"] = "Armadillo",
                ["Fire"] = "Steampunk",
                ["Water"] = "Mercury",
                ["Nature"] = "Jade",
                ["Electric"] = "Gold",
                ["Ice"] = "Pearl",
                ["Metal"] = "Metal",
                ["Dark"] = "Zombie",
                ["Pure"] = "Pure Metal"
            },
            ["Dark"] =
            {
                ["Earth"] = "Venom",
                ["Fire"] = "Dark Fire",
                ["Water"] = "Pirate",
                ["Nature"] = "Rattle Snake",
                ["Electric"] = "Neon",
                ["Ice"] = "Penguin",
                ["Metal"] = "Zombie",
                ["Pure"] = "Pure Dark"
            },
            ["Pure"] =
            {
                ["Earth"] = "Pure Earth",
                ["Fire"] = "Pure Fire",
                ["Water"] = "Pure Water",
                ["Nature"] = "Pure Nature",
                ["Electric"] = "Pure Electric",
                ["Ice"] = "Pure Ice",
                ["Metal"] = "Pure Metal",
                ["Dark"] = "Pure Dark"
            }
        };
        public static Dictionary<string, Dictionary<string, string>> SpecialBreedingTable = new()
        {
            ["Earth"] =
            {
                ["Fire"] = "Chinese",
                ["Water"] = "Plankton",
                ["Nature"] = "Deep Forest",
                ["Electric"] = "Bat",
                ["Ice"] = "Santa",
                ["Dark"] = "Wizard"

            },
            ["Fire"] =
            {
                ["Earth"] = "Aztec",
                ["Water"] = "Thanksgiving",
                ["Nature"] = "Quetzal",
                ["Electric"] = "Aurora",
                ["Ice"] = "Ice and Fire",
                ["Metal"] = "Carnival",
                ["Dark"] = "Joker"
            },
            ["Water"] =
            {
                ["Earth"] = "Jelly",
                ["Fire"] = "Thanksgiving",
                ["Nature"] = "Seahorse",
                ["Electric"] = "Hydra",
                ["Ice"] = "Viking",
                ["Metal"] = "Alien",
                ["Dark"] = "Octopus"
            },
            ["Nature"] =
            {
                ["Earth"] = "Brontosaurus",
                ["Fire"] = "Paradise",
                ["Water"] = "Jellyfish",
                ["Electric"] = "St Patrick",
                ["Metal"] = "Ninja",
                ["Dark"] = "Two Headed"
            },
            ["Electric"] =
            {
                ["Earth"] = "Sky",
                ["Fire"] = "Music",
                ["Water"] = "Hydra",
                ["Nature"] = "St Patrick",
                ["Ice"] = "Prisma",
                ["Metal"] = "Uncle Sam",
                ["Dark"] = "Block"
            },
            ["Ice"] =
            {
                ["Earth"] = "Great White",
                ["Fire"] = "Ice and Fire",
                ["Water"] = "Viking",
                ["Electric"] = "Prisma",
                ["Dark"] = "Fossil"

            },
            ["Metal"] =
            {
                ["Fire"] = "King",
                ["Water"] = "Alien",
                ["Nature"] = "Queen",
                ["Electric"] = "Uncle Sam"
            },
            ["Dark"] =
            {
                ["Earth"] = "Ghost",
                ["Fire"] = "Joker",
                ["Water"] = "Octopus",
                ["Nature"] = "Evil Pumpkin",
                ["Electric"] = "Block",
                ["Ice"] = "Fossil"

            }
        };
        public static List<string> LegendaryDragons = ["Legendary", "Crystal", "Mirror", "Wind"];
    }
}
