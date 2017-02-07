using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowPotion : MonoBehaviour
{

    public GameObject Potion;

    private PlayerController thePlayer;

    public float speedReduce;

    public float timeActiveStart;

    public float timeActive;

    public bool timeStarter;


    // Use this for initialization
    void Start()
    {
        timeStarter = false;
        thePlayer = FindObjectOfType<PlayerController>();
        timeActive = timeActiveStart;
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            timeStarter = true;
            Potion.SetActive(false);
            thePlayer.moveSpeed -= speedReduce;
        }

    }
}