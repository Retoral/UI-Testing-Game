using System;

public class MNResource
{
  public float CurrentAmount { get; set; }
  public float IncomePerMinute { get; set; }
  public float BuyPrice { get; set; }
  public float SellPRice { get; set; }
  public float BuildTime { get; set; }


  public MNResource(ListOfResources name, float currentAmount = 0, float incomePerMinute = 0, float buyPrice = 0.0f, float sellPrice = 0.0f, float buildTime = 0.0f)
  {
    Name = name;
    CurrentAmount = currentAmount;
    IncomePerMinute = incomePerMinute;
    BuyPrice = buyPrice;
    SellPRice = sellPrice;
  }

  public MNResource(string name, float currentAmount = 0.0f, float incomePerMinute = 0.0f)
  {
    try
    {
      Name = (ListOfResources)Enum.Parse(typeof(ListOfResources), name, true);
    }
    catch (ArgumentException)
    {
      Console.Error.WriteLine(name + " is not a valid resource.");
      Name = ListOfResources.Error;
      CurrentAmount = 0.0f;
      IncomePerMinute = 0.0f;
    }
  }

  public ListOfResources Name { get; private set; }
  public string ResourceName
  {
    get
    {
      return Enum.GetName(typeof(ListOfResources), Name);
    }
  }

  public void IncomePerMinuteTick()
  {
    CurrentAmount += IncomePerMinute;
  }

  public override string ToString()
  {
    return Enum.GetName(typeof(ListOfResources), Name);
  }
}

