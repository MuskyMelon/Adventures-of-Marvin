using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordQuest : MonoBehaviour {

    public GameObject PlayerSword;
    public GameObject Sword;
    private QuestScript Quest;

	// Use this for initialization
	void Start () {
        Quest = FindObjectOfType<QuestScript>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Quest.Sword += 1;
            Sword.SetActive(false);
        }
    }


}
