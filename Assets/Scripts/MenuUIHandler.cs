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

    // Start is called before the first frame update
    void Start()
    {
       //text = nameInputField.text;

    }

    // Update is called once per frame
    void Update()
    {
        Env.playerName = nameInputField.text;
        Debug.Log(Env.playerName);
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
