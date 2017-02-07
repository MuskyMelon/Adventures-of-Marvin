using UnityEngine;
using System.Collections;

public class PlayerStartPoint : MonoBehaviour {

    private PlayerController thePlayer;
    private CameraController theCamera;

    public Vector2 startDirection;

    public string pointName;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePlayer.transform.position = transform.position;

        thePlayer.lastMove = startDirection;

        theCamera = FindObjectOfType<CameraController>();
        theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);

        

        // var players = FindObjectsOfType<PlayerController>();
        // if (players.Length > 1)
        //     thePlayer = players[1];


        if (thePlayer.startPoint == pointName)
        {
            
            //thePlayer.transform.position = transform.position;
            //thePlayer.lastMove = startDirection;

           // theCamera = FindObjectOfType<CameraController>();
           // theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
