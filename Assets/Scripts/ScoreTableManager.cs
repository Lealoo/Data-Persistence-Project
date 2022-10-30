using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTableManager : MonoBehaviour
{
    public HighScoreDisplay[] highScoreDisplayArray;
    List<HighScoreEntry> scores = new List<HighScoreEntry>();

    // Start is called before the first frame update
    void Start()
    {
        // Adds some test data
        //AddNewScore("John", 4500);
        scores = Env.bestScores;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        scores.Sort((HighScoreEntry x, HighScoreEntry y) => y.score.CompareTo(x.score));
        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(scores[i].name, scores[i].score);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }

    public void AddNewScore(string entryName, int entryScore)
    {
        scores.Add(new HighScoreEntry { name = entryName, score = entryScore });
       
    }
}

public class HighScoreEntry
{
    public string name;
    public int score;
}