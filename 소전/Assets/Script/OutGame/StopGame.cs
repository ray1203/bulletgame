using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour {
    int f = 0;
    public GameObject pauseUI;
    public void stop()
    {
        if (f == 0)
        {
            pauseUI.SetActive(true);
            Time.timeScale = 0.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            f = 1;
        }
        else if (f == 1)
        {
            Time.timeScale = 1.0f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
            f = 0;
            pauseUI.SetActive(false);
        }

    }
}
