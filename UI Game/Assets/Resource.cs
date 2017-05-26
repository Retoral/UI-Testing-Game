using UnityEngine;
using UnityEngine.UI;



public class Resource : MonoBehaviour
{

  public static class IncomingResourcePerMinute
  {
    //Currency
    public static float MoneyRPM                =   0;

    //Materials
    public static float TreesRPM                =   0;
    public static float WoodRPM                 =   0;
    public static float PlanksRPM               =   0;
    public static float StoneRPM                =   0;
    public static float IronOreRPM              =   0;
    public static float IronBarsRPM             =   0;
    public static float GoldOreRPM              =   0;
    public static float GoldBarsRPM             =   0;
    public static float CoalRPM                 =   0;
    public static float WheatRPM                =   0;
    public static float GrainRPM                =   0;
    public static float BreadRPM                =   0;
    public static float PigsRPM                 =   0;
    public static float MeatRPM                 =   0;
    public static float WaterRPM                =   0;
    public static float FishRPM                 =   0;

    //Tools
    public static float HammersRPM              =   0;
    public static float AxesRPM                 =   0;
    public static float PickaxesRPM             =   0;
    public static float SawsRPM                 =   0;
    public static float ScythesRPM              =   0;

    //Weaponry
    public static float SwordsRPM               =   0;
    public static float BowsRPM                 =   0;
    public static float ArrowsRPM               =   0;
    public static float ArmoursRPM              =   0;

    //Essencials
    public static float FreeVilliagersRPM       =   0;
    public static float BuildersRPM             =   0;
    public static float WoodcuttersRPM          =   0;
    public static float StonecuttersRPM         =   0;
    public static float ForestersRPM            =   0;
    public static float SawmillersRPM           =   0;

    //Miners
    public static float CoalMinersRPM           =   0;
    public static float IronMinersRPM           =   0;
    public static float GoldMinersRPM           =   0;

    //Workers
    public static float WheatFarmersRPM         =   0;
    public static float WheatMillersRPM         =   0;
    public static float BakersRPM               =   0;
    public static float PigFarmersRPM           =   0;
    public static float ButchersRPM             =   0;
    public static float WaterworkersRPM         =   0;
    public static float FishermansRPM           =   0;

    //Forges
    public static float IronSmeltersRPM         =   0;
    public static float GoldSmeltersRPM         =   0;
    public static float ToolsmithsRPM           =   0;
    public static float WeaponsmithsRPM         =   0;

    //Soldiers
    public static float SwordsmansRPM           =   0;
    public static float ArchersRPM              =   0;
    public static float CommandersRPM           =   0;

    //Buildings
    public static float WoodcuttersHutsRPM      =   0;
    public static float SawmillsRPM             =   0;
    public static float ForestersHutsRPM        =   0;
    public static float StonecuttersHutsRPM     =   0;
    public static float CoalMinesRPM            =   0;
    public static float IronOreMinesRPM         =   0;
    public static float GoldMinesRPM            =   0;
    public static float WheatFarmsRPM           =   0;
    public static float WheatMillsRPM           =   0;
    public static float BakeriesRPM             =   0;
    public static float PigFarmsRPM             =   0;
    public static float SlaughterhousesRPM      =   0;
    public static float WaterworksRPM           =   0;
    public static float FishermansHutsRPM       =   0;
    public static float IronFurnacesRPM         =   0;
    public static float GoldFurnacesRPM         =   0;
    public static float ToolSmithiesRPM         =   0;
    public static float WeaponSmithiesRPM       =   0;
    public static float BarracksRPM             =   0;
  }

  int clicks;
  int OnePress;

  [Header("Resource")]
  public int amount;
  public ListOfResources resource;
  public Button thisbutt;
  public Transform progressBar;

  [Space(10)]

  public bool ResourcePerSecond;

  [Space(10)]

  [Header("Timer")]
  public Image TimerBar;
  public Text DisplayText;
  [Range(1.0f, 60f)]
  public float TimerFrequency;
  public float DurrationMin;
  public float DurrationSek;
  private float MaxDurration;
  private float ResetMin;
  private float ResetSek;


  private void Start()
  {
    ResetMin = DurrationMin;
    ResetSek = DurrationSek;
    MaxDurration = DurrationSek + DurrationMin * 60;
    thisbutt.onClick.AddListener(OnPressed);
  }

  void OnPressed()
  {
    progressBar.gameObject.SetActive(true);
    OnePress++;
    Debug.Log(OnePress);
    if (OnePress != 1)
    {
      Debug.Log("It's already in process");
    }
  }

