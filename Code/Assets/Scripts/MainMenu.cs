using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    void Awake()
    {

    }



    // Use this for initialization
    void Start () {
        GameObject o = GameObject.Find("GameCanvas");
        if (o != null)
        {
            o.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
