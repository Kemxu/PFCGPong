using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Border : MonoBehaviour {

    //This is my Level manager being set as Manager to be used//
    private LevelManager Manager;

    public Text P1Score;

    private int P1 = 0;

    //This shows me in the console with what the ball has potentially hit//
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with object: " + collision.gameObject.name);
    }

    //This when the ball will hit the trigger, will add a score.//
    void OnTriggerEnter2D(Collider2D collision)
    {
        P1++;
        print("P1 Scores: " + P1);

    }

    void Start()
    {
        Manager = GameObject.FindObjectOfType<LevelManager>();

    }
}
