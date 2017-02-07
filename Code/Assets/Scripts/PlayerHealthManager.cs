using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour
{


    public int playerMaxHealth;
    public int playerCurrentHealth;


    private bool flashActive;
    public float flashLength;
    private float flashCounter;
    public GameObject swordslash;
    private QuestScript quest;


    public bool looponce;

    private SpriteRenderer playerSprite;

    // Use this for initialization
    void Start()
    {

        playerCurrentHealth = playerMaxHealth;
        quest = FindObjectOfType<QuestScript>();
        playerSprite = GetComponent<SpriteRenderer>();
        looponce = true;

    }

    // Update is called once per frame
    void Update()
    {



        if (playerCurrentHealth <= 0)
        {
            swordslash.SetActive(false);
            gameObject.SetActive(false);
        }
        if (playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }

        if (flashActive)
        {
            if (flashCounter > flashLength * .66f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }

            flashCounter -= Time.deltaTime;

        }


    }




    public void Hurtplayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;

        flashActive = true;
        flashCounter = flashLength;

    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerCurrentHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (this.gameObject.name == "Player" && other.gameObject.name == "Temple Entry" && looponce == true)
        {
            looponce = false;
            quest.Templerached += 1;

        }

    }
}
