using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour {

    public Button SaveButton;
    public Button LoadButton;
    public Button QuitGame;
   
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        QuitGame.onClick.AddListener(Quitpress);
        SaveButton.onClick.AddListener(Savepress);
        LoadButton.onClick.AddListener(Loadpress);
    }

    void Quitpress()
    {
       Application.Quit();
    }
    void Savepress()
    {
        Save.saveFile.save();
    }

    void Loadpress()
    {
        Save.saveFile.load();
    }



}
