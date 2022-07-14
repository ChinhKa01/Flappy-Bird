using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text TextPoint;
    public GameObject GameStart;
    public GameObject GameOver;
    public Button ButtonRestart;
    public bool IsEndGame;
    int setpoint = 0;
    void Start()
    {
        Time.timeScale = 0;
        GameOver.SetActive(false);
        IsEndGame = false;
        GameStart.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1){
            GameStart.SetActive(false);
        }
    }
    public void StartGame(){
        Time.timeScale  =  1;
    }
    public void LoadingGame(){
        SceneManager.LoadScene(0);
    }
    public void end(){
        GameOver.SetActive(true);
        IsEndGame = true;
        Time.timeScale = 0;   
    }
    public void SetPoint(){
        setpoint++;
        TextPoint.text = "Score: " + setpoint;
    }
    public void Restart(){
        LoadingGame();
    }
}
