using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleP2 : MonoBehaviour {

	void Start () {
		
	}
	
	//This will make the paddle move with the arrow keys//
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }
    }
}
