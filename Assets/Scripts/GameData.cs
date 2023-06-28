using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameData : MonoBehaviour
{
    //Variabel instance membuat sebuah kelas dapat di panggil oleh kelas lainnya secara mudah
    public static GameData instance;

    public bool isSinglePlayer;
    public float gameTimer;
    public GameObject gameBall;
    public bool musicOn;

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        DontDestroyOnLoad(gameObject); //Menyimpan variabel walau berbeda scene
    }
    
}