  void Update()
  {
    if (DurrationMin >= 0 && DurrationSek >= 0 && OnePress >= 1)
    {
      if (DurrationSek >= 0 && DurrationMin >= 0)
      {
        DurrationSek -= Time.deltaTime * (1 + (1 / 2) * IncResource.GlobalResource.Builders);
        TimerBar.fillAmount = (DurrationSek + DurrationMin * 60) / MaxDurration;

        if (DurrationMin > 0)
        {
          DisplayText.text = DurrationMin.ToString("0") + " Min " + DurrationSek.ToString("0") + " Sek";
        }
        else if (DurrationMin <= 0)
        {
          DisplayText.text = DurrationSek.ToString("0") + " Sek";
        }
        if (DurrationSek <= 0 && DurrationMin > 0)
        {
          DurrationMin -= 1;
          DurrationSek += 60;
        }
      }
    }

    if (DurrationSek < 0 && DurrationMin <= 0)
    {
      DurrationSek = 0;
      OnePress = 0;
      progressBar.gameObject.SetActive(false);

      if (ResourcePerSecond == true)
      {
        clicks++;
        Repeat();
        RepeatList();
        DurrationMin = ResetMin;
        DurrationSek = ResetSek;
      }
      else
      {
        OnClick();
        DurrationMin = ResetMin;
        DurrationSek = ResetSek;
      }
    }
  }

  void Repeat()
  {
    int loop = 0;
    loop++;
    InvokeRepeating("OnClickS", TimerFrequency, TimerFrequency);
    Debug.Log("Repeated: " + loop + " times.");
    ;
  }

