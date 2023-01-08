using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score;
    public TMP_Text time;
    public TMP_Text highScore;
    public GameObject retry;

    public static int highScoreValue = 0;

    float currentTime = 0;
    float startingTime = 60;

    public void updateScore(int updates) {
        scoreValue += updates;
        if (scoreValue > highScoreValue) {
            highScoreValue = scoreValue;
        }
        score.text = "Score: " + scoreValue;
        highScore.text = "High Score: " + highScoreValue;
    }

    public void Start() {
        currentTime = startingTime;
        // retry.GetComponent<CanvasRenderer>().enabled = false;
        retry.SetActive(false);

    }

    public void Update() {
        currentTime = currentTime - 1 * Time.deltaTime;
        if (currentTime > 0) {
            time.text = (int)currentTime+"";
        }else{
            // retry.GetComponent<>
            retry.SetActive(true);

            Time.timeScale = 0;
            
        }
    }

    public void restart(){
        currentTime = startingTime;
        Time.timeScale = 1;
        scoreValue = 0;
        updateScore(0);
        retry.SetActive(false);

    }



}
