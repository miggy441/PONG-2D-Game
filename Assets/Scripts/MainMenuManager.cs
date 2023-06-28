using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    [Header("Main Menu Panel List")]
    public GameObject MainPanel;
    public GameObject HTPPanel;
    public GameObject BallPanel;
    public GameObject TimerPanel;
    public GameObject MusicOn;
    public GameObject MusicOff;
    private AudioSource audio;
    

    // Start is called before the first frame update
    void Start()
    {
        MainPanel.SetActive(true);
        HTPPanel.SetActive(false);
        BallPanel.SetActive(false);
        TimerPanel.SetActive(false);
        MusicOn.SetActive(true);
        MusicOff.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MusicOnButton()
    {
        MusicOff.SetActive(false);
        MusicOn.SetActive(true);
        GameData.instance.musicOn = true;
    }
    

    public void MusicOffButton()
    {
        MusicOff.SetActive(true);
        MusicOn.SetActive(false);
        GameData.instance.musicOn = false;
        
    }

    

    

    public void SinglePlayerButton()
    {
        GameData.instance.isSinglePlayer = true;
        TimerPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }
    
    public void MultiPlayerButton()
    {
        GameData.instance.isSinglePlayer = false;
        TimerPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }
    
    public void BackButton()
    {
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        BallPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }
    
    public void SetTimerButton(float Timer)
    {
        GameData.instance.gameTimer = Timer;
        HTPPanel.SetActive(false);
        TimerPanel.SetActive(false);
        BallPanel.SetActive(true);
        SoundManager.instance.UIClickSfx();
    }

    public void SetBallButton(GameObject ball)
    {
        GameData.instance.gameBall = ball;
        HTPPanel.SetActive(true);
        TimerPanel.SetActive(false);
        SoundManager.instance.UIClickSfx();
    }
    
    
    // public void Ball1Button()
    // {
    //     GameData.instance.gameBall1 = true;
    //     HTPPanel.SetActive(true);
    //     TimerPanel.SetActive(false);
    //     SoundManager.instance.UIClickSfx();
    // }

    // public void Ball2Button()
    // {
    //     GameData.instance.gameBall1 = false;
    //     HTPPanel.SetActive(true);
    //     TimerPanel.SetActive(false);
    //     SoundManager.instance.UIClickSfx();
    // }


    public void StartBtn()
    {
        SceneManager.LoadScene("2. Gameplay");
    }

    
    public void ExitGame()
    {
        Application.Quit();
    }
}
