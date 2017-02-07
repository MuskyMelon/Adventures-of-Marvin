using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadOnClick : MonoBehaviour {

    public GameObject slider;
    public GameObject leveltekst;
    public GameObject expslider;
    public GameObject menu;
    public GameObject Panel;
    public Button Quit;

    public GameObject loadingImage;

    public void Update()
    {
        if(Quit != null)
        {
            Quit.onClick.AddListener(QuitNow);
        }
       
    }

    void QuitNow()
    {
        Application.Quit();
    }

    public void LoadScene(int level)
    {
        loadingImage.SetActive(true);
        SceneManager.LoadScene(level);
        if(menu != null)
        {
            menu.SetActive(false);
        }
        Panel.SetActive(false);
        slider.SetActive(false);
        leveltekst.SetActive(false);
        expslider.SetActive(false);

        if (Application.loadedLevel == 0)
        {
            loadingImage.SetActive(false);
        }

    }

    
}
