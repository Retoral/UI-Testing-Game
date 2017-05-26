using System;

public class MNResource
{

  public MNResource(ListOfResources name, float currentAmount = 0, float incomePerMinute = 0)
  {
    Name = name;
    CurrentAmount = currentAmount;
    IncomePerMinute = incomePerMinute;
  }

  public MNResource(string name, float currentAmount = 0, float incomePerMinute = 0)
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

  public float CurrentAmount { get; set; }
  public float IncomePerMinute { get; set; }

  public void IncomePerMinuteTick()
  {
    CurrentAmount += IncomePerMinute;
  }

  public override string ToString()
  {
    return Enum.GetName(typeof(ListOfResources), Name);
  }
}

