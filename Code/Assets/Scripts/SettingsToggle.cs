using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsToggle : MonoBehaviour {

    public Toggle Blood;
    public bool bloodactive;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Blood.isOn)
        {
            bloodactive = true;
        }
        else
        {
            bloodactive = false;
        }
	}
}
