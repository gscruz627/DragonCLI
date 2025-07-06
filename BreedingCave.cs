using DragonCLI.Dragons;
using DragonCLI.Eggs;
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
        public Egg BreedOutcome { get; set; }
        public DateTime? DueDate { get; set; }
        public static Dictionary<string, string> Opposites = new()
        {
            ["Earth"] = "Metal",
            ["Water"] = "Dark",
            ["Fire"] = "Ice",
            ["Nature"] = "Electric"
        };

        public static Dictionary<string, Dictionary<string, Func<Egg>>> RegularBreedingTable = new()
        {
            ["Earth"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new EarthEgg(),
                ["Fire"] = () => new FlamingRockEgg(),
                ["Water"] = () => new WaterfallEgg(),
                ["Nature"] = () => new TropicalEgg(),
                ["Electric"] = () => new StarEgg(),
                ["Ice"] = () => new SnowflakeEgg(),
                ["Metal"] = () => new ArmadilloEgg(),
                ["Dark"] = () => new HedgehogEgg(),
                ["Pure"] = () => new PureEarthEgg(),
            },
            ["Fire"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new VolcanoEgg(),
                ["Fire"] = () => new FireEgg(),
                ["Water"] = () => new CloudEgg(),
                ["Nature"] = () => new FirebirdEgg(),
                ["Electric"] = () => new HotMetalEgg(),
                ["Ice"] = () => new CoolFireEgg(),
                ["Metal"] = () => new MedievalEgg(),
                ["Dark"] = () => new VampireEgg(),
                ["Pure"] = () => new PureFireEgg()
            },
            ["Water"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new MudEgg(),
                ["Fire"] = () => new BlizzardEgg(),
                ["Water"] = () => new WaterEgg(),
                ["Nature"] = () => new NenufarEgg(),
                ["Electric"] = () => new StormEgg(),
                ["Ice"] = () => new IceCubeEgg(),
                ["Metal"] = () => new SeashellEgg(),
                ["Dark"] = () => new PetroleumEgg(),
                ["Pure"] = () => new PureWaterEgg()
            },
            ["Nature"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new CactusEgg(),
                ["Fire"] = () => new SpicyEgg(),
                ["Water"] = () => new CoralEgg(),
                ["Nature"] = () => new NatureEgg(),
                ["Electric"] = () => new GummyEgg(),
                ["Ice"] = () => new DandelionEgg(),
                ["Metal"] = () => new DragonflyEgg(),
                ["Dark"] = () => new CarnivorousPlantEgg(),
                ["Pure"] = () => new PureNatureEgg()
            },
            ["Electric"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new ChameleonEgg(),
                ["Fire"] = () => new LaserEgg(),
                ["Water"] = () => new LanternFishEgg(),
                ["Nature"] = () => new GummyEgg(),
                ["Electric"] = () => new ElectricEgg(),
                ["Ice"] = () => new FluorescentEgg(),
                ["Metal"] = () => new BatteryEgg(),
                ["Dark"] = () => new NeonEgg(),
                ["Pure"] = () => new PureElectricEgg()
            },
            ["Ice"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new AlpineEgg(),
                ["Fire"] = () => new SoccerEgg(),
                ["Water"] = () => new IceCreamEgg(),
                ["Nature"] = () => new MojitoEgg(),
                ["Electric"] = () => new MooseEgg(),
                ["Ice"] = () => new IceEgg(),
                ["Metal"] = () => new PlatinumEgg(),
                ["Dark"] = () => new PenguinEgg(),
                ["Pure"] = () => new PureIceEgg()
            },
            ["Metal"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new ArmadilloEgg(),
                ["Fire"] = () => new SteampunkEgg(),
                ["Water"] = () => new MercuryEgg(),
                ["Nature"] = () => new JadeEgg(),
                ["Electric"] = () => new GoldEgg(),
                ["Ice"] = () => new PearlEgg(),
                ["Metal"] = () => new MetalEgg(),
                ["Dark"] = () => new ZombieEgg(),
                ["Pure"] = () => new PureMetalEgg()
            },
            ["Dark"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new VenomEgg(),
                ["Fire"] = () => new DarkFireEgg(),
                ["Water"] = () => new PirateEgg(),
                ["Nature"] = () => new RattlesnakeEgg(),
                ["Electric"] = () => new NeonEgg(),
                ["Ice"] = () => new PenguinEgg(),
                ["Metal"] = () => new ZombieEgg(),
                ["Pure"] = () => new PureDarkEgg()
            },
            ["Pure"] = new Dictionary<string, Func<Egg>>
            {
                ["Earth"] = () => new PureEarthEgg(),
                ["Fire"] = () => new PureFireEgg(),
                ["Water"] = () => new PureWaterEgg(),
                ["Nature"] = () => new PureNatureEgg(),
                ["Electric"] = () => new PureElectricEgg(),
                ["Ice"] = () => new PureIceEgg(),
                ["Metal"] = () => new PureMetalEgg(),
                ["Dark"] = () => new PureDarkEgg()
            }
        };

        public static Dictionary<string, Dictionary<string, Func<Egg>>> SpecialBreedingTable = new()
        {
            ["Earth"] = new()
            {
                ["Fire"] = () => new ChineseEgg(),
                ["Water"] = () => new PlanktonEgg(),
                ["Nature"] = () => new DeepForestEgg(),
                ["Electric"] = () => new BatEgg(),
                ["Ice"] = () => new SantaEgg(),
                ["Dark"] = () => new WizardEgg()
            },
            ["Fire"] = new()
            {
                ["Earth"] = () => new AztecEgg(),
                ["Water"] = () => new ThanksgivingEgg(),
                ["Nature"] = () => new QuetzalEgg(),
                ["Electric"] = () => new AuroraEgg(),
                ["Ice"] = () => new IceAndFireEgg(),
                ["Metal"] = () => new CarnivalEgg(),
                ["Dark"] = () => new JokerEgg()
            },
            ["Water"] = new()
            {
                ["Earth"] = () => new JellyEgg(),
                ["Fire"] = () => new ThanksgivingEgg(),
                ["Nature"] = () => new SeahorseEgg(),
                ["Electric"] = () => new HydraEgg(),
                ["Ice"] = () => new VikingEgg(),
                ["Metal"] = () => new AlienEgg(),
                ["Dark"] = () => new OctopusEgg()
            },
            ["Nature"] = new()
            {
                ["Earth"] = () => new BrontosaurusEgg(),
                ["Fire"] = () => new ButterflyEgg(),
                ["Water"] = () => new JellyfishEgg(),
                ["Electric"] = () => new StPatrickEgg(),
                ["Metal"] = () => new NinjaEgg(),
                ["Dark"] = () => new TwoHeadedEgg()
            },
            ["Electric"] = new()
            {
                ["Earth"] = () => new SkyEgg(),
                ["Fire"] = () => new MusicEgg(),
                ["Water"] = () => new HydraEgg(),
                ["Nature"] = () => new StPatrickEgg(),
                ["Ice"] = () => new PrismaEgg(),
                ["Metal"] = () => new UncleSamEgg(),
                ["Dark"] = () => new BlockEgg()
            },
            ["Ice"] = new()
            {
                ["Earth"] = () => new GreatWhiteEgg(),
                ["Fire"] = () => new IceAndFireEgg(),
                ["Water"] = () => new VikingEgg(),
                ["Electric"] = () => new PrismaEgg(),
                ["Dark"] = () => new FossilEgg()
            },
            ["Metal"] = new()
            {
                ["Fire"] = () => new KingEgg(),
                ["Water"] = () => new AlienEgg(),
                ["Nature"] = () => new QueenEgg(),
                ["Electric"] = () => new UncleSamEgg()
            },
            ["Dark"] = new()
            {
                ["Earth"] = () => new GhostEgg(),
                ["Fire"] = () => new JokerEgg(),
                ["Water"] = () => new OctopusEgg(),
                ["Nature"] = () => new EvilPumpkinEgg(),
                ["Electric"] = () => new BlockEgg(),
                ["Ice"] = () => new FossilEgg()
            }
        };

        public static List<Func<Egg>> LegendaryDragons = [() => new LegendaryEgg(), () => new CrystalEgg(), () => new MirrorEgg(), () => new AirEgg()];
    }
}
