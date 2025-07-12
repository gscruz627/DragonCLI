using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public class Farm
    {
        public string FarmType { get; set; }
        public List<Crop> AvailableCrops { get; set; }
        public Crop CurrentCrop { get; set; }
        public DateTime? DueDateTime { get; set; }
        public Farm()
        {
            FarmType = "Food Farm";
            AvailableCrops = [
                new Crop("Bluebell Flower", 50, 5, TimeSpan.FromSeconds(30), 25),
                new Crop("Chili Pops", 250, 25, TimeSpan.FromMinutes(5), 250),
                new Crop("Berry Parcel", 1000, 75, TimeSpan.FromMinutes(30), 1000),
                ];
            CurrentCrop = null;
            DueDateTime = null;
        }
        public bool Upgrade(ref GameData gameData)
        {
            if(FarmType == "Food Farm")
            {
                if (gameData.Gold >= 25000)
                {
                    FarmType = "Big Food Farm";

                    AvailableCrops.AddRange([
                        new Crop("Single-Spear Corn", 5000, 200, TimeSpan.FromHours(2),5000),
                    new Crop("Lil's Blooms", 15000, 500, TimeSpan.FromHours(6), 15000),
                    new Crop("Rainbow Sprouts", 150000, 2250, TimeSpan.FromHours(3), 18750)
                        ]);
                    gameData.CurrentXP += 25000;
                    gameData.Gold -= 25000;
                    Console.WriteLine("You upgraded this farm and earned 25,000 XP! Press any key to continue");
                    return true;
                } else
                {
                    return false;
                }
                
            } else
            {
                if(gameData.Gold > 250000)
                {
                    FarmType = "Huge Food Farm";
                    AvailableCrops.AddRange([
                        new Crop("Prickly Pods", 1000000,10000,TimeSpan.FromHours(9), 100000),
                    new Crop("Venus Plant", 3000000, 25000,TimeSpan.FromHours(12),150000),
                    new Crop("Stellar Fruit", 20000000,150000,TimeSpan.FromHours(24),1250000)
                        ]);
                    gameData.CurrentXP += 250000;
                    gameData.Gold -= 250000;
                    Console.WriteLine("You upgraded this farm and earned 250,000 XP! Press any key to continue");

                    return true;
                } else
                {
                    return false;
                } 
            }
        }
        public void Grow(int index)
        {
            CurrentCrop = AvailableCrops[index];
            DueDateTime = DateTime.Now;
            DueDateTime += CurrentCrop.Duration;
        }
    }
}
