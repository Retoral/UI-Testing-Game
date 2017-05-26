using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncResource : MonoBehaviour {


    [Header("On = Total, Off = Per Min")]
    public bool TotalOrPerMin;
    [Space(10)]
    public Text incResource;
    public ListOfResources resource;
    

    //Global variables
    public static class GlobalResource
    {

        //Currency
        public static float Money           =   0;

        //Materials
        public static float Trees               =   0;
        public static float Wood                =   0;
        public static float Planks              =   0;
        public static float Stone               =   0;
        public static float IronOre             =   0;
        public static float IronBars            =   0;
        public static float GoldOre             =   0;
        public static float GoldBars            =   0;
        public static float Coal                =   0;
        public static float Wheat               =   0;
        public static float Grain               =   0;
        public static float Bread               =   0;
        public static float Pigs                =   0;
        public static float Meat                =   0;
        public static float Water               =   0;
        public static float Fish                =   0;

        //Tools
        public static float Hammers             =   0;
        public static float Axes                =   0;
        public static float Pickaxes            =   0;
        public static float Saws                =   0;
        public static float Scythes             =   0;

        //Weaponry
        public static float Swords              =   0;
        public static float Bows                =   0;
        public static float Arrows              =   0;
        public static float Armours             =   0;

        //Essencials
        public static float FreeVilliagers      =   0;
        public static float Builders            =   0;
        public static float Woodcutters         =   0;
        public static float Stonecutters        =   0;
        public static float Foresters           =   0;
        public static float Sawmillers          =   0;

        //Miners
        public static float CoalMiners          =   0;
        public static float IronMiners          =   0;
        public static float GoldMiners          =   0;

        //Workers
        public static float WheatFarmers        =   0;
        public static float WheatMillers        =   0;
        public static float Bakers              =   0;
        public static float PigFarmers          =   0;
        public static float Butchers            =   0;
        public static float Waterworkers        =   0;
        public static float Fishermans          =   0;

        //Forges
        public static float IronSmelters        =   0;
        public static float GoldSmelters        =   0;
        public static float Toolsmiths          =   0;
        public static float Weaponsmiths        =   0;

        //Soldiers
        public static float Swordsmans          =   0;
        public static float Archers             =   0;
        public static float Commanders          =   0;

        //Buildings
        public static float WoodcuttersHuts     =   0;
        public static float Sawmills            =   0;
        public static float ForestersHuts       =   0;
        public static float StonecuttersHuts    =   0;
        public static float CoalMines           =   0;
        public static float IronOreMines        =   0;
        public static float GoldMines           =   0;
        public static float WheatFarms          =   0;
        public static float WheatMills          =   0;
        public static float Bakeries            =   0;
        public static float PigFarms            =   0;
        public static float Slaughterhouses     =   0;
        public static float Waterworks          =   0;
        public static float FishermansHuts      =   0;
        public static float IronFurnaces        =   0;
        public static float GoldFurnaces        =   0;
        public static float ToolSmithies        =   0;
        public static float WeaponSmithies      =   0;
        public static float Barracks            =   0;
    }

	// Update is called once per frame
	void Update () {

        //Currency
        if (resource == ListOfResources.Money)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = "$ " + GlobalResource.Money.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = "$ " + Resource.IncomingResourcePerMinute.MoneyRPM.ToString();
            }
        }

        //Materials
        if (resource == ListOfResources.Tree)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Trees.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.TreesRPM.ToString();
            }
        }
        if (resource == ListOfResources.Wood)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Wood.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WoodRPM.ToString();
            }
        }
        if (resource == ListOfResources.Plank)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Planks.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.PlanksRPM.ToString();
            }
        }
        if (resource == ListOfResources.Stone)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Stone.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.StoneRPM.ToString();
            }
        }
        if (resource == ListOfResources.Coal)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Coal.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.CoalRPM.ToString();
            }
        }
        if (resource == ListOfResources.IronOre)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronOre.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronOreRPM.ToString();
            }
        }
        if (resource == ListOfResources.IronBar)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronBars.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronBarsRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldOre)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldOre.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldOreRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldBar)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldBars.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldBarsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Wheat)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Wheat.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WheatRPM.ToString();
            }
        }
        if (resource == ListOfResources.Grain)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Grain.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GrainRPM.ToString();
            }
        }
        if (resource == ListOfResources.Bread)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Bread.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BreadRPM.ToString();
            }
        }
        if (resource == ListOfResources.Pig)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Pigs.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.PigsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Meat)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Meat.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.MeatRPM.ToString();
            }
        }
        if (resource == ListOfResources.Water)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Water.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WaterRPM.ToString();
            }
        }
        if (resource == ListOfResources.Fish)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Fish.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.FishRPM.ToString();
            }
        }

        //Tools
        if (resource == ListOfResources.Hammer)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Hammers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.HammersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Axe)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Axes.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.AxesRPM.ToString();
            }
        }
        if (resource == ListOfResources.Pickaxe)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Pickaxes.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.PickaxesRPM.ToString();
            }
        }
        if (resource == ListOfResources.Saw)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Saws.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SawsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Scythe)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Scythes.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ScythesRPM.ToString();
            }
        }

        //Weaponry
        if (resource == ListOfResources.Sword)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Swords.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SwordsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Bow)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Bows.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BowsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Arrow)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Arrows.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ArrowsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Armour)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Armours.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ArmoursRPM.ToString();
            }
        }

        //Essencials
        if (resource == ListOfResources.FreeVilliager)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.FreeVilliagers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.FreeVilliagersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Builder)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Builders.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BuildersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Woodcutter)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Woodcutters.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WoodcuttersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Forester)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Foresters.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.StonecuttersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Stonecutter)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Stonecutters.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ForestersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Sawmiller)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Sawmillers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SawmillersRPM.ToString();
            }
        }

        //Miners
        if (resource == ListOfResources.CoalMiner)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.CoalMiners.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.CoalMinersRPM.ToString();
            }
        }
        if (resource == ListOfResources.IronMiner)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronMiners.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronMinersRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldMiner)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldMiners.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldMinersRPM.ToString();
            }
        }

        //Workers
        if (resource == ListOfResources.WheatFarmer)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WheatFarmers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WheatFarmersRPM.ToString();
            }
        }
        if (resource == ListOfResources.WheatMiller)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WheatMillers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WheatMillersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Baker)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Bakers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BakersRPM.ToString();
            }
        }
        if (resource == ListOfResources.PigFarmer)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.PigFarmers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.PigFarmersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Butcher)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Butchers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ButchersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Waterworker)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Waterworkers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WaterworkersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Fisherman)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Fishermans.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.FishermansRPM.ToString();
            }
        }

        //Forges
        if (resource == ListOfResources.IronSmelter)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronSmelters.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronSmeltersRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldSmelter)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldSmelters.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldSmeltersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Toolsmith)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Toolsmiths.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ToolsmithsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Weaponsmith)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Weaponsmiths.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WeaponsmithsRPM.ToString();
            }
        }

        //Soldiers
        if (resource == ListOfResources.Swordsman)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Swordsmans.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SwordsmansRPM.ToString();
            }
        }
        if (resource == ListOfResources.Archer)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Archers.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ArchersRPM.ToString();
            }
        }
        if (resource == ListOfResources.Commander)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Commanders.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.CommandersRPM.ToString();
            }
        }

        //Builders
        if (resource == ListOfResources.WoodcuttersHut)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WoodcuttersHuts.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WoodcuttersHutsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Sawmill)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Sawmills.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SawmillsRPM.ToString();
            }
        }
        if (resource == ListOfResources.ForestersHut)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.ForestersHuts.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ForestersHutsRPM.ToString();
            }
        }
        if (resource == ListOfResources.StonecuttersHut)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.StonecuttersHuts.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.StonecuttersHutsRPM.ToString();
            }
        }
        if (resource == ListOfResources.CoalMine)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.CoalMines.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.CoalMinesRPM.ToString();
            }
        }
        if (resource == ListOfResources.IronOreMine)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronOreMines.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronOreMinesRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldMine)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldMines.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldMinesRPM.ToString();
            }
        }
        if (resource == ListOfResources.WheatFarm)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WheatFarms.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WheatFarmsRPM.ToString();
            }
        }
        if (resource == ListOfResources.WheatMill)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WheatMills.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WheatMillsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Bakery)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Bakeries.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BakeriesRPM.ToString();
            }
        }
        if (resource == ListOfResources.PigFarm)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.PigFarms.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.PigFarmsRPM.ToString();
            }
        }
        if (resource == ListOfResources.Slaughterhouse)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Slaughterhouses.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.SlaughterhousesRPM.ToString();
            }
        }
        if (resource == ListOfResources.Waterworks)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Waterworks.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WaterworksRPM.ToString();
            }
        }
        if (resource == ListOfResources.FishermansHut)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.FishermansHuts.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.FishermansHutsRPM.ToString();
            }
        }
        if (resource == ListOfResources.IronFurnace)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.IronFurnaces.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.IronFurnacesRPM.ToString();
            }
        }
        if (resource == ListOfResources.GoldFurnace)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.GoldFurnaces.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.GoldFurnacesRPM.ToString();
            }
        }
        if (resource == ListOfResources.ToolSmithy)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.ToolSmithies.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.ToolSmithiesRPM.ToString();
            }
        }
        if (resource == ListOfResources.WeaponSmithy)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.WeaponSmithies.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.WeaponSmithiesRPM.ToString();
            }
        }
        if (resource == ListOfResources.Barrack)
        {
            if (TotalOrPerMin == true)
            {
                incResource.text = GlobalResource.Barracks.ToString();
            }
            if (TotalOrPerMin == false)
            {
                incResource.text = Resource.IncomingResourcePerMinute.BarracksRPM.ToString();
            }
        }
    }
}
