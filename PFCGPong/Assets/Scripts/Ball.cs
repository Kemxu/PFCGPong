using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	//ball will be moved by 4.5force to a direction//
    [SerializeField]
    float forceValue = 4.5f;
    Rigidbody2D body;
	
	//this will allow that when the game starts, the ball will move in a direction//
	void Start () {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(new Vector2(forceValue * 50, 50));
		
	}
	
	void Update () {
		
	}
}
