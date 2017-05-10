using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FoV : MonoBehaviour {

    public new Camera camera;
    public Text text;
    public Slider slider;

    
    void Update () {

        camera.fieldOfView = slider.value;
        text.text = camera.fieldOfView.ToString();
        Debug.Log("FOV: " + camera.fieldOfView);

	}
}
