using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestScript : MonoBehaviour {

    //Standaard
    public int questID;
    public Text QuestComplete;
    public GameObject questo;
    public string questOmschrijving;
    public string questName;
    public int barmin;
    public int barmax;
    public float Timer;
    public StoryScript story;
    private bool Looponce;

    //sword quest
    public int Sword;
    public GameObject PlayerSword;

    //slime quest
    public int SlimeCounter;
    public int MaxSlimes;
    public GameObject Slime;

    //zombie quest
    public int ZombieCounter;
    public int MaxZombie;
    public GameObject Zombie;
    public GameObject Goblin;

    //temple quest 
    public int Templerached;

    //mummy quest 
    public GameObject Mummy;
    public int MummyCounter;
    public int MaxMummy;

    //mummy quest 
    public GameObject Boss;
    public int BossCounter;
    public int MaxBoss;


    // Use this for initialization
    void Start () {
        questID = 1;
        Timer = 2;
        story = FindObjectOfType<StoryScript>();
        Looponce = true;
    }



	
	// Update is called once per frame
	void Update () {
        if (questID == 1)
        {
            if(Looponce == true)
            {
                story.DialoogNummer = 1;
                Looponce = false;
            }
          
            PlayerSword.SetActive(false);
            questName = "Find your sword";
            questOmschrijving = "Swords:";
            barmin = Sword;
            barmax = 1;

        }

        if (questID == 2)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 2;
                Looponce = false;
            }
            PlayerSword.SetActive(true);
            Slime.SetActive(true);
            questName = "Kill all slimes";
            questOmschrijving = "Slimes:";
            barmin = SlimeCounter;
            barmax = 20;

        }
        else if (questID == 3)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 3;
                Looponce = false;
            }
            Slime.SetActive(false);
            Goblin.SetActive(true);
            Zombie.SetActive(true);
            questName = "Kill The Zombie Boss";
            questOmschrijving = "Zombies:";
            barmin = ZombieCounter;
            barmax = MaxZombie;
        }

        else if (questID == 4)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 4;
                Looponce = false;
            }
            questName = "Go to the temple";
            questOmschrijving = "Temple reached:";
            barmin = Templerached;
            barmax = 1;
        }

        else if (questID == 5)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 5;
                Looponce = false;
            }
            Mummy.SetActive(true);
            questName = "Kill all the mummies";
            questOmschrijving = "Mummies killed:";
            barmin = MummyCounter;
            barmax = MaxMummy;
        }

        else if (questID == 6)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 6;
                Looponce = false;
            }
            Boss.SetActive(true);
            questName = "Kill The Spike Endboss";
            questOmschrijving = "Endboss Killed:";
            barmin = BossCounter;
            barmax = MaxBoss;
        }

        else if (questID == 6)
        {
            if (Looponce == true)
            {
                story.DialoogNummer = 7;
                Looponce = false;
            }
            QuestComplete.text = "Game Completed";
        }

        if (barmin == barmax && barmax != 0)
        {
            Timer -= Time.deltaTime;
            questo.SetActive(true);
            QuestComplete.text = "Quest Completed";
            
            if (Timer <= 0)
            {
                questID += 1;
                QuestComplete.text = "";
                Timer = 2;
                questo.SetActive(false);
                Looponce = true;

            }
          
        }
      
		
	}
}
