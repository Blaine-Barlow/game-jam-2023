using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score;

    public void updateScore(int updates){
        scoreValue += updates;
        score.text = "Score: " + scoreValue;

    }



}
