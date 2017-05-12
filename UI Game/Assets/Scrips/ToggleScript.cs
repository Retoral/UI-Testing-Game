using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour {

    public Toggle Buildings;
    public Toggle Mines;
    public Toggle Resources;
    public Toggle Tools;
    public Toggle Trade;
    public GameObject buildings;
    public GameObject mines;
    public GameObject resources;
    public GameObject tools;
    public GameObject trade;

    // Update is called once per frame
    void Update () {
		if (Buildings.isOn)
        {
            buildings.gameObject.SetActive(true);
            mines.gameObject.SetActive(false);
            resources.gameObject.SetActive(false);
            tools.gameObject.SetActive(false);
            trade.gameObject.SetActive(false);
        }
        if (Mines.isOn)
        {
            buildings.gameObject.SetActive(false);
            mines.gameObject.SetActive(true);
            resources.gameObject.SetActive(false);
            tools.gameObject.SetActive(false);
            trade.gameObject.SetActive(false);
        }
        if (Resources.isOn)
        {
            buildings.gameObject.SetActive(false);
            mines.gameObject.SetActive(false);
            resources.gameObject.SetActive(true);
            tools.gameObject.SetActive(false);
            trade.gameObject.SetActive(false);
        }
        if (Tools.isOn)
        {
            buildings.gameObject.SetActive(false);
            mines.gameObject.SetActive(false);
            resources.gameObject.SetActive(false);
            tools.gameObject.SetActive(true);
            trade.gameObject.SetActive(false);
        }
        if (Trade.isOn)
        {
            buildings.gameObject.SetActive(false);
            mines.gameObject.SetActive(false);
            resources.gameObject.SetActive(false);
            tools.gameObject.SetActive(false);
            trade.gameObject.SetActive(true);
        }

    }
}
