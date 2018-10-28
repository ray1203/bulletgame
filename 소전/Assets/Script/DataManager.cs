using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public static DataManager instance;
    public int highScore;
    public int score;
    private void Awake()
    {
        instance = this;
    }
    void Load()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    void Save()
    {
        if (score>highScore)
        {
            highScore = score;
            
        }
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}
