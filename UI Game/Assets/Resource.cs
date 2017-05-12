using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resource : MonoBehaviour {

    public enum ListOfResources
    {
        Money,
        Wood,
        Stone,
        FreeVilliager,
        Builder,
        Woodcutter,
        Stonecutter,
        Forester,
        Sawmiller,
        CoalMiner,
        IronMiner,
        WeatFarmer,
        WeatMiller,
        PigFarmer,
        Slaughterer,
        Waterworker,
        Ironworker,
        Toolsmith,
        Weaponsmith,
        Swordsman,
        Archer,
        Commander
    };

    int clicks;
    int OnePress;

    [Header("Resource")]
    public int amount;
    public ListOfResources resource;
    public Button thisbutt;

    [Space(10)]

    public bool ResourcePerSecond;

    [Space(10)]

    [Header("Timer")]
    public Image ProgressBar;
    public Text DisplayText;

    [Space(10)]

    public float MaxDurration;
    private float Durration;





    private void Start()
    {
        thisbutt.onClick.AddListener(OnPressed);
    }

    void OnPressed()
    {
        OnePress++;
        
        Debug.Log(OnePress);
        if (OnePress == 1)
        {
            
            //DisplayText.text = Durration.ToString();
            Durration = MaxDurration;
            InvokeRepeating("Timer", 1, (1f/60f));

        }
        if (OnePress != 1)
        {
            Debug.Log("It's already in process");
            //DisplayText.text = Durration.ToString();
        }
    }

    void Timer()
    {
        if (Durration > 0)
        {
            Debug.Log("Timer has started");
            Durration -= Time.deltaTime; //* (1 + (1 / 2) * IncResource.GlobalResource.Builders);
            Debug.Log(Durration);
            ProgressBar.fillAmount = Durration / MaxDurration;
            DisplayText.text = Durration.ToString("0") + " Sek";
        }
        if (Durration < 0)
        {
            Durration = 0;
            OnePress = 0;

            if (ResourcePerSecond == true)
            {
                clicks++;
                Repeat();
            }
            else
            {
                OnClick();
            }
        }
    }

    void Repeat()
    {
        InvokeRepeating("OnClickS", 1, 1);
    }

    void OnClickS()
    {
        //Currency
        if (resource == ListOfResources.Money)
        {
            IncResource.GlobalResource.Money            =   amount * clicks + IncResource.GlobalResource.Money;
        }

        //Materials
        if (resource == ListOfResources.Wood)
        {
            IncResource.GlobalResource.Wood             =   amount * clicks + IncResource.GlobalResource.Wood;
        }
        if (resource == ListOfResources.Stone)
        {
            IncResource.GlobalResource.Stone            =   amount * clicks + IncResource.GlobalResource.Stone;
        }

        //Essencials
        if (resource == ListOfResources.FreeVilliager)
        {
            IncResource.GlobalResource.FreeVilliagers   =   amount * clicks + IncResource.GlobalResource.FreeVilliagers;
        }
        if (resource == ListOfResources.Builder)
        {
            IncResource.GlobalResource.Builders         =   amount * clicks + IncResource.GlobalResource.Builders;
        }
        if (resource == ListOfResources.Woodcutter)
        {
            IncResource.GlobalResource.Woodcutters      =   amount * clicks + IncResource.GlobalResource.Woodcutters;
        }
        if (resource == ListOfResources.Forester)
        {
            IncResource.GlobalResource.Foresters        =   amount * clicks + IncResource.GlobalResource.Foresters;
        }
        if (resource == ListOfResources.Sawmiller)
        {
            IncResource.GlobalResource.Sawmillers       =   amount * clicks + IncResource.GlobalResource.Sawmillers;
        }

        //Milers
        if (resource == ListOfResources.CoalMiner)
        {
            IncResource.GlobalResource.CoalMiners       =   amount * clicks + IncResource.GlobalResource.CoalMiners;
        }
        if (resource == ListOfResources.IronMiner)
        {
            IncResource.GlobalResource.IronMiners       =   amount * clicks + IncResource.GlobalResource.IronMiners;
        }

        //Workers
        if (resource == ListOfResources.WeatFarmer)
        {
            IncResource.GlobalResource.WeatFarmers      =   amount * clicks + IncResource.GlobalResource.WeatFarmers;
        }
        if (resource == ListOfResources.WeatMiller)
        {
            IncResource.GlobalResource.WeatMillers      =   amount * clicks + IncResource.GlobalResource.WeatMillers;
        }
        if (resource == ListOfResources.PigFarmer)
        {
            IncResource.GlobalResource.PigFarmers       =   amount * clicks + IncResource.GlobalResource.PigFarmers;
        }
        if (resource == ListOfResources.Slaughterer)
        {
            IncResource.GlobalResource.Slaughterers     =   amount * clicks + IncResource.GlobalResource.Slaughterers;
        }
        if (resource == ListOfResources.Waterworker)
        {
            IncResource.GlobalResource.Waterworkers     =   amount * clicks + IncResource.GlobalResource.Waterworkers;
        }

        //Forges
        if (resource == ListOfResources.Ironworker)
        {
            IncResource.GlobalResource.Ironworkers      =   amount * clicks + IncResource.GlobalResource.Ironworkers;
        }
        if (resource == ListOfResources.Toolsmith)
        {
            IncResource.GlobalResource.Toolsmiths       =   amount * clicks + IncResource.GlobalResource.Toolsmiths;
        }
        if (resource == ListOfResources.Weaponsmith)
        {
            IncResource.GlobalResource.Weaponsmiths     =   amount * clicks + IncResource.GlobalResource.Weaponsmiths;
        }

        //Soldiers
        if (resource == ListOfResources.Swordsman)
        {
            IncResource.GlobalResource.Swordsmans       =   amount * clicks + IncResource.GlobalResource.Swordsmans;
        }
        if (resource == ListOfResources.Archer)
        {
            IncResource.GlobalResource.Archers          =   amount * clicks + IncResource.GlobalResource.Archers;
        }
        if (resource == ListOfResources.Commander)
        {
            IncResource.GlobalResource.Commanders       =   amount * clicks + IncResource.GlobalResource.Commanders;
        }
    }

    void OnClick()
    {
        //Currency
        if (resource == ListOfResources.Money)
        {
            IncResource.GlobalResource.Money            =   amount + IncResource.GlobalResource.Money;
        }

        //Materials
        if (resource == ListOfResources.Wood)
        {
            IncResource.GlobalResource.Wood             =   amount + IncResource.GlobalResource.Wood;
        }
        if (resource == ListOfResources.Stone)
        {
            IncResource.GlobalResource.Stone            =   amount + IncResource.GlobalResource.Stone;
        }

        //Essencials
        if (resource == ListOfResources.FreeVilliager)
        {
            IncResource.GlobalResource.FreeVilliagers   =   amount + IncResource.GlobalResource.FreeVilliagers;
        }
        if (resource == ListOfResources.Builder)
        {
            IncResource.GlobalResource.Builders         =   amount + IncResource.GlobalResource.Builders;
        }
        if (resource == ListOfResources.Woodcutter)
        {
            IncResource.GlobalResource.Woodcutters      =   amount + IncResource.GlobalResource.Woodcutters;
        }
        if (resource == ListOfResources.Forester)
        {
            IncResource.GlobalResource.Foresters        =   amount + IncResource.GlobalResource.Foresters;
        }
        if (resource == ListOfResources.Sawmiller)
        {
            IncResource.GlobalResource.Sawmillers       =   amount + IncResource.GlobalResource.Sawmillers;
        }

        //Milers
        if (resource == ListOfResources.CoalMiner)
        {
            IncResource.GlobalResource.CoalMiners       =   amount + IncResource.GlobalResource.CoalMiners;
        }
        if (resource == ListOfResources.IronMiner)
        {
            IncResource.GlobalResource.IronMiners       =   amount + IncResource.GlobalResource.IronMiners;
        }

        //Workers
        if (resource == ListOfResources.WeatFarmer)
        {
            IncResource.GlobalResource.WeatFarmers      =   amount + IncResource.GlobalResource.WeatFarmers;
        }
        if (resource == ListOfResources.WeatMiller)
        {
            IncResource.GlobalResource.WeatMillers      =   amount + IncResource.GlobalResource.WeatMillers;
        }
        if (resource == ListOfResources.PigFarmer)
        {
            IncResource.GlobalResource.PigFarmers       =   amount + IncResource.GlobalResource.PigFarmers;
        }
        if (resource == ListOfResources.Slaughterer)
        {
            IncResource.GlobalResource.Slaughterers     =   amount + IncResource.GlobalResource.Slaughterers;
        }
        if (resource == ListOfResources.Waterworker)
        {
            IncResource.GlobalResource.Waterworkers     =   amount + IncResource.GlobalResource.Waterworkers;
        }

        //Forges
        if (resource == ListOfResources.Ironworker)
        {
            IncResource.GlobalResource.Ironworkers      =   amount + IncResource.GlobalResource.Ironworkers;
        }
        if (resource == ListOfResources.Toolsmith)
        {
            IncResource.GlobalResource.Toolsmiths       =   amount + IncResource.GlobalResource.Toolsmiths;
        }
        if (resource == ListOfResources.Weaponsmith)
        {
            IncResource.GlobalResource.Weaponsmiths     =   amount + IncResource.GlobalResource.Weaponsmiths;
        }

        //Soldiers
        if (resource == ListOfResources.Swordsman)
        {
            IncResource.GlobalResource.Swordsmans       =   amount + IncResource.GlobalResource.Swordsmans;
        }
        if (resource == ListOfResources.Archer)
        {
            IncResource.GlobalResource.Archers          =   amount + IncResource.GlobalResource.Archers;
        }
        if (resource == ListOfResources.Commander)
        {
            IncResource.GlobalResource.Commanders       =   amount + IncResource.GlobalResource.Commanders;
        }
    }
}
