using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI scoreText;
    public void DisplayHighScore(string name, int score)
    {
        nameText.text = name;
        Debug.Log(name);
        scoreText.text = string.Format("{0:0}", score);
        Debug.Log(score);
    }
    public void HideEntryDisplay()
    {
        nameText.text = "";
        scoreText.text = "";
    }
}
