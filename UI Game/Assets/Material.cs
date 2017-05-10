using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Material : MonoBehaviour {

    public Text TextOutput;
    public Text Resource;
    public int AmountStored;

	// Use this for initialization
	void Start () {
        TextOutput.text = AmountStored.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
