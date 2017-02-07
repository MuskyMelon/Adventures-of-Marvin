using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {

    public string levelToLoad;

    public string exitPoint;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Application.LoadLevel(levelToLoad);
            //Application.SceneManager(levelToLoad);
            //SceneManager.LoadScene(levelToLoad);
            //thePlayer.startPoint = exitPoint;

        }
    }
}
