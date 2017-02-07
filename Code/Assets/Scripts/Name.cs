using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour {

    public string Naam;
    public InputField NameInput;



	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        Naam = NameInput.text;
        if(Naam == null)
        {
            Naam = "Marvin";
        }
	}
}
