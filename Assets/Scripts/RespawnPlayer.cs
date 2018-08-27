using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour {

    [SerializeField]Transform spawnPoint;

    LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Triggered when something collides with this guy.
    void OnCollisionEnter2D(Collision2D col)
    {
        // If the tagged object is the player we can reset his
        // position to the provided spawnPoint.
        if (col.transform.CompareTag("Player")) {
            int score = levelManager.score;
            Debug.Log("score " + score);
            Debug.Log("score " + (score - 1));

            levelManager.UpdateScore(score - 1);

            col.transform.position = spawnPoint.position;
        }
    }
}
