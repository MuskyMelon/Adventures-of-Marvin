using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Slider healthBar;
    public Slider experiencebar;
    public Slider QuestBar;
    public Text HPText;
    public Text ExperienceText;
    public Text QuestText;
    public Text GoldText;
    public Text QuestName;
    public Text Level;
    public PlayerHealthManager playerHealth;
    public GameController Game;
    public Experience Exp;
    public QuestScript quest;
    public Button close;
    public Button Home;
    public Button settings;
    public GameObject menu;
    private bool isShowing;
    public GameObject toggles;
    public GameObject Buttons;
    private bool settingtrue;
    public Button Save;
    public Button load;
    public GameObject inv;
    public bool Aan;
    public bool Aan2;

    private static bool UIExists;

    // Use this for initialization
    void Start()
    {
        Game = FindObjectOfType<GameController>();
        settingtrue = false;
        if (!UIExists)
        {
            UIExists = true;
          //  DontDestroyOnLoad(transform.gameObject);
        }



        else
        {
         //   Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        GoldText.text = "Money: " + Game.Money.ToString("0.00");

        experiencebar.maxValue = Exp.playerMaxExperience;
        experiencebar.value = Exp.playerCurrentExperience;
        ExperienceText.text = "Exp: " + Exp.playerCurrentExperience + "/" + Exp.playerMaxExperience;

        QuestName.text = quest.questName;
        QuestBar.maxValue = quest.barmax;
        QuestBar.value = quest.barmin;
        QuestText.text = quest.questOmschrijving + " " + quest.barmin + "/" + quest.barmax;

        healthBar.maxValue = playerHealth.playerMaxHealth;
        healthBar.value = playerHealth.playerCurrentHealth;
        HPText.text = "HP: " + playerHealth.playerCurrentHealth + "/" + playerHealth.playerMaxHealth;

        Level.text = "" + Exp.level + "";

        if (Input.GetKeyDown(KeyCode.Escape) && Aan == false)
        {
            isShowing = !isShowing;
            menu.SetActive(isShowing);
            
            

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                Aan2 = true;
            }
            else
            {
                Time.timeScale = 1;
                Aan2 = false;
            }
           
    

        }

        if (Input.GetKeyDown(KeyCode.I) && Aan2 == false)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                inv.SetActive(true);
                Aan = true;
                
            }
            else if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                inv.SetActive(false);
                Aan = false;
            }

        }
    }
  
  
}

