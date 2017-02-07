using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D myRigidbody;
    private bool moving;
    public float timeBetweenMove;
    private float timeBetweenMoveCounter;
    public float timeToMove;
    private float timeToMoveCounter;
    private Vector3 moveDirection;
    public float waitToReload;

    // Use this for initialization
    void Start () {

        myRigidbody = GetComponent<Rigidbody2D>();
        
        timeBetweenMoveCounter = Random.Range(timeBetweenMove * 0.75f, timeBetweenMove * 1.25f);
        timeToMoveCounter = Random.Range(timeToMove * 0.75f, timeBetweenMove * 1.25f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