  void RepeatList()
  {
    //Currency
    if (resource == ListOfResources.Money)
    {
      IncomingResourcePerMinute.MoneyRPM          = amount * clicks;
    }

    //Materials
    if (resource == ListOfResources.Wood)
    {
      IncomingResourcePerMinute.WoodRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Plank)
    {
      IncomingResourcePerMinute.PlanksRPM         = amount * clicks;
    }
    if (resource == ListOfResources.Stone)
    {
      IncomingResourcePerMinute.StoneRPM          = amount * clicks;
    }
    if (resource == ListOfResources.IronBar)
    {
      IncomingResourcePerMinute.IronOreRPM        = amount * clicks;
    }
    if (resource == ListOfResources.GoldBar)
    {
      IncomingResourcePerMinute.GoldBarsRPM       = amount * clicks;
    }
    if (resource == ListOfResources.Tree)
    {
      IncomingResourcePerMinute.TreesRPM          = amount * clicks;
    }
    if (resource == ListOfResources.Coal)
    {
      IncomingResourcePerMinute.CoalRPM           = amount * clicks;
    }
    if (resource == ListOfResources.IronOre)
    {
      IncomingResourcePerMinute.CoalRPM           = amount * clicks;
    }
    if (resource == ListOfResources.GoldOre)
    {
      IncomingResourcePerMinute.GoldOreRPM        = amount * clicks;
    }
    if (resource == ListOfResources.Wheat)
    {
      IncomingResourcePerMinute.WheatRPM          = amount * clicks;
    }
    if (resource == ListOfResources.Grain)
    {
      IncomingResourcePerMinute.GrainRPM          = amount * clicks;
    }
    if (resource == ListOfResources.Bread)
    {
      IncomingResourcePerMinute.BreadRPM          = amount * clicks;
    }
    if (resource == ListOfResources.Pig)
    {
      IncomingResourcePerMinute.PigsRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Meat)
    {
      IncomingResourcePerMinute.MeatRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Water)
    {
      IncomingResourcePerMinute.WaterRPM          = amount * clicks;
    }
    if (resource == ListOfResources.Fish)
    {
      IncomingResourcePerMinute.FishRPM           = amount * clicks;
    }

    //Tools
    if (resource == ListOfResources.Hammer)
    {
      IncomingResourcePerMinute.HammersRPM        = amount * clicks;
    }
    if (resource == ListOfResources.Axe)
    {
      IncomingResourcePerMinute.AxesRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Pickaxe)
    {
      IncomingResourcePerMinute.PickaxesRPM       = amount * clicks;
    }
    if (resource == ListOfResources.Saw)
    {
      IncomingResourcePerMinute.SawsRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Scythe)
    {
      IncomingResourcePerMinute.ScythesRPM        = amount * clicks;
    }

    //Weaponry
    if (resource == ListOfResources.Sword)
    {
      IncomingResourcePerMinute.SwordsRPM         = amount * clicks;
    }
    if (resource == ListOfResources.Bow)
    {
      IncomingResourcePerMinute.BowsRPM           = amount * clicks;
    }
    if (resource == ListOfResources.Arrow)
    {
      IncomingResourcePerMinute.ArrowsRPM         = amount * clicks;
    }
    if (resource == ListOfResources.Armour)
    {
      IncomingResourcePerMinute.ArmoursRPM        = amount * clicks;
    }

    //Essencials
    if (resource == ListOfResources.FreeVilliager)
    {
      IncomingResourcePerMinute.FreeVilliagersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Builder)
    {
      IncomingResourcePerMinute.BuildersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Woodcutter)
    {
      IncomingResourcePerMinute.WoodcuttersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Forester)
    {
      IncomingResourcePerMinute.StonecuttersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Stonecutter)
    {
      IncomingResourcePerMinute.ForestersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Sawmiller)
    {
      IncomingResourcePerMinute.SawmillersRPM = amount * clicks;
    }

    //Milers
    if (resource == ListOfResources.CoalMiner)
    {
      IncomingResourcePerMinute.CoalMinersRPM = amount * clicks;
    }
    if (resource == ListOfResources.IronMiner)
    {
      IncomingResourcePerMinute.IronMinersRPM = amount * clicks;
    }
    if (resource == ListOfResources.GoldMiner)
    {
      IncomingResourcePerMinute.GoldMinersRPM = amount * clicks;
    }

    //Workers
    if (resource == ListOfResources.WheatFarmer)
    {
      IncomingResourcePerMinute.WheatFarmersRPM = amount * clicks;
    }
    if (resource == ListOfResources.WheatMiller)
    {
      IncomingResourcePerMinute.WheatMillersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Baker)
    {
      IncomingResourcePerMinute.BakersRPM = amount * clicks;
    }
    if (resource == ListOfResources.PigFarmer)
    {
      IncomingResourcePerMinute.PigFarmersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Butcher)
    {
      IncomingResourcePerMinute.ButchersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Waterworker)
    {
      IncomingResourcePerMinute.WaterworkersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Fisherman)
    {
      IncomingResourcePerMinute.FishermansRPM = amount * clicks;
    }

    //Forges
    if (resource == ListOfResources.IronSmelter)
    {
      IncomingResourcePerMinute.IronSmeltersRPM = amount * clicks;
    }
    if (resource == ListOfResources.GoldSmelter)
    {
      IncomingResourcePerMinute.GoldSmeltersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Toolsmith)
    {
      IncomingResourcePerMinute.ToolsmithsRPM = amount * clicks;
    }
    if (resource == ListOfResources.Weaponsmith)
    {
      IncomingResourcePerMinute.WeaponsmithsRPM = amount * clicks;
    }

    //Soldiers
    if (resource == ListOfResources.Swordsman)
    {
      IncomingResourcePerMinute.SwordsmansRPM = amount * clicks;
    }
    if (resource == ListOfResources.Archer)
    {
      IncomingResourcePerMinute.ArchersRPM = amount * clicks;
    }
    if (resource == ListOfResources.Commander)
    {
      IncomingResourcePerMinute.CommandersRPM = amount * clicks;
    }

    //Buildings
    if (resource == ListOfResources.WoodcuttersHut)
    {
      IncomingResourcePerMinute.WoodcuttersHutsRPM = amount * clicks;
    }
    if (resource == ListOfResources.Sawmill)
    {
      IncomingResourcePerMinute.SawmillsRPM = amount * clicks;
    }
    if (resource == ListOfResources.ForestersHut)
    {
      IncomingResourcePerMinute.ForestersHutsRPM = amount * clicks;
    }
    if (resource == ListOfResources.StonecuttersHut)
    {
      IncomingResourcePerMinute.StonecuttersHutsRPM = amount * clicks;
    }
    if (resource == ListOfResources.CoalMine)
    {
      IncomingResourcePerMinute.CoalMinesRPM = amount * clicks;
    }
    if (resource == ListOfResources.IronOreMine)
    {
      IncomingResourcePerMinute.IronOreMinesRPM = amount * clicks;
    }
    if (resource == ListOfResources.GoldMine)
    {
      IncomingResourcePerMinute.GoldMinesRPM = amount * clicks;
    }
    if (resource == ListOfResources.WheatFarm)
    {
      IncomingResourcePerMinute.WheatFarmsRPM = amount * clicks;
    }
    if (resource == ListOfResources.WheatMill)
    {
      IncomingResourcePerMinute.WheatMillsRPM = amount * clicks;
    }
    if (resource == ListOfResources.Bakery)
    {
      IncomingResourcePerMinute.BakeriesRPM = amount * clicks;
    }
    if (resource == ListOfResources.PigFarm)
    {
      IncomingResourcePerMinute.PigFarmsRPM = amount * clicks;
    }
    if (resource == ListOfResources.Slaughterhouse)
    {
      IncomingResourcePerMinute.SlaughterhousesRPM = amount * clicks;
    }
    if (resource == ListOfResources.Waterworks)
    {
      IncomingResourcePerMinute.WaterworksRPM = amount * clicks;
    }
    if (resource == ListOfResources.FishermansHut)
    {
      IncomingResourcePerMinute.FishermansHutsRPM = amount * clicks;
    }
    if (resource == ListOfResources.IronFurnace)
    {
      IncomingResourcePerMinute.IronFurnacesRPM = amount * clicks;
    }
    if (resource == ListOfResources.GoldFurnace)
    {
      IncomingResourcePerMinute.GoldFurnacesRPM = amount * clicks;
    }
    if (resource == ListOfResources.ToolSmithy)
    {
      IncomingResourcePerMinute.ToolSmithiesRPM = amount * clicks;
    }
    if (resource == ListOfResources.WeaponSmithy)
    {
      IncomingResourcePerMinute.WeaponSmithiesRPM = amount * clicks;
    }
    if (resource == ListOfResources.Barrack)
    {
      IncomingResourcePerMinute.BarracksRPM = amount * clicks;
    }
  }

