using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    private PlayerHealthManager health;
    private GameController Game;
    private Experience exp;
    public HurtEnemy Hurt;


    public Text CurrentHealth;
    public Text Pots;
    public Text GainHealth;
    public Text CurrentDamage;
    public Text GainDamage;

    // Use this for initialization
    void Start () {
        Game = FindObjectOfType<GameController>();
        exp = FindObjectOfType<Experience>();
        health = FindObjectOfType<PlayerHealthManager>();
    }
	
	// Update is called once per frame
	void Update () {

        CurrentHealth.text = "Current Health: " + health.playerCurrentHealth + " / " + health.playerMaxHealth;
        GainHealth.text = "Health Gained: " + exp.playerMinGain + " - " + exp.playerMaxGain;
        CurrentDamage.text = "Current Damage: " + Hurt.damageToGive;
        GainDamage.text = "Damage Gained: " + exp.damageMinGain + " - " + exp.damageMaxGain;
        Pots.text = "X " + Game.Potions;


    }
}
