using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Experience : MonoBehaviour {

    public int playerMaxExperience;
    public int playerCurrentExperience;
    private PlayerHealthManager playerhealth;
    public int level;
    public HurtEnemy hurtenemy;


    public int playerMinGain;
    public int playerMaxGain;
    public int damageMinGain;
    public int damageMaxGain;
    public int swordbonus;

    // Use this for initialization
    void Start () {
        level = 1;
        playerhealth = FindObjectOfType<PlayerHealthManager>();
        playerMinGain = 10;
        playerMaxGain = 30;
        damageMinGain = 1;
        damageMaxGain = 3;
        swordbonus = 1;

    }

    // Update is called once per frame
    void Update () {
        if (playerCurrentExperience >= playerMaxExperience)
        {
            playerCurrentExperience = playerCurrentExperience - playerMaxExperience;
            playerMaxExperience += 20;
            playerhealth.playerMaxHealth += Random.Range(playerMinGain, playerMaxGain);
            level += 1;
            hurtenemy.damageToGive += Random.Range(damageMinGain, damageMaxGain);
            playerMinGain += 10;
            playerMaxGain += 10;
            damageMinGain += 1;
            damageMaxGain += 1;
        }
    }
}
