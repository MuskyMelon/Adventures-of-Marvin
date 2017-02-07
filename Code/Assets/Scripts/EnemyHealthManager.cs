using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;
    private Experience exp;
    public int experience;
    private float Money;
    public float Money_Min;
    public float Money_Max;
    public string Enemy;
    private int SlimeCounter;
    private int MummyCounter;
    private int BossCounter;
    private int ZombieCounter;
    private QuestScript Quest;
    private GameController Game;
    private bool xp;

    // Use this for initialization
    void Start()
    {

        exp = FindObjectOfType<Experience>();
        Game = FindObjectOfType<GameController>();
        Quest = FindObjectOfType<QuestScript>();


        if (Enemy == "")
        {
            Enemy = "Slime";
        } 

        if(Enemy == "Slime")
        {
            SlimeCounter = 1;
        }

        if (Enemy == "Zombie")
        {
            ZombieCounter = 1;
        }
        if (Enemy == "Mummy")
        {
            MummyCounter = 1;
        }

        if (Enemy == "Spike")
        {
            BossCounter = 1;
        }


        if (experience == 0)
        {
            experience = 10;
        }

        if (Money_Min == 0)
        {
            Money_Min = 2;
        }
        if (Money_Max == 0)
        {
            Money_Max = 10;
        }

       
        CurrentHealth = MaxHealth;

        Quest.MaxZombie += ZombieCounter;
        Quest.MaxSlimes += SlimeCounter;
        Quest.MaxBoss += BossCounter;
        Quest.MaxMummy += MummyCounter;
    }

    // Update is called once per frame
    void Update()
    {

        if (CurrentHealth <= 0)
        {
            Money += Random.Range(Money_Min, Money_Max);
            Game.Money += Money;
            exp.playerCurrentExperience += experience;
            Quest.ZombieCounter += ZombieCounter;
            Quest.SlimeCounter += SlimeCounter;
            Quest.BossCounter += BossCounter;
            Quest.MummyCounter += MummyCounter;
            Destroy(gameObject);

        }

    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        CurrentHealth = CurrentHealth;
    }
}
