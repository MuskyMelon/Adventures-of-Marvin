using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPotion : MonoBehaviour
{

    private GameController game;

    public GameObject Potion;

    public int Potions;


    // Use this for initialization
    void Start()
    {

        game = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            game.Potions = game.Potions + Potions;
            Potion.SetActive(false);
        }
    }
}