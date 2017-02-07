using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour
{


    public int DialoogNummer;
    public int TextVolgorde;
    public GameObject DialoogBox;
    public Text Dialoog;
    public Text Charname;
    public GameObject Mark;
    public GameObject Normaal;
    private string Name;
    private Name naam;
    private bool TimeOn;
    public GameObject char2;


    // Use this for initialization
    void Start()
    {
        TextVolgorde = 0;
        DialoogNummer = 0;
        naam = FindObjectOfType<Name>();
        Name = naam.Naam;
        TextVolgorde = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Name == "Mark de Haan")
        {
            Normaal.SetActive(false);
            Mark.SetActive(true);
        }
        else
        {
            Normaal.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && DialoogNummer >= 1)
        {
            TextVolgorde += 1;
        }

        if (DialoogNummer == 0)
        {
            Charname.text = "Weird Ghost that looks like you";
            DialoogBox.SetActive(false);
            if (TimeOn == false)
            {
                Time.timeScale = 1;
                TimeOn = true;
            }
          
            TextVolgorde = 1;

        }

        else if (DialoogNummer == 1)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "Hello " + Name + " Welcome to the town of Brookville!";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Brookville Needs a hero and you are the chosen one. We have left your sword in your house, can you please get it for us?";
            }
            else if (TextVolgorde == 3)
            {
                DialoogNummer = 0;
            }
        }

        else if (DialoogNummer == 2)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "Okay now that you have your sword let me give you a quick tutorial on how to use it.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Press <b>J</b> to use your sword, and press <b>P</b> to use your potions (if you have any).";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "If you want to check how many potions you have press <b>I</b> to open your inventory.";
            }
            else if (TextVolgorde == 4)
            {
                Dialoog.text = "That's it, i'm hearing some slimes let's see if you know how to wield that sword " + Name + " !";
            }
            else if (TextVolgorde == 5)
            {
                DialoogNummer = 0;
            }
        }

        else if (DialoogNummer == 3)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "I see you have mastered the basics. Now we know that you are the hero.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Some townsfolk came by earlier to tell me that there was giant Zombie behind the caves.";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "So your second quest is to kill it, people fear it will come to the town if we dont do anything.";
            }
            else if (TextVolgorde == 4)
            {
                DialoogNummer = 0;
            }
        }

        else if (DialoogNummer == 4)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "You have proven yourself once again brave hero.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "When you killed the giant zombie he dropped a key.";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "The key has a note with it that says: 'Go to the temple.'";
            }
            else if (TextVolgorde == 4)
            {
                Dialoog.text = "What a weird note...";
            }
            else if (TextVolgorde == 5)
            {
                DialoogNummer = 0;
            }
        }
        else if (DialoogNummer == 5)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "Well here we are now what.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Wait i think this is the temple with the ancient Destroyer of the legends.";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "I have heard this temple is full of mummies and that you need to kill them.";
            }
            else if (TextVolgorde == 4)
            {
                Dialoog.text = "That is the only way to summon the Destroyer. Good luck!";
            }
            else if (TextVolgorde == 5)
            {
                DialoogNummer = 0;
            }
        }
        else if (DialoogNummer == 6)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "Now they are all finally dead.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Oh no i think i hear the Destroyer comming!";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "Time to fulfill your destiny hero slay the Destoryer!";
            }
            else if (TextVolgorde == 4)
            {
                DialoogNummer = 0;
            }
        }

        else if (DialoogNummer == 7)
        {
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "You did it hero the land is free of monsters again.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "Now it's time to settle down and start a life.";
            }
            else if (TextVolgorde == 3)
            {
                Dialoog.text = "Thank you for al you have done.";
            }
            else if (TextVolgorde == 4)
            {
                DialoogNummer = 0;
            }
        }
          else if (DialoogNummer == 99)
        {
            Charname.text = "Merchant";
            Normaal.SetActive(false);
            Mark.SetActive(false);
            char2.SetActive(true);
            TimeOn = false;
            Time.timeScale = 0;
            DialoogBox.SetActive(true);
            if (TextVolgorde == 1)
            {
                Dialoog.text = "Dear hero you need 500 coins to get this sword.";
            }
            else if (TextVolgorde == 2)
            {
                Dialoog.text = "(press <b>I</b> to see how many coins you have.)";
            }
           
            else if (TextVolgorde == 3)
            {
                DialoogNummer = 0;
                char2.SetActive(false);
                if (Name == "Mark de Haan")
                {
                    Mark.SetActive(true);
                }
                else
                {
                    Normaal.SetActive(true);
                }
            }
        }

    }


}
