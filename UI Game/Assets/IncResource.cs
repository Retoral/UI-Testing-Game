using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncResource : MonoBehaviour {

    public Text incResource;
    public string resource;

    //Global variables
    public static class GlobalResource{

        //Currency
        public static float Money;
        
        //Materials
        public static float Wood;
        public static float Stone;

        //Essencials
        public static float FreeVilliagers;
        public static float Builders;
        public static float Woodcutters;
        public static float Stonecutters;
        public static float Foresters;
        public static float Sawmillers;

        //Miners
        public static float CoalMiners;
        public static float IronMiners;

        //Workers
        public static float WeatFarmers;
        public static float WeatMillers;
        public static float PigFarmers;
        public static float Slaughterers;
        public static float Waterworkers;

        //Forges
        public static float Ironworkers;
        public static float Toolsmiths;
        public static float Weaponsmiths;

        //Soldiers
        public static float Swordsmans;
        public static float Archers;
        public static float Commanders;
    }
    
    
	// Update is called once per frame
	void Update () {

        //Currency
        if (resource == "Money")
        {
            incResource.text    =   GlobalResource.Money.ToString();
        }

        //Materials
        if (resource == "Wood")
        {
            incResource.text    =   GlobalResource.Wood.ToString();
        }
        if (resource == "Stone")
        {
            incResource.text    =   GlobalResource.Stone.ToString();
        }

        //Essencials
        if (resource == "FreeVilliager")
        {
            incResource.text    =   GlobalResource.FreeVilliagers.ToString();
        }
        if (resource == "Builder")
        {
            incResource.text    =   GlobalResource.Builders.ToString();
        }
        if (resource == "Woodcutter")
        {
            incResource.text    =   GlobalResource.Woodcutters.ToString();
        }
        if (resource == "Stonecutter")
        {
            incResource.text    =   GlobalResource.Stonecutters.ToString();
        }
        if (resource == "Forester")
        {
            incResource.text    =   GlobalResource.Foresters.ToString();
        }
        if (resource == "Sawmiller")
        {
            incResource.text    =   GlobalResource.Sawmillers.ToString();
        }

        //Miners
        if (resource == "Coalminer")
        {
            incResource.text    =   GlobalResource.CoalMiners.ToString();
        }
        if (resource == "Ironminer")
        {
            incResource.text    =   GlobalResource.IronMiners.ToString();
        }

        //Workers
        if (resource == "Weatfarmer")
        {
            incResource.text    =   GlobalResource.WeatFarmers.ToString();
        }
        if (resource == "Weatmiller")
        {
            incResource.text    =   GlobalResource.WeatMillers.ToString();
        }
        if (resource == "PigFarmer")
        {
            incResource.text    =   GlobalResource.PigFarmers.ToString();
        }
        if (resource == "Slaughterer")
        {
            incResource.text    =   GlobalResource.Slaughterers.ToString();
        }
        if (resource == "Waterworker")
        {
            incResource.text    =   GlobalResource.Waterworkers.ToString();
        }

        //Forges
        if (resource == "Ironworker")
        {
            incResource.text    =   GlobalResource.Ironworkers.ToString();
        }
        if (resource == "Toolsmith")
        {
            incResource.text    =   GlobalResource.Toolsmiths.ToString();
        }
        if (resource == "Weaponsmith")
        {
            incResource.text    =   GlobalResource.Weaponsmiths.ToString();
        }

        //Soldiers
        if (resource == "Swordsman")
        {
            incResource.text    =   GlobalResource.Swordsmans.ToString();
        }
        if (resource == "Archer")
        {
            incResource.text    =   GlobalResource.Archers.ToString();
        }
        if (resource == "Commander")
        {
            incResource.text    =   GlobalResource.Commanders.ToString();
        }
    }
}