  void OnClickS()
  {
    //Currency
    if (resource == ListOfResources.Money)
    {
      IncResource.GlobalResource.Money            += IncomingResourcePerMinute.MoneyRPM;
    }

    //Materials
    if (resource == ListOfResources.Wood)
    {
      IncResource.GlobalResource.Wood             += IncomingResourcePerMinute.WoodRPM;
    }
    if (resource == ListOfResources.Plank)
    {
      IncResource.GlobalResource.Planks           += IncomingResourcePerMinute.PlanksRPM;
    }
    if (resource == ListOfResources.Stone)
    {
      IncResource.GlobalResource.Stone            += IncomingResourcePerMinute.StoneRPM;
    }
    if (resource == ListOfResources.IronBar)
    {
      IncResource.GlobalResource.IronBars         += IncomingResourcePerMinute.IronBarsRPM;
    }
    if (resource == ListOfResources.GoldBar)
    {
      IncResource.GlobalResource.GoldBars         += IncomingResourcePerMinute.GoldBarsRPM;
    }
    if (resource == ListOfResources.Tree)
    {
      IncResource.GlobalResource.Trees            += IncomingResourcePerMinute.TreesRPM;
    }
    if (resource == ListOfResources.Coal)
    {
      IncResource.GlobalResource.Coal             += IncomingResourcePerMinute.CoalRPM;
    }
    if (resource == ListOfResources.IronOre)
    {
      IncResource.GlobalResource.IronOre          += IncomingResourcePerMinute.IronOreRPM;
    }
    if (resource == ListOfResources.GoldOre)
    {
      IncResource.GlobalResource.GoldOre          += IncomingResourcePerMinute.GoldOreRPM;
    }
    if (resource == ListOfResources.Wheat)
    {
      IncResource.GlobalResource.Wheat            += IncomingResourcePerMinute.WheatRPM;
    }
    if (resource == ListOfResources.Grain)
    {
      IncResource.GlobalResource.Grain            += IncomingResourcePerMinute.GrainRPM;
    }
    if (resource == ListOfResources.Bread)
    {
      IncResource.GlobalResource.Bread            += IncomingResourcePerMinute.BreadRPM;
    }
    if (resource == ListOfResources.Pig)
    {
      IncResource.GlobalResource.Pigs             += IncomingResourcePerMinute.PigsRPM;
    }
    if (resource == ListOfResources.Meat)
    {
      IncResource.GlobalResource.Meat             += IncomingResourcePerMinute.MeatRPM;
    }
    if (resource == ListOfResources.Water)
    {
      IncResource.GlobalResource.Water            += IncomingResourcePerMinute.WaterRPM;
    }
    if (resource == ListOfResources.Fish)
    {
      IncResource.GlobalResource.Fish             += IncomingResourcePerMinute.FishRPM;
    }

    //Tools
    if (resource == ListOfResources.Hammer)
    {
      IncResource.GlobalResource.Hammers          += IncomingResourcePerMinute.HammersRPM;
    }
    if (resource == ListOfResources.Axe)
    {
      IncResource.GlobalResource.Axes             += IncomingResourcePerMinute.AxesRPM;
    }
    if (resource == ListOfResources.Pickaxe)
    {
      IncResource.GlobalResource.Pickaxes         += IncomingResourcePerMinute.PickaxesRPM;
    }
    if (resource == ListOfResources.Saw)
    {
      IncResource.GlobalResource.Saws             += IncomingResourcePerMinute.SawsRPM;
    }
    if (resource == ListOfResources.Scythe)
    {
      IncResource.GlobalResource.Scythes          += IncomingResourcePerMinute.ScythesRPM;
    }

    //Weaponry
    if (resource == ListOfResources.Sword)
    {
      IncResource.GlobalResource.Swords           += IncomingResourcePerMinute.SwordsRPM;
    }
    if (resource == ListOfResources.Bow)
    {
      IncResource.GlobalResource.Bows             += IncomingResourcePerMinute.BowsRPM;
    }
    if (resource == ListOfResources.Arrow)
    {
      IncResource.GlobalResource.Arrows           += IncomingResourcePerMinute.ArrowsRPM;
    }
    if (resource == ListOfResources.Armour)
    {
      IncResource.GlobalResource.Armours          += IncomingResourcePerMinute.ArmoursRPM;
    }

    //Essencials
    if (resource == ListOfResources.FreeVilliager)
    {
      IncResource.GlobalResource.FreeVilliagers   += IncomingResourcePerMinute.FreeVilliagersRPM;
    }
    if (resource == ListOfResources.Builder)
    {
      IncResource.GlobalResource.Builders         += IncomingResourcePerMinute.BuildersRPM;
    }
    if (resource == ListOfResources.Woodcutter)
    {
      IncResource.GlobalResource.Woodcutters      += IncomingResourcePerMinute.WoodcuttersRPM;
    }
    if (resource == ListOfResources.Forester)
    {
      IncResource.GlobalResource.Foresters        += IncomingResourcePerMinute.ForestersRPM;
    }
    if (resource == ListOfResources.Stonecutter)
    {
      IncResource.GlobalResource.Stonecutters     += IncomingResourcePerMinute.StonecuttersRPM;
    }
    if (resource == ListOfResources.Sawmiller)
    {
      IncResource.GlobalResource.Sawmillers       += IncomingResourcePerMinute.SawmillersRPM;
    }

    //Miners
    if (resource == ListOfResources.CoalMiner)
    {
      IncResource.GlobalResource.CoalMiners       += IncomingResourcePerMinute.CoalMinersRPM;
    }
    if (resource == ListOfResources.IronMiner)
    {
      IncResource.GlobalResource.IronMiners       += IncomingResourcePerMinute.IronMinersRPM;
    }
    if (resource == ListOfResources.GoldMiner)
    {
      IncResource.GlobalResource.GoldMiners       += IncomingResourcePerMinute.GoldMinersRPM;
    }

    //Workers
    if (resource == ListOfResources.WheatFarmer)
    {
      IncResource.GlobalResource.WheatFarmers     += IncomingResourcePerMinute.WheatFarmersRPM;
    }
    if (resource == ListOfResources.WheatMiller)
    {
      IncResource.GlobalResource.WheatMillers     += IncomingResourcePerMinute.WheatMillersRPM;
    }
    if (resource == ListOfResources.Baker)
    {
      IncResource.GlobalResource.Bakers           += IncomingResourcePerMinute.BakersRPM;
    }
    if (resource == ListOfResources.PigFarmer)
    {
      IncResource.GlobalResource.PigFarmers       += IncomingResourcePerMinute.PigFarmersRPM;
    }
    if (resource == ListOfResources.Butcher)
    {
      IncResource.GlobalResource.Butchers         += IncomingResourcePerMinute.ButchersRPM;
    }
    if (resource == ListOfResources.Waterworker)
    {
      IncResource.GlobalResource.Waterworkers     += IncomingResourcePerMinute.WaterworkersRPM;
    }
    if (resource == ListOfResources.Fisherman)
    {
      IncResource.GlobalResource.Fishermans       += IncomingResourcePerMinute.FishermansRPM;
    }

    //Forges
    if (resource == ListOfResources.IronSmelter)
    {
      IncResource.GlobalResource.IronSmelters     += IncomingResourcePerMinute.IronSmeltersRPM;
    }
    if (resource == ListOfResources.GoldSmelter)
    {
      IncResource.GlobalResource.GoldSmelters     += IncomingResourcePerMinute.GoldSmeltersRPM;
    }
    if (resource == ListOfResources.Toolsmith)
    {
      IncResource.GlobalResource.Toolsmiths       += IncomingResourcePerMinute.ToolsmithsRPM;
    }
    if (resource == ListOfResources.Weaponsmith)
    {
      IncResource.GlobalResource.Weaponsmiths     += IncomingResourcePerMinute.WeaponsmithsRPM;
    }

    //Soldiers
    if (resource == ListOfResources.Swordsman)
    {
      IncResource.GlobalResource.Swordsmans       += IncomingResourcePerMinute.SwordsmansRPM;
    }
    if (resource == ListOfResources.Archer)
    {
      IncResource.GlobalResource.Archers          += IncomingResourcePerMinute.ArchersRPM;
    }
    if (resource == ListOfResources.Commander)
    {
      IncResource.GlobalResource.Commanders       += IncomingResourcePerMinute.CommandersRPM;
    }

    //Buildings
    if (resource == ListOfResources.WoodcuttersHut)
    {
      IncResource.GlobalResource.WoodcuttersHuts  += IncomingResourcePerMinute.WoodcuttersHutsRPM;
    }
    if (resource == ListOfResources.Sawmill)
    {
      IncResource.GlobalResource.Sawmills         += IncomingResourcePerMinute.SawmillsRPM;
    }
    if (resource == ListOfResources.ForestersHut)
    {
      IncResource.GlobalResource.ForestersHuts    += IncomingResourcePerMinute.ForestersHutsRPM;
    }
    if (resource == ListOfResources.StonecuttersHut)
    {
      IncResource.GlobalResource.StonecuttersHuts += IncomingResourcePerMinute.StonecuttersHutsRPM;
    }
    if (resource == ListOfResources.CoalMine)
    {
      IncResource.GlobalResource.CoalMines        += IncomingResourcePerMinute.CoalMinesRPM;
    }
    if (resource == ListOfResources.IronOreMine)
    {
      IncResource.GlobalResource.IronOreMines     += IncomingResourcePerMinute.IronOreMinesRPM;
    }
    if (resource == ListOfResources.GoldMine)
    {
      IncResource.GlobalResource.GoldMines        += IncomingResourcePerMinute.GoldMinesRPM;
    }
    if (resource == ListOfResources.WheatFarm)
    {
      IncResource.GlobalResource.WheatFarms       += IncomingResourcePerMinute.WheatFarmsRPM;
    }
    if (resource == ListOfResources.WheatMill)
    {
      IncResource.GlobalResource.WheatMills       += IncomingResourcePerMinute.WheatMillsRPM;
    }
    if (resource == ListOfResources.Bakery)
    {
      IncResource.GlobalResource.Bakeries         += IncomingResourcePerMinute.BakeriesRPM;
    }
    if (resource == ListOfResources.PigFarm)
    {
      IncResource.GlobalResource.PigFarms         += IncomingResourcePerMinute.PigFarmsRPM;
    }
    if (resource == ListOfResources.Slaughterhouse)
    {
      IncResource.GlobalResource.Slaughterhouses  += IncomingResourcePerMinute.SlaughterhousesRPM;
    }
    if (resource == ListOfResources.Waterworks)
    {
      IncResource.GlobalResource.Water += IncomingResourcePerMinute.WaterRPM;
    }
    if (resource == ListOfResources.FishermansHut)
    {
      IncResource.GlobalResource.FishermansHuts   += IncomingResourcePerMinute.FishermansHutsRPM;
    }
    if (resource == ListOfResources.IronFurnace)
    {
      IncResource.GlobalResource.IronFurnaces     += IncomingResourcePerMinute.IronFurnacesRPM;
    }
    if (resource == ListOfResources.GoldFurnace)
    {
      IncResource.GlobalResource.GoldFurnaces     += IncomingResourcePerMinute.GoldFurnacesRPM;
    }
    if (resource == ListOfResources.ToolSmithy)
    {
      IncResource.GlobalResource.ToolSmithies     += IncomingResourcePerMinute.ToolSmithiesRPM;
    }
    if (resource == ListOfResources.WeaponSmithy)
    {
      IncResource.GlobalResource.WeaponSmithies += IncomingResourcePerMinute.WeaponSmithiesRPM;
    }
    if (resource == ListOfResources.Barrack)
    {
      IncResource.GlobalResource.Barracks += IncomingResourcePerMinute.WeaponSmithiesRPM;
    }
  }

