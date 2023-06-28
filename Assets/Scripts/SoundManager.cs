using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip uiButton;
    public AudioClip ballBounce;
    public AudioClip goal;
    public AudioClip gameOver;
   
    private AudioSource audio;
    

    private void Awake()
    {
        if (instance != null)
            Destroy(gameOver);
        else
            instance = this;

        audio = GetComponent<AudioSource>();

     
    }

    //private void Start()
    //{
    //    if(!PlayerPrefs.HasKey("muted"))
    //    {
    //        PlayerPrefs.SetInt("muted", 0);
    //        Load();
    //    }

    //    else
    //    {
    //        Load();
    //    }
    //    UpdateButtonIcon();
    //}

    

    
    
    

    public void UIClickSfx()
    {
        audio.PlayOneShot(uiButton);
    }

    public void BallBounceSfx()
    {
        audio.PlayOneShot(ballBounce);
    }

    public void GoalSfx()
    {
        audio.PlayOneShot(goal);
    }

    public void GameOverSfx()
    {
        audio.PlayOneShot(gameOver);
    }


}
