using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score;
    public TMP_Text time;


    float currentTime = 0;
    float startingTime = 60;

    public void updateScore(int updates) {
        scoreValue += updates;
        score.text = "Score: " + scoreValue;
    }

    public void Start() {
        currentTime = startingTime;
    }

    public void Update() {
        currentTime = currentTime - 1 * Time.deltaTime;
        if (currentTime > 0) {
            time.text = (int)currentTime+"";
        }
    }



}