  void OnClick()
  {
    //Currency
    if (resource == ListOfResources.Money)
    {
      IncResource.GlobalResource.Money            +=   amount;
    }

    //Materials
    if (resource == ListOfResources.Wood)
    {
      IncResource.GlobalResource.Wood             +=   amount;
    }
    if (resource == ListOfResources.Plank)
    {
      IncResource.GlobalResource.Planks           +=   amount;
      //float item = IncResource.GlobalResource.Planks;
    }
    if (resource == ListOfResources.Stone)
    {
      IncResource.GlobalResource.Stone            +=   amount;
    }
    if (resource == ListOfResources.IronBar)
    {
      IncResource.GlobalResource.IronBars         +=   amount;
    }
    if (resource == ListOfResources.GoldBar)
    {
      IncResource.GlobalResource.GoldBars         +=   amount;
    }
    if (resource == ListOfResources.Tree)
    {
      IncResource.GlobalResource.Trees            +=   amount;
    }
    if (resource == ListOfResources.Coal)
    {
      IncResource.GlobalResource.Coal             +=   amount;
    }
    if (resource == ListOfResources.IronOre)
    {
      IncResource.GlobalResource.IronOre          +=   amount;
    }
    if (resource == ListOfResources.GoldOre)
    {
      IncResource.GlobalResource.GoldOre          +=   amount;
    }
    if (resource == ListOfResources.Wheat)
    {
      IncResource.GlobalResource.Wheat            +=   amount;
    }
    if (resource == ListOfResources.Grain)
    {
      IncResource.GlobalResource.Grain            +=   amount;
    }
    if (resource == ListOfResources.Bread)
    {
      IncResource.GlobalResource.Bread            +=   amount;
    }
    if (resource == ListOfResources.Pig)
    {
      IncResource.GlobalResource.Pigs             +=   amount;
    }
    if (resource == ListOfResources.Meat)
    {
      IncResource.GlobalResource.Meat             +=   amount;
    }
    if (resource == ListOfResources.Water)
    {
      IncResource.GlobalResource.Water            +=   amount;
    }
    if (resource == ListOfResources.Fish)
    {
      IncResource.GlobalResource.Fish             +=   amount;
    }

    //Tools
    if (resource == ListOfResources.Hammer)
    {
      IncResource.GlobalResource.Hammers          +=   amount;
    }
    if (resource == ListOfResources.Axe)
    {
      IncResource.GlobalResource.Axes             +=   amount;
    }
    if (resource == ListOfResources.Pickaxe)
    {
      IncResource.GlobalResource.Pickaxes         +=   amount;
    }
    if (resource == ListOfResources.Saw)
    {
      IncResource.GlobalResource.Saws             +=   amount;
    }
    if (resource == ListOfResources.Scythe)
    {
      IncResource.GlobalResource.Scythes          +=   amount;
    }

    //Weaponry
    if (resource == ListOfResources.Sword)
    {
      IncResource.GlobalResource.Swords           +=   amount;
    }
    if (resource == ListOfResources.Bow)
    {
      IncResource.GlobalResource.Bows             +=   amount;
    }
    if (resource == ListOfResources.Arrow)
    {
      IncResource.GlobalResource.Arrows           +=   amount;
    }
    if (resource == ListOfResources.Armour)
    {
      IncResource.GlobalResource.Armours          +=   amount;
    }

    //Essencials
    if (resource == ListOfResources.FreeVilliager)
    {
      IncResource.GlobalResource.FreeVilliagers   +=   amount;
    }
    if (resource == ListOfResources.Builder)
    {
      IncResource.GlobalResource.Builders         +=   amount;
    }
    if (resource == ListOfResources.Woodcutter)
    {
      IncResource.GlobalResource.Woodcutters      +=   amount;
    }
    if (resource == ListOfResources.Forester)
    {
      IncResource.GlobalResource.Foresters        +=   amount;
    }
    if (resource == ListOfResources.Stonecutter)
    {
      IncResource.GlobalResource.Stonecutters     +=   amount;
    }
    if (resource == ListOfResources.Sawmiller)
    {
      IncResource.GlobalResource.Sawmillers       +=   amount;
    }

    //Milers
    if (resource == ListOfResources.CoalMiner)
    {
      IncResource.GlobalResource.CoalMiners       +=   amount;
    }
    if (resource == ListOfResources.IronMiner)
    {
      IncResource.GlobalResource.IronMiners       +=   amount;
    }
    if (resource == ListOfResources.GoldMiner)
    {
      IncResource.GlobalResource.GoldMiners       +=   amount;
    }

    //Workers
    if (resource == ListOfResources.WheatFarmer)
    {
      IncResource.GlobalResource.WheatFarmers      +=   amount;
    }
    if (resource == ListOfResources.WheatMiller)
    {
      IncResource.GlobalResource.WheatMillers     +=   amount;
    }
    if (resource == ListOfResources.PigFarmer)
    {
      IncResource.GlobalResource.PigFarmers       +=   amount;
    }
    if (resource == ListOfResources.Butcher)
    {
      IncResource.GlobalResource.Butchers         +=   amount;
    }
    if (resource == ListOfResources.Waterworker)
    {
      IncResource.GlobalResource.Waterworkers     +=   amount;
    }
    if (resource == ListOfResources.Fisherman)
    {
      IncResource.GlobalResource.Fishermans       +=   amount;
    }

    //Forges
    if (resource == ListOfResources.IronSmelter)
    {
      IncResource.GlobalResource.IronSmelters     +=   amount;
    }
    if (resource == ListOfResources.GoldSmelter)
    {
      IncResource.GlobalResource.GoldSmelters     +=   amount;
    }
    if (resource == ListOfResources.Toolsmith)
    {
      IncResource.GlobalResource.Toolsmiths       +=   amount;
    }
    if (resource == ListOfResources.Weaponsmith)
    {
      IncResource.GlobalResource.Weaponsmiths     +=   amount;
    }

    //Soldiers
    if (resource == ListOfResources.Swordsman)
    {
      IncResource.GlobalResource.Swordsmans       +=   amount;
    }
    if (resource == ListOfResources.Archer)
    {
      IncResource.GlobalResource.Archers          +=   amount;
    }
    if (resource == ListOfResources.Commander)
    {
      IncResource.GlobalResource.Commanders       +=   amount;
    }

    //Buildings
    if (resource == ListOfResources.WoodcuttersHut)
    {
      IncResource.GlobalResource.WoodcuttersHuts  +=   amount;
    }
    if (resource == ListOfResources.Sawmill)
    {
      IncResource.GlobalResource.Sawmills         +=   amount;
    }
    if (resource == ListOfResources.ForestersHut)
    {
      IncResource.GlobalResource.ForestersHuts    +=   amount;
    }
    if (resource == ListOfResources.StonecuttersHut)
    {
      IncResource.GlobalResource.StonecuttersHuts +=   amount;
    }
    if (resource == ListOfResources.CoalMine)
    {
      IncResource.GlobalResource.CoalMines        +=   amount;
    }
    if (resource == ListOfResources.IronOreMine)
    {
      IncResource.GlobalResource.IronOreMines     +=   amount;
    }
    if (resource == ListOfResources.GoldMine)
    {
      IncResource.GlobalResource.GoldMines        +=   amount;
    }
    if (resource == ListOfResources.WheatFarm)
    {
      IncResource.GlobalResource.WheatFarms       +=   amount;
    }
    if (resource == ListOfResources.WheatMill)
    {
      IncResource.GlobalResource.WheatMills       +=   amount;
    }
    if (resource == ListOfResources.Bakery)
    {
      IncResource.GlobalResource.Bakeries         +=   amount;
    }
    if (resource == ListOfResources.PigFarm)
    {
      IncResource.GlobalResource.PigFarms         +=   amount;
    }
    if (resource == ListOfResources.Slaughterhouse)
    {
      IncResource.GlobalResource.Slaughterhouses  +=   amount;
    }
    if (resource == ListOfResources.Waterworks)
    {
      IncResource.GlobalResource.Waterworks += amount;
    }
    if (resource == ListOfResources.FishermansHut)
    {
      IncResource.GlobalResource.FishermansHuts   +=   amount;
    }
    if (resource == ListOfResources.IronFurnace)
    {
      IncResource.GlobalResource.IronFurnaces     +=   amount;
    }
    if (resource == ListOfResources.GoldFurnace)
    {
      IncResource.GlobalResource.GoldFurnaces     +=   amount;
    }
    if (resource == ListOfResources.ToolSmithy)
    {
      IncResource.GlobalResource.ToolSmithies     +=   amount;
    }
    if (resource == ListOfResources.Barrack)
    {
      IncResource.GlobalResource.Barracks += amount;
    }
  }
}
