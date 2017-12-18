using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleP1 : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
        float mousePositionBlocks = (Input.mousePosition.y / Screen.width * 14) - 7f;

        Vector3 p1Position = new Vector3(this.transform.position.x, 0.5f, 0);

        p1Position.y = Mathf.Clamp(mousePositionBlocks, -3.4f, 3.2f);

        this.transform.position = p1Position;
	}
}
