using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour {

    public Image ProgressBar;
    public Text DisplayText;
    
    public float MaxDurration;
    private float Durration;

    public void PressedButton()
    {
        Durration = MaxDurration;
        Update();
    }

    void Update()
    {
        if (Durration > 0)
        {
            float timer = Time.deltaTime;
            Durration -= timer * ( 1+ (1/2) * IncResource.GlobalResource.Builders);
            ProgressBar.fillAmount = Durration / MaxDurration;
            DisplayText.text = Durration.ToString("0") + "Sek";
        } if (Durration < 0)
        {
            Durration = 0;

        }
    }


    //public void Start()
    //{
    //    Durration = MaxDurration;

    //    UpdateBar();
    //}

    //private void UpdateBar()
    //{
    //    float ratio = Durration / MaxDurration;
    //    ProgressBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
    //    RatioText.text = (Durration).ToString();
    //}

    //private void ReductionTime(float timer)
    //{
    //    timer = Time.deltaTime;
    //    Durration -= timer;
    //    if (Durration < 0)
    //    {
    //        Durration = 0;
    //        Debug.Log("It's done!");
    //    }
    //}
}
