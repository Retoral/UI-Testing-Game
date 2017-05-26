using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MNCreateResource : MonoBehaviour
{

  public ListOfResources resource;

  [Header("Resource")]
  public int Amount;



  [Space(10)]

  public bool ResourcePerSecond;

  [Space(10)]

  [Range(1.0f, 60f)]
  public float TimerFrequency;

  public float DurrationMin;
  public float DurrationSek;
  private float MaxDurration;
  private float ResetMin;
  private float ResetSek;

  private Transform _proggressBar;
  private Image _timerBar;
  private Text _displayText;


  int clicks;
  bool inProgress;

  private static Dictionary<ListOfResources, MNResource> _Resources;
  public static Dictionary<ListOfResources, MNResource> GlobalResources
  {
    get
    {
      if (_Resources == null)
      {
        InitResources();
      }
      return _Resources;
    }
  }

  private static void InitResources()
  {
    _Resources = new Dictionary<ListOfResources, MNResource>();

    // Add Resources where we have external Data (Pricing)
    var lines = System.IO.File.ReadAllLines("Assets//BuyAndSell.csv");
    foreach (string line in lines)
    {
      string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
      ListOfResources enumValue = (ListOfResources)Enum.Parse(typeof(ListOfResources), values[0], true);
      float buyPrice = float.Parse(values[1].TrimEnd(';'));
      float sellPrice = float.Parse(values[2].TrimEnd(';'));
      _Resources.Add(enumValue, new MNResource(enumValue, buyPrice, sellPrice));
                                          
    }

    // Add the rest
    foreach (ListOfResources enumValue in Enum.GetValues(typeof(ListOfResources)))
    {
      if (_Resources.ContainsKey(enumValue) == false)
      {
        _Resources.Add(enumValue, new MNResource(enumValue));
      }
    }
  }

  private void Start()
  {
    InitResources();
    ResetMin = DurrationMin;
    ResetSek = DurrationSek;
    MaxDurration = DurrationSek + DurrationMin * 60;
    inProgress = false;
    GetComponent<Button>().onClick.AddListener(OnPressed);
    _proggressBar = transform.FindChild("ProgressBar");
    _timerBar = _proggressBar.FindChild("TimerBar").GetComponent<Image>();
    _displayText = _proggressBar.FindChild("Text").GetComponent<Text>();
    _Resources[ListOfResources.Builder].CurrentAmount = 1;
  }

  public void OnPressed()
  {
    _proggressBar.gameObject.SetActive(true);
    if (inProgress == true)
    {
      Debug.Log("It's already in process");
    }
    else
    {
      inProgress = true;
    }
  }

  int loop = 0;
  void Repeat()
  {
    loop++;
    InvokeRepeating("OnClickS", TimerFrequency, TimerFrequency);
    Debug.Log("Repeated: " + loop + " times.");
  }

  void RepeatList()
  {
    if (GlobalResources.ContainsKey(resource))
    {
      GlobalResources[resource].IncomePerMinute = Amount * clicks;
    }

  }

  void OnClickS()
  {
    if (GlobalResources.ContainsKey(resource))
    {
      GlobalResources[resource].IncomePerMinuteTick();
    }
  }

  void OnClick()
  {
    if (GlobalResources.ContainsKey(resource))
    {
      GlobalResources[resource].CurrentAmount += Amount;
    }

  }


  void Update()
  {
    if (DurrationMin + DurrationSek > 0 && inProgress == true)
    {
      DurrationSek -= Time.deltaTime * (1 + (1 / 2) * GlobalResources[ListOfResources.Builder].CurrentAmount);
      _timerBar.type = Image.Type.Filled;
      _timerBar.fillAmount = (DurrationSek + DurrationMin * 60) / MaxDurration;

      string displayText = _displayText.text = DurrationSek.ToString("0") + " Sek";
      if (DurrationMin > 0)
      {
        displayText = displayText.Insert(0, DurrationMin.ToString("0") + " Min ");
      }
      _displayText.text = displayText;

      if (DurrationSek <= 0 && DurrationMin > 0)
      {
        DurrationMin -= 1;
        DurrationSek = 60;
      }
    }

    else if (DurrationSek < 0 && DurrationMin <= 0)
    {
      DurrationSek = 0;
      inProgress = false;
      _proggressBar.gameObject.SetActive(false);

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

}
