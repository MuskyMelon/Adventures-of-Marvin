using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    private PlayerController thePlayer;

    private Camera theCamera;

    public Transform teleportPosition;

    // Use this for initialization
    void Start () {

        thePlayer = FindObjectOfType<PlayerController>();

        theCamera = FindObjectOfType<Camera>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {

            thePlayer.transform.position = teleportPosition.position;
            theCamera.transform.position = new Vector3(teleportPosition.position.x, teleportPosition.position.y, theCamera.transform.position.z);

        }
    }

}
