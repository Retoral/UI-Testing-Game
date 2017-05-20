using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddMaterial : MonoBehaviour {

    public Text CurrentAmount;
    public int AmountIncreased;
    public Button PressThis;

    private void Start()
    {
        Button Btn = PressThis.GetComponent<Button>();
        Btn.onClick.AddListener(AddingMaterial);
    }

    public void AddingMaterial()
    {
        int NewAmount = int.Parse(CurrentAmount.text) + AmountIncreased;
        CurrentAmount.text = NewAmount.ToString();
    }
}
