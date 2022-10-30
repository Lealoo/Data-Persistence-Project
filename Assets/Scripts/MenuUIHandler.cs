using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    private MainManager gameManager;
    public TMP_InputField nameInputField;
    public string text;
    public TextMeshProUGUI bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Env.bestScores = XMLManager.instance.LoadScores();
        //text = nameInputField.text;
        if(Env.bestScores.Count >0)
        {
            bestScoreText.text = "Best Score : " + Env.bestScores[0].name + " : " + Env.bestScores[0].score;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Env.playerName = nameInputField.text;
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void HighScoresBoard()
    {
        SceneManager.LoadScene(2);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
