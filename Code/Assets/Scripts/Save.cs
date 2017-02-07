using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Save : MonoBehaviour {

    public static Save saveFile;
    private Experience exp;
    private PlayerHealthManager health;
    public HurtEnemy hurtenemy;
    public GameObject player;
    private QuestScript quest;
   


    void Awake()
    {
     

        health = FindObjectOfType<PlayerHealthManager>();
        exp = FindObjectOfType<Experience>();
        quest = FindObjectOfType<QuestScript>();
        DontDestroyOnLoad(gameObject);
        saveFile = this; 
    }
    


	public void save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Degame.save");
        PlayerData Data = new PlayerData();

        //data opslaan
        Data.QuestID = quest.questID;
        Data.level = exp.level;
        Data.playerCurrentExperience = exp.playerCurrentExperience;
        Data.playerMaxExperience = exp.playerMaxExperience;
        Data.playerMinGain = exp.playerMinGain;
        Data.playerMaxGain = exp.playerMaxGain;
        Data.damageMinGain = exp.damageMinGain;
        Data.damageMaxGain = exp.damageMaxGain;
        Data.playerCurrentHealth = health.playerCurrentHealth;
        Data.playerMaxHealth = health.playerMaxHealth;
        Data.damageToGive = hurtenemy.damageToGive;
        Data.x = player.transform.position.x;
        Data.y = player.transform.position.y;
        Data.z = player.transform.position.z; 

        //einde
        bf.Serialize(file, Data);
        file.Close();
    }

    public void load()
    {
        if (File.Exists(Application.persistentDataPath + "/Degame.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Degame.save", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            //data ophalen
            exp.level = data.level;
            exp.playerCurrentExperience = data.playerCurrentExperience;
            exp.playerMaxExperience = data.playerMaxExperience;
            exp.playerMinGain = data.playerMinGain;
            exp.playerMaxGain = data.playerMaxGain;
            exp.damageMinGain = data.damageMinGain;
            exp.damageMaxGain = data.damageMaxGain;
            health.playerCurrentHealth = data.playerCurrentHealth;
            health.playerMaxHealth = data.playerMaxHealth;
            hurtenemy.damageToGive = data.damageToGive;
            Vector3 positie = new Vector3(data.x, data.y, data.z);
            player.transform.position = positie;
            quest.questID = data.QuestID;

        }
    }
}

[Serializable]
class PlayerData
{
    public int QuestID;
    public int level;
    public int playerCurrentExperience;
    public int playerMaxExperience;
    public int playerMinGain;
    public int playerMaxGain;
    public int damageMinGain;
    public int damageMaxGain;
    public int playerCurrentHealth;
    public int playerMaxHealth;
    public int damageToGive;
    public float x;
    public float y;
    public float z;
} 
