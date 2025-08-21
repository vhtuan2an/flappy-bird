using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private bool isEndGame;
    private bool isStartGameFirstTime;
    public GameObject panelEndGame;
    public TMP_Text textEndPoint;
    public Button btnRestart;
    public TMP_Text textPoint;
    int gamePoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStartGameFirstTime = true;
        panelEndGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if(Input.GetMouseButtonDown(0) && isStartGameFirstTime)
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        StartGame();
    }

    public void GetPoint()
    {
        gamePoint++;
        textPoint.text = "Point: " + gamePoint.ToString();
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        isEndGame = true;
        isStartGameFirstTime = false;
        panelEndGame.SetActive(true);
        textEndPoint.text = "Your point\n" + gamePoint.ToString();
    }
}
