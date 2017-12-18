using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField]
    float forceValue = 4.5f;
    Rigidbody2D body;

	void Start () {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(new Vector2(forceValue * 50, 50));
		
	}
	
	void Update () {
		
	}
}
