using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    static SoundManager musicPlayer = null;

    void Awake()
    {
        if (musicPlayer != null)
        {
            Destroy(this.gameObject);

        }
        else
        {
            musicPlayer = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
