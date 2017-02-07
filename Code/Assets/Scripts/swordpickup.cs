using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordpickup : MonoBehaviour {

    private GameController game;
    public GameObject Oldsword;
    public GameObject OldInventSword;
    public GameObject NewInventSword;
    public GameObject SwordPickup;
    public GameObject newsword;
    public HurtEnemy HurtE;
    public StoryScript story;
    public bool looponce;
    private float Tijd;
    private Experience exp;

	// Use this for initialization
	void Start () {
        game = FindObjectOfType<GameController>();
        story = FindObjectOfType<StoryScript>();
        HurtE = FindObjectOfType<HurtEnemy>();
        exp = FindObjectOfType<Experience>();
        looponce = true;
        Tijd = 20;
    }
	
	// Update is called once per frame
	void Update () {
        if (looponce == false)
        {
            Tijd -= Time.deltaTime;
        }
        if(Tijd <= 0)
        {
            Tijd = 20;
            looponce = true;
        }
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && game.Money >= 500)
        {
            SwordPickup.SetActive(false);
            Oldsword.SetActive(false);
            OldInventSword.SetActive(false);
            NewInventSword.SetActive(true);
            newsword.SetActive(true);
            game.Money -= 500;         
        }
        else if (other.gameObject.name == "Player" && game.Money < 500)
        {
            if (looponce == true)
            {
                story.DialoogNummer = 99;
                looponce = false;
            }
        }
    }
}
