using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //Object loader
    public GameObject Monster;
    public GameObject Key1Image;
    public GameObject TempleEntry;
    
    private slowPotion potionEffect;
    private PlayerController thePlayer;

    private bool HeavenKey;
    public PlayerHealthManager Health;
    private GameObject Player;
    public float RespawnTimer;
    private float Tijd;
    private Camera theCamera;
    public Transform MainSpawnPoint;
    public GameObject Gameo;
    public GameObject swordswing;
    public Text Gameover;
    public HealPotion heal;
    public int potsgain;
    public int Potions;
    public int healthgain;

    public float Money;



    // Use this for initialization
    void Start () {
        HeavenKey = false;
        TempleEntry.SetActive(false);
        potionEffect = FindObjectOfType<slowPotion>();
        thePlayer = FindObjectOfType<PlayerController>();
        heal = FindObjectOfType<HealPotion>();
        Health = FindObjectOfType<PlayerHealthManager>();
        
        Player = GameObject.Find("Player");
        theCamera = FindObjectOfType<Camera>();
        Tijd = RespawnTimer;
    }
	
	// Update is called once per frame
	void Update () {

        

        if( Time.timeScale == 0)
        {
            thePlayer.enabled = false;
        }
        else
        {
            thePlayer.enabled = true;
        }

        if (Health.playerCurrentHealth <= 0)
        {
            Player.SetActive(false);
            Tijd -= Time.deltaTime;
            Gameo.SetActive(true);
            Gameover.text = "Game Over";
            swordswing.SetActive(false);
        }

        if (Tijd <= 0)
        {
            Tijd = RespawnTimer;
            Player.SetActive(true);
            Health.playerCurrentHealth = Health.playerMaxHealth;
            Player.transform.position = MainSpawnPoint.position;
            theCamera.transform.position = new Vector3(MainSpawnPoint.position.x, MainSpawnPoint.position.y, theCamera.transform.position.z);
            Gameover.text = "";
            Gameo.SetActive(true);
        }


      /*  if (potionEffect.timeStarter)
        {
            potionEffect.timeActive -= Time.deltaTime;

            if (potionEffect.timeActive <= 0)
            {
                thePlayer.moveSpeed += potionEffect.speedReduce;
                potionEffect.timeStarter = false;
                potionEffect.timeActive = potionEffect.timeActiveStart;
            }
        } */



        if (Monster == false)
        {
            HeavenKey = true;
        }

        if (HeavenKey)
        {
            Key1Image.SetActive(true);
            TempleEntry.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if(Potions > 0)
            {
                Health.playerCurrentHealth = Health.playerCurrentHealth + healthgain;
                Potions -= 1;
                Debug.Log(healthgain);
            }
        }



    }
}
