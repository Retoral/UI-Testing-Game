using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateIncomeLabel : MonoBehaviour
{

  [Header("On = Total, Off = Per Min")]
  public bool TotalOrPerMin;
  [Space(10)]
  public Text incResource;
  public ListOfResources resource;

  private void Awake()
  {
    SetRessourceAutomaticly();
  }


  private void SetRessourceAutomaticly()
  {
    if (incResource == null)
    {
      incResource = transform.GetChild(0).GetComponent<Text>();
    }
    try
    {
      resource = (ListOfResources)Enum.Parse(typeof(ListOfResources), transform.name, true);
    }
    catch (ArgumentException)
    {
      Debug.LogError("Parent has name (" + transform.name +") that does not match with ListOfResources");
      resource = ListOfResources.Error;
    }
  }


  void Update()
  {
    if (MNCreateResource.GlobalResources.ContainsKey(resource))
    {
      incResource.text = TotalOrPerMin ? MNCreateResource.GlobalResources[resource].CurrentAmount.ToString()
                                       : MNCreateResource.GlobalResources[resource].IncomePerMinute.ToString();
    }
  }
}
