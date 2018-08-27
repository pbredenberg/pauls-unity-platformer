using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Text scoreText;

    public int score = 0;

    void Start() {
        UpdateScore(0);
    }

    public void UpdateScore(int newScore) {
        score = newScore;
        scoreText.text = "Score: " + newScore;
    }
}
