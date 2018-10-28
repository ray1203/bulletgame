using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIEndGame : MonoBehaviour {
    public GameObject panel;
    public GameObject aim;
    public Text scoreText;

    
    public void Open(int _score)
    {
        Time.timeScale = 0.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        aim.SetActive(false);
        panel.SetActive(true);
        scoreText.text = _score.ToString();
    }
    public void Close()
    {
        Time.timeScale = 1.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        aim.SetActive(true);
        panel.SetActive(false);
    }
    public void OnRestart()
    {
        Time.timeScale = 1.0f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneController.instance.Load("test");

    }
    public void OnMain()
    {
        SceneController.instance.Load("main");
    }
    public void OnExit()
    {
        Application.Quit();
    }
}
